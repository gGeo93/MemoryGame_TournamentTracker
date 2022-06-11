using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Repository;

namespace BussinessLogic
{
    public class RoundsBussLogic
    {
        public static TotalTournamentRounds TotalRoundsInfo = new TotalTournamentRounds();

        private static TournamentRound TournamentRoundInfo = new TournamentRound();

        private static List<string> RemainingCandidatesInfo = new List<string>();

        private static int CurrentRoundCounter = -1;

        public static void FirstRoundPLayers()
        {
            RemainCandidatesRepository.InputInitialPlayersToTxt();
        }

        public static void Serialize(List<int> PlayersScore,List<Person> RNCandidates)
        {
            List<string> CandidatesAndTheirScores = new List<string>();
            int i = PlayersScore.Count- RNCandidates.Count;
            foreach (var item in RNCandidates)
            {
                string str = item.ToString();
                if (str != "")
                {
                    CandidatesAndTheirScores.Add($"{item.TournamentId},{item.FirstName},{item.LastName},{PlayersScore[i].ToString()}");
                    i++;
                }
            }
            RemainCandidatesRepository.UpdateRemainedPlayersTxt(CandidatesAndTheirScores);
        }

        public static void Deserialize()
        {
            RemainingCandidatesInfo = RemainCandidatesRepository.OutputRemainedPlayersFromTxt();
            
            TournamentRound TR = new TournamentRound();
            foreach (var item in RemainingCandidatesInfo)
            {
                if (item != "")
                {
                    string[] items = item.Split(',');
                    TR.Candidates.Add(new Person(Convert.ToInt32(items[0]), items[1], items[2], Convert.ToInt32(items[3])));
                    TR.ScoresPerPlayer.Add(Convert.ToInt32(items[3]));
                }
            }

            CurrentRoundCounter++;

            TR.CurrentRound = CurrentRoundCounter;

            TotalRoundsInfo.Rounds.Add(TR);
        }

        public static List<string> PlayerToChoose()
        {
            return RemainingCandidatesInfo = RemainCandidatesRepository.OutputRemainedPlayersFromTxt();
        }

    }
}
