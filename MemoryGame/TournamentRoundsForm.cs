using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using BussinessLogic;

namespace MemoryGame
{
    public partial class TournamentRoundsForm : Form
    {
        string a;
        int RoundsCounter = 0;
        int CandidatesIndex=0;
        List<int> ListOfSumOfScoresPerPlayer = new List<int>();

        public TournamentRoundsForm()
        {
            InitializeComponent();
            InitialSituation();
        }

        private void FillTheInitialCandidatesList(List<Person> RCandidates)
        {
            foreach (var item in RCandidates)
            {
                if (item != null)
                {
                    PeoplePlaying.Items.Add($"{item.TournamentId} {item.FirstName} {item.LastName} {"0"}");
                }
            }
        }

        private void InitialSituation()
        {
            RoundsBussLogic.FirstRoundPLayers();

            RoundsBussLogic.Deserialize();

            RoundsComboBox.Items.Add(RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].CurrentRoundAndName[RoundsCounter]);

            FillTheInitialCandidatesList(RoundsBussLogic.TotalRoundsInfo.Rounds[0].Candidates);
        }

        private void ChosenPlayer(Person person)
        {
            ChosenPlayerTextBox.Text = $"{person.TournamentId} {person.FirstName} {person.LastName}";
        }

        private void GameBegin()
        {
            MessageBox.Show($"Game Begins");
        }

        private void InitializeBeforeTheGame()
        {
            ScoreOfChosenPlayertextBox.Text = "0";
            a = ChosenPlayerTextBox.Text;
        }
        
        private void MemoryGameEngine()
        {
            MemoryGameForm frm1 = new MemoryGameForm();
            frm1.AtoB(a);
            frm1.ShowDialog();
            ScoreOfChosenPlayertextBox.Text = frm1.ScoreOfTRF(this);
        }

        private void GameEnd()
        {
            MessageBox.Show("End of the game");
        }

