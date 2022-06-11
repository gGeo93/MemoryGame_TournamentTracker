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
    public partial class PrizeCreator : Form
    {
        public PrizeCreator()
        {
            InitializeComponent();
            ClearTheFields();
        }

        private void ClearTheFields()
        {
            PlaceNumber.Text = "";
            PlaceName.Text = "";
            PrizeAmount.Text = "";
            PrizePercentage.Text = "0";
        }

        private void CreatePrize_btn(object sender, EventArgs e)
        {
            //Έλεγχος αν τα δεδομένα είναι σωστά
            PrizesBussLogic.Serialize(PlaceNumber.Text,
                PlaceName.Text,
                PrizeAmount.Text,
                PrizePercentage.Text);
            ClearTheFields();
        }

        private void EndOfCreatingPrizes_btn(object sender, EventArgs e)
        {
            //Έλεγχος αν είναι σε εξέλιξη κάποιο βραβείο
            PrizesBussLogic.AddElementsToPrizesinfoTxt(PrizesBussLogic.ListOfPrizes);

            //TournamentCreate.CreatePlayerLoad(false);

            this.Hide();

            TournamentCreate TourCreate = new TournamentCreate(true);

            TourCreate.ShowDialog();

            this.Close();
        }
    }
}
