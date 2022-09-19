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
    public partial class CreatePlayer : Form
    {
        int counter = 0;

        public CreatePlayer()
        {
            InitializeComponent();
        }

        private int RaiseCounter(int counter) { counter++; return counter; }

        private void ClearTheFields()
        {
            firstName.Text = "";
            lastName.Text = "";
            email.Text = "";
            cellPhone.Text = "";
        }

        private void AddToListBox(int counter,string First,string Last)
        {
            
                TournamentPlayersListBox.Items.Add(counter.ToString() 
                    + " " + First 
                    + " " + Last);
            
        }

        private void CreatingAplayer(object sender, EventArgs e)
        {
            counter = RaiseCounter(counter);

            CreatePlayerBussLogic.Serializes(counter,firstName.Text, lastName.Text, email.Text, cellPhone.Text);
            
            AddToListBox(counter,firstName.Text, lastName.Text);

            ClearTheFields();
        }

        private void EndOfCreatingPlayers(object sender, EventArgs e)
        {
            CreatePlayerBussLogic.AddElementsToPlayersInfoTxt();

            this.Hide();

            TournamentCreateForm TourCreate = new TournamentCreateForm(true);

            TourCreate.ShowDialog();

            this.Close();
        }
    }
}
