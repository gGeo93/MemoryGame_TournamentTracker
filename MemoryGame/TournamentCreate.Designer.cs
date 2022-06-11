namespace MemoryGame
{
    partial class TournamentCreate
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
            this.CtrToutnament = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EntryFee = new System.Windows.Forms.TextBox();
            this.SelectPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPlayers = new System.Windows.Forms.Button();
            this.CreatePrizes = new System.Windows.Forms.Button();
            this.CreateTournament = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listOfPlayers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listOfPrizes = new System.Windows.Forms.ListBox();
            this.DeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.DeleteSelectedPrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CtrToutnament
            // 
            this.CtrToutnament.AutoSize = true;
            this.CtrToutnament.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CtrToutnament.Location = new System.Drawing.Point(35, 26);
            this.CtrToutnament.Name = "CtrToutnament";
            this.CtrToutnament.Size = new System.Drawing.Size(161, 22);
            this.CtrToutnament.TabIndex = 0;
            this.CtrToutnament.Text = "CreateTournament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tournament Name";
            // 
            // TournamentName
            // 
            this.TournamentName.Location = new System.Drawing.Point(53, 104);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.ReadOnly = true;
            this.TournamentName.Size = new System.Drawing.Size(191, 20);
            this.TournamentName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(49, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entry Fee";
            // 
            // EntryFee
            // 
            this.EntryFee.Location = new System.Drawing.Point(161, 152);
            this.EntryFee.Name = "EntryFee";
            this.EntryFee.ReadOnly = true;
            this.EntryFee.Size = new System.Drawing.Size(83, 20);
            this.EntryFee.TabIndex = 4;
            // 
            // SelectPlayer
            // 
            this.SelectPlayer.Location = new System.Drawing.Point(64, 237);
            this.SelectPlayer.Name = "SelectPlayer";
            this.SelectPlayer.ReadOnly = true;
            this.SelectPlayer.Size = new System.Drawing.Size(179, 20);
            this.SelectPlayer.TabIndex = 5;
            this.SelectPlayer.Text = "No use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(61, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Player";
            // 
            // AddPlayers
            // 
            this.AddPlayers.Location = new System.Drawing.Point(100, 291);
            this.AddPlayers.Name = "AddPlayers";
            this.AddPlayers.Size = new System.Drawing.Size(96, 28);
            this.AddPlayers.TabIndex = 7;
            this.AddPlayers.Text = "Add Players";
            this.AddPlayers.UseVisualStyleBackColor = true;
            this.AddPlayers.Click += new System.EventHandler(this.AddPlayers_Click);
            // 
            // CreatePrizes
            // 
            this.CreatePrizes.Location = new System.Drawing.Point(100, 339);
            this.CreatePrizes.Name = "CreatePrizes";
            this.CreatePrizes.Size = new System.Drawing.Size(96, 27);
            this.CreatePrizes.TabIndex = 8;
            this.CreatePrizes.Text = "Create Prizes";
            this.CreatePrizes.UseVisualStyleBackColor = true;
            this.CreatePrizes.Click += new System.EventHandler(this.CreatePrizes_Click);
            // 
            // CreateTournament
            // 
            this.CreateTournament.Location = new System.Drawing.Point(261, 395);
            this.CreateTournament.Name = "CreateTournament";
            this.CreateTournament.Size = new System.Drawing.Size(149, 43);
            this.CreateTournament.TabIndex = 9;
            this.CreateTournament.Text = "Create Tournament";
            this.CreateTournament.UseVisualStyleBackColor = true;
            this.CreateTournament.Click += new System.EventHandler(this.CreateTournament_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(427, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Players";
            // 
            // listOfPlayers
            // 
            this.listOfPlayers.FormattingEnabled = true;
            this.listOfPlayers.Location = new System.Drawing.Point(430, 91);
            this.listOfPlayers.Name = "listOfPlayers";
            this.listOfPlayers.Size = new System.Drawing.Size(216, 134);
            this.listOfPlayers.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(427, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prizes";
            // 
            // listOfPrizes
            // 
            this.listOfPrizes.FormattingEnabled = true;
            this.listOfPrizes.Location = new System.Drawing.Point(431, 258);
            this.listOfPrizes.Name = "listOfPrizes";
            this.listOfPrizes.Size = new System.Drawing.Size(215, 134);
            this.listOfPrizes.TabIndex = 13;
            // 
            // DeleteSelectedPlayer
            // 
            this.DeleteSelectedPlayer.Location = new System.Drawing.Point(652, 90);
            this.DeleteSelectedPlayer.Name = "DeleteSelectedPlayer";
            this.DeleteSelectedPlayer.Size = new System.Drawing.Size(141, 49);
            this.DeleteSelectedPlayer.TabIndex = 14;
            this.DeleteSelectedPlayer.Text = "Delete Selected";
            this.DeleteSelectedPlayer.UseVisualStyleBackColor = true;
            this.DeleteSelectedPlayer.Click += new System.EventHandler(this.DeleteSelectedPlayer_Click);
            // 
            // DeleteSelectedPrize
            // 
            this.DeleteSelectedPrize.Location = new System.Drawing.Point(654, 258);
            this.DeleteSelectedPrize.Name = "DeleteSelectedPrize";
            this.DeleteSelectedPrize.Size = new System.Drawing.Size(139, 49);
            this.DeleteSelectedPrize.TabIndex = 15;
            this.DeleteSelectedPrize.Text = "Delete Selected";
            this.DeleteSelectedPrize.UseVisualStyleBackColor = true;
            this.DeleteSelectedPrize.Click += new System.EventHandler(this.DeleteSelectedPrize_Click);
            // 
            // TournamentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteSelectedPrize);
            this.Controls.Add(this.DeleteSelectedPlayer);
            this.Controls.Add(this.listOfPrizes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listOfPlayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateTournament);
            this.Controls.Add(this.CreatePrizes);
            this.Controls.Add(this.AddPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectPlayer);
            this.Controls.Add(this.EntryFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CtrToutnament);
            this.Name = "TournamentCreate";
            this.Text = "Tournament Create";
            this.Load += new System.EventHandler(this.TournamentCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CtrToutnament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TournamentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EntryFee;
        private System.Windows.Forms.TextBox SelectPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPlayers;
        private System.Windows.Forms.Button CreatePrizes;
        private System.Windows.Forms.Button CreateTournament;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listOfPlayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listOfPrizes;
        private System.Windows.Forms.Button DeleteSelectedPlayer;
        private System.Windows.Forms.Button DeleteSelectedPrize;
    }
}