using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;

namespace Repository
{
    public static class PlayersRepository
    {
        static readonly string relativePartOfPlayersPath = @"..\..\";
        static string totalPlayerspath = relativePartOfPlayersPath + "TotalPlayersInfo.txt";

        static string temporaryPlayerspath = relativePartOfPlayersPath + "TemporaryPlayersInfo.txt";

        static string middleFilePath = relativePartOfPlayersPath + "MiddleFilePath.txt";

        private static void InputTemporaryPlayersToTxt(List<Person> Players)
        {
            StreamWriter strw = new StreamWriter(temporaryPlayerspath);

            foreach (var item in Players)
            {
                strw.WriteLine(item.TournamentId.ToString()
                    + "," + item.FirstName
                    + "," + item.LastName
                    + "," + item.Email
                    + "," + item.CellPhone);
            }
            strw.Close();
        }

        private static void InputTotalPlayersToTxt()
        {
            string[] strR = OutputPlayersFromTxt();

            File.AppendAllLines(totalPlayerspath, strR);

            string[] RemovingBlankLine = File.ReadAllLines(totalPlayerspath);

            RemovingBlankLine.ToList().Remove("");

            File.WriteAllLines(totalPlayerspath, RemovingBlankLine);

            strR = OutputPlayersFromTxt(null);

            File.Delete(totalPlayerspath);

            File.WriteAllLines(totalPlayerspath, strR);
        }
        private static void InitializeFile(string path) 
        {
            if (File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
            else
            {
                File.Create(path);
            }
        }
        public static void InitializeAllTextFiles() 
        {
            InitializeFile(totalPlayerspath);
            InitializeFile(temporaryPlayerspath);
            InitializeFile(middleFilePath);
        }
        public static void RemovePlayerFromTxt(string PlayerToRemove)
        {
            string lineOfAplayer = null;

            StreamReader strR = new StreamReader(totalPlayerspath);

            StreamWriter strW = new StreamWriter(middleFilePath, false);

            while ((lineOfAplayer = strR.ReadLine()) != null)
            {
                if (lineOfAplayer!="" && lineOfAplayer[0] == PlayerToRemove[0])
                    continue;

                strW.WriteLine(lineOfAplayer);

            }

            strR.Close();
            strW.Close();

            File.Delete(totalPlayerspath);
            File.Copy(middleFilePath, totalPlayerspath);

            AutoIncrement();
        }

        private static void AutoIncrement()
        {
            string[] strArray = File.ReadAllLines(totalPlayerspath);
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
            File.WriteAllLines(totalPlayerspath, strArray);
        }

        public static void InputPlayersToTxt(List<Person> Players)
        {

            InputTemporaryPlayersToTxt(Players);

            InputTotalPlayersToTxt();

        }

        public static string[] OutputPlayersFromTxt()
        {
            int counterForAutoIncrement = 0;
            string[] strArray = File.ReadAllLines(temporaryPlayerspath);
            string str;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] != "")
                {
                    counterForAutoIncrement++;
                    str = strArray[i].Remove(0, 1);
                    str = str.Insert(0, counterForAutoIncrement.ToString());
                    strArray[i] = str;
                }
            }
            return strArray;
        }

        public static string[] OutputPlayersFromTxt(string nullableInput)
        {
            int counterForAutoIncrement = 0;
            string[] strArray = File.ReadAllLines(totalPlayerspath);
            string str;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] != "")
                {
                    counterForAutoIncrement++;
                    str = strArray[i].Remove(0, 1);
                    str = str.Insert(0, counterForAutoIncrement.ToString());
                    strArray[i] = str;
                }
            }
            return strArray;
        }
    }
}
