using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        const string partOfTheAbsolutePicsPath = @"C:\Users\USER\Desktop\Memory Game Tournament\MemoryGameTournamentTracker-master\MemoryGame\MemoryGame\";
        Bitmap[] nullBitmap = new Bitmap[16];
        List<Bitmap> myImages = new List<Bitmap>();
        Bitmap[] MemoryBoard = new Bitmap[16];
        List<PictureBox> PicBox = new List<PictureBox>();
        int OpenImagesCounter=1;
        int index1=-1, index2=-2;
        int NumberOfTries = 10;
        bool EndOfTheGame = false;

        public Form1()
        {
            InitializeComponent();
            DragTheImages();
            BoardFill();
            PicBoxFill();
            InitializeTheGame();
            score.Text = Convert.ToString(NumberOfTries);
        }

        private void InitializeTheGame()
        {
            for (int i = 0; i < nullBitmap.Length; i++)
            {
                nullBitmap[i] = new Bitmap(1, 1);
            }
            pictureBox1.Image = nullBitmap[0];
            pictureBox2.Image = nullBitmap[1];
            pictureBox3.Image = nullBitmap[2];
            pictureBox4.Image = nullBitmap[3];
            pictureBox5.Image = nullBitmap[4];
            pictureBox6.Image = nullBitmap[5];
            pictureBox7.Image = nullBitmap[6];
            pictureBox8.Image = nullBitmap[7];
            pictureBox9.Image = nullBitmap[8];
            pictureBox10.Image = nullBitmap[9];
            pictureBox11.Image = nullBitmap[10];
            pictureBox12.Image = nullBitmap[11];
            pictureBox13.Image = nullBitmap[12];
            pictureBox14.Image = nullBitmap[13];
            pictureBox15.Image = nullBitmap[14];
            pictureBox16.Image = nullBitmap[15];
        }

        private void DragTheImages()
        {
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "pikatsu.png"));
            myImages.Add(myImages[0]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "bulbasar.png"));
            myImages.Add(myImages[2]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "charizard.png"));
            myImages.Add(myImages[4]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "jigglypuff.png"));
            myImages.Add(myImages[6]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "magircap.png"));
            myImages.Add(myImages[8]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "mewtwo.png"));
            myImages.Add(myImages[10]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "monkey.png"));
            myImages.Add(myImages[12]);
            myImages.Add(new Bitmap(partOfTheAbsolutePicsPath + "squirtle.png"));
            myImages.Add(myImages[14]);
        }
        private void BoardFill()
        {
            List<Bitmap> duplicate = new List<Bitmap>();
            for (int i = 0; i < myImages.Count; i++)
            {
                duplicate.Add(myImages[i]);
            }
            Random rn = new Random();
            for (int i = 0; i < myImages.Count; i++)
            {
                int tixaios = rn.Next(0, myImages.Count - i - 1);
                MemoryBoard[i] = duplicate[tixaios];
                duplicate.RemoveAt(tixaios);
            }
        }

        private void PicBoxFill()
        {
            PicBox.Add(pictureBox1);
            PicBox.Add(pictureBox2);
            PicBox.Add(pictureBox3);
            PicBox.Add(pictureBox4);
            PicBox.Add(pictureBox5);
            PicBox.Add(pictureBox6);
            PicBox.Add(pictureBox7);
            PicBox.Add(pictureBox8);
            PicBox.Add(pictureBox9);
            PicBox.Add(pictureBox10);
            PicBox.Add(pictureBox11);
            PicBox.Add(pictureBox12);
            PicBox.Add(pictureBox13);
            PicBox.Add(pictureBox14);
            PicBox.Add(pictureBox15);
            PicBox.Add(pictureBox16);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Καλό παιχνίδι!");
        }

        private async void pokemon(object sender, EventArgs e)
        {
            if (OpenImagesCounter < 3)
            {
                PictureBox pic = (PictureBox)sender;
                for (int i = 0; i < PicBox.Count; i++)
                {
                    if (PicBox[i].Tag == pic.Tag)
                    {
                        if (OpenImagesCounter == 1)
                            index1 = i;
                        else if (OpenImagesCounter == 2)
                            index2 = i;
                        PicBox[i].Image = MemoryBoard[i];
                        break;
                    }
                }
                if (index1 == index2) { index2 = -1; OpenImagesCounter = 1; }
                OpenImagesCounter++;
            }
            if (index2!=-1 && OpenImagesCounter>2 && (MemoryBoard[index1] != MemoryBoard[index2]))
            {
                await Task.Delay(2000);
                NumberOfTries--;
                score.Text = Convert.ToString(NumberOfTries);
                PicBox[index1].Image = nullBitmap[index1];
                PicBox[index2].Image = nullBitmap[index2];
                OpenImagesCounter = 1;
            }
            if (OpenImagesCounter>2)
            {
                OpenImagesCounter = 1;
            }
            EndOfTheGame = true;
            if (NumberOfTries > 0) { EndOfTheGame = false; }
            if (EndOfTheGame)
            {
                MessageBox.Show("Τέλειωσαν οι προσπάθειες. Δυστυχώς χάσατε.");
                this.Hide();
                this.Close();
            }
            EndOfTheGame = true;
            for (int i = 0; i < PicBox.Count; i++)
            {
                if (PicBox[i].Image == nullBitmap[i])
                {
                    EndOfTheGame = false;
                }
            }
            if (EndOfTheGame)
            {
                MessageBox.Show("Συγχαρητήρια!Ολοκληρώσατε το παιχνίδι!");
                this.Hide();
                this.Close();
            }
        }

        public void AtoB(string a)
        {
            PlayerElements.Text = a;
        }

        public string ScoreOfTRF(TournamentRoundsForm TRF)
        {
            return NumberOfTries.ToString();
        }
    }
}
