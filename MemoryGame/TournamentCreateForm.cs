using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic;
using ClassLibrary;

namespace MemoryGame
{
    public partial class TournamentCreateForm : Form
    {
        private static TournamentMode TourMode = new TournamentMode();

        private static List<Person> PeopleAfterTheRemove { get; set; } = new List<Person>();

        private static List<PrizeModel> PrizesAfterTheRemove { get; set; } = new List<PrizeModel>();

        private bool IsLoading { get; set; } = false;

        public TournamentCreateForm()
        {
            InitializeComponent();
            CreatePlayerBussLogic.InitializeFilesOnPrimaryLoad();
            TournamentName.Text = "Memory Game Competition";
            EntryFee.Text = "30";
        }

        public TournamentCreateForm(bool CPL)
        {
            InitializeComponent();
            TournamentName.Text = "Memory Game Competition";
            EntryFee.Text = "30";
            IsLoading = CPL;
        }
        
        private bool CheckIfTheElementOfOneOrMorePlayersExists(string ChooseOneOrMorePlayers)
        {
            return listOfPlayers.Text.Contains(ChooseOneOrMorePlayers);
        }

        private void AddPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatePlayer CP = new CreatePlayer();
            CP.ShowDialog();
            this.Close();
        }

        private void FillingTheListOfPlayers(List<Person> EnterPeople)
        {
            int countId = 0;
            foreach (var item in EnterPeople)
            {
                countId++;
                item.TournamentId = countId;
                if (item.FirstName != "" && item.FirstName != null)
                {
                    listOfPlayers.Items.Add($"{item.TournamentId} {item.FirstName} {item.LastName}");
                }
            }
        }

        private void FillingTheListOfPrizes(List<PrizeModel> Prizes)
        {
            foreach (var item in Prizes)
            {
                listOfPrizes.Items.Add($"{item.PlaceNumber} {item.PlaceName} {item.PrizeAmount} {item.PrizePercentage}");
            }
        }

        private void CreatePrizes_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrizeCreator PC = new PrizeCreator();
            PC.ShowDialog();
            this.Close();
        }

        private void TournamentCreate_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load");

            if (IsLoading)
            {
                List<Person> HelpingListPlayers = new List<Person>();

                HelpingListPlayers = CreatePlayerBussLogic.Deserialize();

                TourMode.EnteredPeople.Clear();

                foreach (var item in HelpingListPlayers)
                {
                    TourMode.EnteredPeople.Add(item);
                }

                FillingTheListOfPlayers(TourMode.EnteredPeople);


                List<PrizeModel> HelpingListPrizes = new List<PrizeModel>();

                HelpingListPrizes = PrizesBussLogic.Deserialize();

                TourMode.Prizes.Clear();

                foreach (var item in HelpingListPrizes)
                {
                    TourMode.Prizes.Add(item);
                }

                FillingTheListOfPrizes(TourMode.Prizes);
            }
        }

        private void DeleteSelectedPlayer_Click(object sender, EventArgs e)
        {
            string selectedParticipant = listOfPlayers.Text;
            if ( selectedParticipant != null && selectedParticipant != string.Empty)
            {
                CreatePlayerBussLogic.Serializes(listOfPlayers.SelectedItem.ToString());
                listOfPlayers.Items.Clear();
                PeopleAfterTheRemove.Clear();
                PeopleAfterTheRemove = CreatePlayerBussLogic.Deserialize();
                FillingTheListOfPlayers(PeopleAfterTheRemove);
            }
            else 
            {
                MessageBox.Show("No participant selected.Please select the participant you wish to remove");
            }
        }

        private void DeleteSelectedPrize_Click(object sender, EventArgs e)
        {
            List<PrizeModel> PrizesBeforeThePropableRemove = PrizesBussLogic.Deserialize();
            if (PrizesBeforeThePropableRemove.Count == listOfPrizes.SelectedIndex + 1)
            {
                PrizesBussLogic.Serialize(listOfPrizes.SelectedItem.ToString());
                listOfPrizes.Items.Clear();
                PrizesAfterTheRemove.Clear();
                PrizesAfterTheRemove = PrizesBussLogic.Deserialize();
                FillingTheListOfPrizes(PrizesAfterTheRemove);
            }
        }

        private void CreateTournament_Click(object sender, EventArgs e)
        {
            if (PeopleAfterTheRemove.Count >= 2)
            {
                this.Hide();
                TournamentRoundsForm TR = new TournamentRoundsForm();
                TR.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Not enough Participants.");
            }
        }

        
    }
}
