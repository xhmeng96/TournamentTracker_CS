namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.TounamentPlayersLabel = new System.Windows.Forms.Label();
            this.RemoveSelectedTeamButton = new System.Windows.Forms.Button();
            this.RemoveSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PirzesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(44, 59);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(645, 100);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tounament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(83, 235);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(586, 65);
            this.TournamentNameValue.TabIndex = 11;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(71, 160);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(474, 72);
            this.TournamentNameLabel.TabIndex = 10;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(71, 303);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(248, 72);
            this.EntryFeeLabel.TabIndex = 12;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(335, 310);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(210, 65);
            this.EntryFeeValue.TabIndex = 13;
            this.EntryFeeValue.Text = "0";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(83, 453);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(586, 67);
            this.SelectTeamDropDown.TabIndex = 15;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(71, 378);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(311, 72);
            this.SelectTeamLabel.TabIndex = 14;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateTeamLinkLabel
            // 
            this.CreateTeamLinkLabel.AutoSize = true;
            this.CreateTeamLinkLabel.Location = new System.Drawing.Point(443, 389);
            this.CreateTeamLinkLabel.Name = "CreateTeamLinkLabel";
            this.CreateTeamLinkLabel.Size = new System.Drawing.Size(245, 59);
            this.CreateTeamLinkLabel.TabIndex = 16;
            this.CreateTeamLinkLabel.TabStop = true;
            this.CreateTeamLinkLabel.Text = "Create New";
            this.CreateTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTeamLinkLabel_LinkClicked);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.Tomato;
            this.AddTeamButton.Location = new System.Drawing.Point(296, 569);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(373, 74);
            this.AddTeamButton.TabIndex = 17;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.Tomato;
            this.CreatePrizeButton.Location = new System.Drawing.Point(296, 681);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(373, 74);
            this.CreatePrizeButton.TabIndex = 18;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // TournamentTeamsListBox
            // 
            this.TournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentTeamsListBox.FormattingEnabled = true;
            this.TournamentTeamsListBox.ItemHeight = 59;
            this.TournamentTeamsListBox.Location = new System.Drawing.Point(711, 223);
            this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            this.TournamentTeamsListBox.Size = new System.Drawing.Size(557, 238);
            this.TournamentTeamsListBox.TabIndex = 19;
            // 
            // TounamentPlayersLabel
            // 
            this.TounamentPlayersLabel.AutoSize = true;
            this.TounamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.TounamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TounamentPlayersLabel.Location = new System.Drawing.Point(699, 148);
            this.TounamentPlayersLabel.Name = "TounamentPlayersLabel";
            this.TounamentPlayersLabel.Size = new System.Drawing.Size(178, 72);
            this.TounamentPlayersLabel.TabIndex = 20;
            this.TounamentPlayersLabel.Text = "Teams";
            // 
            // RemoveSelectedTeamButton
            // 
            this.RemoveSelectedTeamButton.BackColor = System.Drawing.Color.Tomato;
            this.RemoveSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedTeamButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveSelectedTeamButton.Location = new System.Drawing.Point(1274, 243);
            this.RemoveSelectedTeamButton.Name = "RemoveSelectedTeamButton";
            this.RemoveSelectedTeamButton.Size = new System.Drawing.Size(200, 200);
            this.RemoveSelectedTeamButton.TabIndex = 21;
            this.RemoveSelectedTeamButton.Text = "Remove Selected";
            this.RemoveSelectedTeamButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedTeamButton.Click += new System.EventHandler(this.RemoveSelectedTeamButton_Click);
            // 
            // RemoveSelectedPrizeButton
            // 
            this.RemoveSelectedPrizeButton.BackColor = System.Drawing.Color.Tomato;
            this.RemoveSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedPrizeButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveSelectedPrizeButton.Location = new System.Drawing.Point(1274, 555);
            this.RemoveSelectedPrizeButton.Name = "RemoveSelectedPrizeButton";
            this.RemoveSelectedPrizeButton.Size = new System.Drawing.Size(200, 200);
            this.RemoveSelectedPrizeButton.TabIndex = 24;
            this.RemoveSelectedPrizeButton.Text = "Remove Selected";
            this.RemoveSelectedPrizeButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedPrizeButton.Click += new System.EventHandler(this.RemoveSelectedPrizeButton_Click);
            // 
            // PirzesLabel
            // 
            this.PirzesLabel.AutoSize = true;
            this.PirzesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.PirzesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PirzesLabel.Location = new System.Drawing.Point(699, 465);
            this.PirzesLabel.Name = "PirzesLabel";
            this.PirzesLabel.Size = new System.Drawing.Size(167, 72);
            this.PirzesLabel.TabIndex = 23;
            this.PirzesLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 59;
            this.PrizesListBox.Location = new System.Drawing.Point(711, 540);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(557, 238);
            this.PrizesListBox.TabIndex = 22;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.Black;
            this.CreateTournamentButton.Location = new System.Drawing.Point(83, 784);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(1391, 144);
            this.CreateTournamentButton.TabIndex = 25;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1538, 961);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.RemoveSelectedPrizeButton);
            this.Controls.Add(this.PirzesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.RemoveSelectedTeamButton);
            this.Controls.Add(this.TounamentPlayersLabel);
            this.Controls.Add(this.TournamentTeamsListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateTeamLinkLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Creat Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateTeamLinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TournamentTeamsListBox;
        private System.Windows.Forms.Label TounamentPlayersLabel;
        private System.Windows.Forms.Button RemoveSelectedTeamButton;
        private System.Windows.Forms.Button RemoveSelectedPrizeButton;
        private System.Windows.Forms.Label PirzesLabel;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}