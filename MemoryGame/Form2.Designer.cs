namespace MemoryGame
{
    partial class TournamentRoundsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PeoplePlayingCheckBox = new System.Windows.Forms.CheckBox();
            this.PeoplePlaying = new System.Windows.Forms.ListBox();
            this.CurrentChosenPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreOfChosenPlayertextBox = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.ChosenPlayerTextBox = new System.Windows.Forms.TextBox();
            this.RoundsComboBox = new System.Windows.Forms.ComboBox();
            this.NextRound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(182, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "MemoryGame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(57, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Round";
            // 
            // PeoplePlayingCheckBox
            // 
            this.PeoplePlayingCheckBox.AutoSize = true;
            this.PeoplePlayingCheckBox.Location = new System.Drawing.Point(139, 136);
            this.PeoplePlayingCheckBox.Name = "PeoplePlayingCheckBox";
            this.PeoplePlayingCheckBox.Size = new System.Drawing.Size(92, 17);
            this.PeoplePlayingCheckBox.TabIndex = 4;
            this.PeoplePlayingCheckBox.Text = "UnplayedOnly";
            this.PeoplePlayingCheckBox.UseVisualStyleBackColor = true;
            this.PeoplePlayingCheckBox.CheckedChanged += new System.EventHandler(this.PeoplePlayingCheckBox_CheckedChanged);
            // 
            // PeoplePlaying
            // 
            this.PeoplePlaying.FormattingEnabled = true;
            this.PeoplePlaying.Location = new System.Drawing.Point(69, 199);
            this.PeoplePlaying.Name = "PeoplePlaying";
            this.PeoplePlaying.Size = new System.Drawing.Size(258, 225);
            this.PeoplePlaying.TabIndex = 5;
            // 
            // CurrentChosenPlayer
            // 
            this.CurrentChosenPlayer.AutoSize = true;
            this.CurrentChosenPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentChosenPlayer.Location = new System.Drawing.Point(359, 281);
            this.CurrentChosenPlayer.Name = "CurrentChosenPlayer";
            this.CurrentChosenPlayer.Size = new System.Drawing.Size(211, 20);
            this.CurrentChosenPlayer.TabIndex = 6;
            this.CurrentChosenPlayer.Text = "ChosenPlayerToPlayNow:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(368, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score:";
            // 
            // ScoreOfChosenPlayertextBox
            // 
            this.ScoreOfChosenPlayertextBox.AccessibleName = "";
            this.ScoreOfChosenPlayertextBox.Location = new System.Drawing.Point(477, 366);
            this.ScoreOfChosenPlayertextBox.Name = "ScoreOfChosenPlayertextBox";
            this.ScoreOfChosenPlayertextBox.Size = new System.Drawing.Size(157, 20);
            this.ScoreOfChosenPlayertextBox.TabIndex = 8;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(664, 326);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(109, 33);
            this.Play.TabIndex = 9;
            this.Play.Text = "Next Player";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // ChosenPlayerTextBox
            // 
            this.ChosenPlayerTextBox.Location = new System.Drawing.Point(477, 310);
            this.ChosenPlayerTextBox.Name = "ChosenPlayerTextBox";
            this.ChosenPlayerTextBox.Size = new System.Drawing.Size(157, 20);
            this.ChosenPlayerTextBox.TabIndex = 10;
            // 
            // RoundsComboBox
            // 
            this.RoundsComboBox.FormattingEnabled = true;
            this.RoundsComboBox.Location = new System.Drawing.Point(139, 91);
            this.RoundsComboBox.Name = "RoundsComboBox";
            this.RoundsComboBox.Size = new System.Drawing.Size(140, 21);
            this.RoundsComboBox.TabIndex = 11;
            this.RoundsComboBox.Text = "Initial Values";
            this.RoundsComboBox.SelectedIndexChanged += new System.EventHandler(this.RoundsComboBox_SelectedIndexChanged);
            // 
            // NextRound
            // 
            this.NextRound.Location = new System.Drawing.Point(363, 80);
            this.NextRound.Name = "NextRound";
            this.NextRound.Size = new System.Drawing.Size(108, 32);
            this.NextRound.TabIndex = 12;
            this.NextRound.Text = "Next Round";
            this.NextRound.UseVisualStyleBackColor = true;
            this.NextRound.Click += new System.EventHandler(this.NextRound_Click);
            // 
            // TournamentRoundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextRound);
            this.Controls.Add(this.RoundsComboBox);
            this.Controls.Add(this.ChosenPlayerTextBox);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.ScoreOfChosenPlayertextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentChosenPlayer);
            this.Controls.Add(this.PeoplePlaying);
            this.Controls.Add(this.PeoplePlayingCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TournamentRoundsForm";
            this.Text = "Tournament Rounds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PeoplePlayingCheckBox;
        private System.Windows.Forms.ListBox PeoplePlaying;
        private System.Windows.Forms.Label CurrentChosenPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ComboBox RoundsComboBox;
        private System.Windows.Forms.TextBox ChosenPlayerTextBox;
        private System.Windows.Forms.TextBox ScoreOfChosenPlayertextBox;
        private System.Windows.Forms.Button NextRound;
    }
}