        private void SaveTheScore()
        {
            RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].ScoresPerPlayer.Add(Convert.ToInt32(ScoreOfChosenPlayertextBox.Text));
        }

        private void FillCandidatesList(int[] SumOfScoresPerPlayer)
        {
            PeoplePlaying.Items.Clear();

            for (int i = 0; i < RoundsBussLogic.TotalRoundsInfo.Rounds.Count; i++)
            {
                PeoplePlaying.Items.Clear();
               
                for (int j = 0; j < RoundsBussLogic.TotalRoundsInfo.Rounds[i].Candidates.Count; j++)
                {
                    SumOfScoresPerPlayer[j] += RoundsBussLogic.TotalRoundsInfo.Rounds[i].Candidates[j].InstantScore;

                    PeoplePlaying.Items.Add($"{RoundsBussLogic.TotalRoundsInfo.Rounds[i].Candidates[j].TournamentId}," +
                        $"{RoundsBussLogic.TotalRoundsInfo.Rounds[i].Candidates[j].FirstName}," +
                        $"{RoundsBussLogic.TotalRoundsInfo.Rounds[i].Candidates[j].LastName}," +
                        $"{SumOfScoresPerPlayer[j]}");
                }
            }
        }

        private void TheWholeSumPerPlayer(int[] SumOfScoresPerPlayer)
        {
            for (int i = 0; i < SumOfScoresPerPlayer.Length; i++)
            {
                ListOfSumOfScoresPerPlayer.Add(SumOfScoresPerPlayer[i]);
            }
        }

        private List<int> CurrentScoresPerPlayer(List<int> OldScoresPerPlayer,List<int> LastRoundScoresPerPlayer)
        {
            List<int> NewScoresPerPlayer = new List<int>();
            for (int i = 0; i < LastRoundScoresPerPlayer.Count; i++)
            {
                NewScoresPerPlayer.Add(LastRoundScoresPerPlayer[i] + OldScoresPerPlayer[i]);
            }
            return NewScoresPerPlayer;
        }

        private void FillTheCandidatesList(List<Person> CurrentRoundlistOfPeople, List<Person> FirstRoundlistOfPeople, List<Person> SecondRoundlistOfPeople)
        {
            PeoplePlaying.Items.Clear();

            for (int i = 0; i < CurrentRoundlistOfPeople.Count; i++)
            {
                PeoplePlaying.Items.Add($"{CurrentRoundlistOfPeople[i].TournamentId}," +
                    $"{CurrentRoundlistOfPeople[i].FirstName}," +
                    $"{CurrentRoundlistOfPeople[i].LastName}," +
                    $"{CurrentRoundlistOfPeople[i].InstantScore + FirstRoundlistOfPeople[i].InstantScore + SecondRoundlistOfPeople[i].InstantScore}");
            }
        }

        private void FillTheCandidatesList(List<Person> CurrentRoundlistOfPeople, List<Person> FirstRoundlistOfPeople)
        {
            PeoplePlaying.Items.Clear();

            for (int i = 0; i < CurrentRoundlistOfPeople.Count; i++)
            {
                PeoplePlaying.Items.Add($"{CurrentRoundlistOfPeople[i].TournamentId}," +
                    $"{CurrentRoundlistOfPeople[i].FirstName}," +
                    $"{CurrentRoundlistOfPeople[i].LastName}," +
                    $"{CurrentRoundlistOfPeople[i].InstantScore + FirstRoundlistOfPeople[i].InstantScore}");
            }
        }

        private void FillTheCandidatesList(List<Person> CurrentRoundlistOfPeople)
        {
            PeoplePlaying.Items.Clear();

            for (int i = 0; i < CurrentRoundlistOfPeople.Count; i++)
            {
                PeoplePlaying.Items.Add($"{CurrentRoundlistOfPeople[i].TournamentId}," +
                    $"{CurrentRoundlistOfPeople[i].FirstName}," +
                    $"{CurrentRoundlistOfPeople[i].LastName}," +
                    $"{CurrentRoundlistOfPeople[i].InstantScore}");
            }
        }

        private void CheckIfTheTournamentIsover(int RoundsCounter)
        {
            if (RoundsCounter == 3)
            {
                MessegeAboutTheEndOfTheTournament();

                PrizesWinners(RoundsBussLogic.TotalRoundsInfo.Rounds[3].Candidates, ListOfSumOfScoresPerPlayer);
            }
        }

        private void MessegeAboutTheEndOfTheTournament()
        {
            MessageBox.Show("The Tournament is over");
        }

        private void PrizesWinners(List<Person> Candidates,List<int> SumOfScores)
        {
            for (int i = 0; i < SumOfScores.Count; i++)
            {
                Candidates[i].InstantScore = SumOfScores[i];
            }

            SumOfScores.Sort();

            SumOfScores.Reverse();

            Candidates = ReorderingTheCandidatesAccordingToTheirToTalScores(Candidates, SumOfScores);

            ShareThePrizes(Candidates);
        }

        List<Person> ReorderingTheCandidatesAccordingToTheirToTalScores(List<Person> Candidates, List<int> SumOfScores)
        {
            for (int i = 0; i < SumOfScores.Count; i++)
            {
                for (int j = 0; j < Candidates.Count; j++)
                {
                    if (SumOfScores[i] == Candidates[j].InstantScore)
                    {
                        Person temp = Candidates[j];
                        Candidates[j] = Candidates[i];
                        Candidates[i] = temp;
                    }
                }
            }
            return Candidates;
        }

        void ShareThePrizes(List<Person> Candidates)
        {
            List<PrizeModel> Prizes = PrizesBussLogic.Deserialize();
            for (int i = 0; i < Prizes.Count; i++)
            {
                string str = $"The player: {Candidates[i].TournamentId} " +
                    $"{Candidates[i].FirstName} " +
                    $"{Candidates[i].LastName} " +
                    $"wins the: {Prizes[i].PlaceName} place ";

                if (Prizes[i].PrizeAmount != 0)
                {
                    str += $"{Prizes[i].PrizeAmount}€";
                }
                else if (Prizes[i].PrizePercentage>0)
                {
                    str += $"{Prizes[i].PrizePercentage/100*30*Candidates.Count}€";
                }

                MessageBox.Show(str);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {

            ChosenPlayer(RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates[CandidatesIndex]);

            System.Threading.Thread.Sleep(200);

            GameBegin();

            InitializeBeforeTheGame();

            MemoryGameEngine();

            GameEnd();

            SaveTheScore();

            CandidatesIndex++;

        }

        private void PeoplePlayingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(PeoplePlayingCheckBox.Checked)
            {
                for (int i = 0; i < CandidatesIndex; i++)
                {
                    PeoplePlaying.Items.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < CandidatesIndex; i++)
                {
                    PeoplePlaying.Items.Insert(i,$"{RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates[i].TournamentId} {RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates[i].FirstName} {RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates[i].LastName} {RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].ScoresPerPlayer[i]}");
                }
            }
        }

        private void NextRound_Click(object sender, EventArgs e)
        {
            if (CandidatesIndex == RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates.Count)
            {

                int[] SumOfScoresPerPlayer = new int[RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates.Count];

                CandidatesIndex = 0;

                RoundsBussLogic.Serialize(RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].ScoresPerPlayer, RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].Candidates);

                RoundsCounter++;

                RoundsBussLogic.Deserialize();

                RoundsComboBox.Items.Add(RoundsBussLogic.TotalRoundsInfo.Rounds[RoundsCounter].CurrentRoundAndName[RoundsCounter]);

                FillCandidatesList(SumOfScoresPerPlayer);

                if (RoundsCounter==3)
                {
                    TheWholeSumPerPlayer(SumOfScoresPerPlayer);
                }

                ChosenPlayerTextBox.Text = "";

                ScoreOfChosenPlayertextBox.Text = "";

                CheckIfTheTournamentIsover(RoundsCounter);

            }
        }

        private void RoundsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoundsComboBox.Text=="Initial State")
            {
                FillTheCandidatesList(RoundsBussLogic.TotalRoundsInfo.Rounds[0].Candidates);
            }
            else if (RoundsComboBox.Text == "First")
            {
                if (RoundsBussLogic.TotalRoundsInfo.Rounds.Count > 1)
                {
                    FillTheCandidatesList(RoundsBussLogic.TotalRoundsInfo.Rounds[1].Candidates);
                }
            }
            else if (RoundsComboBox.Text == "Second")
            {
                if (RoundsBussLogic.TotalRoundsInfo.Rounds.Count > 2)
                {
                    FillTheCandidatesList(RoundsBussLogic.TotalRoundsInfo.Rounds[2].Candidates, RoundsBussLogic.TotalRoundsInfo.Rounds[1].Candidates);
                }
            }
            else if (RoundsComboBox.Text == "Third")
            {
                if (RoundsBussLogic.TotalRoundsInfo.Rounds.Count > 3)
                {
                    FillTheCandidatesList(RoundsBussLogic.TotalRoundsInfo.Rounds[3].Candidates, RoundsBussLogic.TotalRoundsInfo.Rounds[2].Candidates, RoundsBussLogic.TotalRoundsInfo.Rounds[1].Candidates);
                }
            }
            
        }
    }
}
