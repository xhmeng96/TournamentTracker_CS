namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(41, 41);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(427, 100);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tounament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.Black;
            this.TournamentName.Location = new System.Drawing.Point(448, 41);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(320, 100);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(48, 166);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(186, 72);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(240, 173);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(492, 65);
            this.RoundDropDown.TabIndex = 3;
            this.RoundDropDown.SelectedIndexChanged += new System.EventHandler(this.RoundDropDown_SelectedIndexChanged);
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(240, 258);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(400, 76);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "Unplayed only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.UnplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.UnplayedOnlyCheckBox_CheckedChanged);
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 57;
            this.MatchupListBox.Location = new System.Drawing.Point(58, 409);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(674, 572);
            this.MatchupListBox.TabIndex = 5;
            this.MatchupListBox.SelectedIndexChanged += new System.EventHandler(this.MatchupListBox_SelectedIndexChanged);
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.Blue;
            this.TeamOneName.Location = new System.Drawing.Point(828, 285);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(406, 86);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(828, 396);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(194, 86);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(1028, 408);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(209, 63);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(1028, 759);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(209, 63);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(828, 747);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(194, 86);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TeamTwoName.Location = new System.Drawing.Point(828, 644);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(410, 86);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<team two>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.Black;
            this.VersusLabel.Location = new System.Drawing.Point(935, 515);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(192, 100);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.BackColor = System.Drawing.Color.Tomato;
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.Black;
            this.ScoreButton.Location = new System.Drawing.Point(1300, 485);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(306, 161);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = false;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1636, 1035);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "TounamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

