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
        static readonly string absolutePartOfPleyrsPath = @"C:\Users\USER\Desktop\Memory Game Tournament\MemoryGameTournamentTracker-master\MemoryGame\Repository\";
        static string TotalPlayerspath = absolutePartOfPleyrsPath + "TotalPlayersInfo.txt";

        static string TemporaryPlayerspath = absolutePartOfPleyrsPath + "TemporaryPlayersInfo.txt";

        static string MiddleFilePath = absolutePartOfPleyrsPath + "MiddleFilePath.txt";

        private static void InputTemporaryPlayersToTxt(List<Person> Players)
        {
            StreamWriter strw = new StreamWriter(TemporaryPlayerspath);

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

            File.AppendAllLines(TotalPlayerspath, strR);

            string[] RemovingBlankLine = File.ReadAllLines(TotalPlayerspath);

            RemovingBlankLine.ToList().Remove("");

            File.WriteAllLines(TotalPlayerspath, RemovingBlankLine);

            strR = OutputPlayersFromTxt(null);

            File.Delete(TotalPlayerspath);

            File.WriteAllLines(TotalPlayerspath, strR);
        }

        public static void RemovePlayerFromTxt(string PlayerToRemove)
        {
            string lineOfAplayer = null;

            StreamReader strR = new StreamReader(TotalPlayerspath);

            StreamWriter strW = new StreamWriter(MiddleFilePath, false);

            while ((lineOfAplayer = strR.ReadLine()) != null)
            {
                if (lineOfAplayer!="" && lineOfAplayer[0] == PlayerToRemove[0])
                    continue;

                strW.WriteLine(lineOfAplayer);

            }

            strR.Close();
            strW.Close();

            File.Delete(TotalPlayerspath);
            File.Copy(MiddleFilePath, TotalPlayerspath);

            AutoIncrement();
        }

        private static void AutoIncrement()
        {
            string[] strArray = File.ReadAllLines(TotalPlayerspath);
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
            File.WriteAllLines(TotalPlayerspath, strArray);
        }

        public static void InputPlayersToTxt(List<Person> Players)
        {

            InputTemporaryPlayersToTxt(Players);

            InputTotalPlayersToTxt();

        }

        public static string[] OutputPlayersFromTxt()
        {
            int counterForAutoIncrement = 0;
            string[] strArray = File.ReadAllLines(TemporaryPlayerspath);
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
            string[] strArray = File.ReadAllLines(TotalPlayerspath);
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
