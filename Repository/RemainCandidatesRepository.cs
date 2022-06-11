using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary;

namespace Repository
{
    public static class RemainCandidatesRepository
    {
        static readonly string absolutePartOfRemainedCandidatesFiles = @"..\..\";
        
        static readonly string RemainedPlayerspath = absolutePartOfRemainedCandidatesFiles + "RemainedCandidates.txt";

        static readonly string TotalPlayerspath = absolutePartOfRemainedCandidatesFiles + "TotalPlayersInfo.txt";

        private static void TurnTheFileIntoUsefullData()
        {
            List<string> listOfStr = new List<string>();
            string[] strArray = File.ReadAllLines(RemainedPlayerspath);
            foreach (var item in strArray)
            {
                if (item != "")
                {
                    string[] strArray2 = item.Split(',');
                    listOfStr.Add(strArray2[0] + "," + strArray2[1] + "," + strArray2[2] + ",0");
                }
            }
            File.WriteAllLines(RemainedPlayerspath, listOfStr.ToArray());
        }

        public static void InputInitialPlayersToTxt()
        {
            try
            {
                File.Delete(RemainedPlayerspath);
                File.Copy(TotalPlayerspath, RemainedPlayerspath);
            }
            catch
            {
                File.Copy(TotalPlayerspath, RemainedPlayerspath);
            }
            TurnTheFileIntoUsefullData();
        }

        public static List<string> OutputRemainedPlayersFromTxt()
        {
            List<string> RemainedPlayersFromTxt = File.ReadAllLines(RemainedPlayerspath).ToList();
            return RemainedPlayersFromTxt;
        }

        public static void UpdateRemainedPlayersTxt(List<string> CandidatesAndTheirScores)
        {
            string[] strArray = CandidatesAndTheirScores.ToArray();
            File.Delete(RemainedPlayerspath);
            File.WriteAllLines(RemainedPlayerspath, strArray);
        }
    }
}
