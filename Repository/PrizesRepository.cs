using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary;


namespace Repository
{
    public static class PrizesRepository
    {
        static readonly string absolutePartOfPathPrizesFiles = @"..\..\";
        
        static string PrizesPath = absolutePartOfPathPrizesFiles + "Prizesinfo.txt";

        static string MiddleFilePath2 = absolutePartOfPathPrizesFiles + "MiddleFilePath2.txt";

        public static void InputPrizesToTxt(List<PrizeModel> ListOfPrizes)
        {
            StreamWriter strm = new StreamWriter(PrizesPath);
            strm.WriteLine();
            foreach (var item in ListOfPrizes)
            {
                strm.WriteLine(item.PlaceNumber.ToString()
                    + "," + item.PlaceName
                    + "," + item.PrizeAmount
                    + "," + item.PrizePercentage);
            }
            strm.Close();
        }

        public static List<string> OutputPrizesFromTxt()
        {
            List<string> strList = new List<string>();
            strList = File.ReadAllLines(PrizesPath).ToList();
            return strList;
        }

        public static void RemovePrizeFromTxt(string PrizeToRemove)
        {
            string lineOfAprize = null;

            StreamReader strR = new StreamReader(PrizesPath);

            StreamWriter strW = new StreamWriter(MiddleFilePath2, false);

            while ((lineOfAprize = strR.ReadLine()) != null)
            {
                if (lineOfAprize != "" && lineOfAprize[0] == PrizeToRemove[0])
                    continue;

                strW.WriteLine(lineOfAprize);

            }

            strR.Close();
            strW.Close();

            File.Delete(PrizesPath);
            File.Copy(MiddleFilePath2, PrizesPath);

            AutoIncrement();
        }

        private static void AutoIncrement()
        {
            string[] strArray = File.ReadAllLines(PrizesPath);
            string[] helpingArray = new string[10];
            int k = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] != "")
                {
                    helpingArray[i] = strArray[i].Remove(0, 1);
                    strArray[i] = helpingArray[i].Insert(0, (k + 1).ToString());//i+1
                    k += 1;
                }
            }
            File.WriteAllLines(PrizesPath, strArray);
        }
    }
}
