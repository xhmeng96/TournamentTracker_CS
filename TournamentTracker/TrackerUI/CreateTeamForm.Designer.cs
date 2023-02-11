namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellPhoneNumberValue = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.EmailAddressValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.RemoveSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(91, 175);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(839, 65);
            this.TeamNameValue.TabIndex = 14;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(79, 127);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(312, 72);
            this.TeamNameLabel.TabIndex = 13;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(52, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(450, 100);
            this.HeaderLabel.TabIndex = 12;
            this.HeaderLabel.Text = "Create Team";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.Tomato;
            this.AddMemberButton.Location = new System.Drawing.Point(557, 326);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(373, 74);
            this.AddMemberButton.TabIndex = 20;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(91, 262);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(839, 67);
            this.SelectTeamMemberDropDown.TabIndex = 19;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(79, 218);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(528, 72);
            this.SelectTeamMemberLabel.TabIndex = 18;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateMemberButton);
            this.groupBox1.Controls.Add(this.CellPhoneNumberValue);
            this.groupBox1.Controls.Add(this.CellphoneLabel);
            this.groupBox1.Controls.Add(this.EmailAddressValue);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.LastNameValue);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameValue);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 495);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.Tomato;
            this.CreateMemberButton.Location = new System.Drawing.Point(126, 394);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(501, 90);
            this.CreateMemberButton.TabIndex = 22;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // CellPhoneNumberValue
            // 
            this.CellPhoneNumberValue.Location = new System.Drawing.Point(348, 312);
            this.CellPhoneNumberValue.Name = "CellPhoneNumberValue";
            this.CellPhoneNumberValue.Size = new System.Drawing.Size(440, 78);
            this.CellPhoneNumberValue.TabIndex = 29;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.CellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CellphoneLabel.Location = new System.Drawing.Point(31, 305);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(271, 72);
            this.CellphoneLabel.TabIndex = 28;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Location = new System.Drawing.Point(348, 232);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.Size = new System.Drawing.Size(440, 78);
            this.EmailAddressValue.TabIndex = 27;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(31, 225);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(157, 72);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(348, 152);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(440, 78);
            this.LastNameValue.TabIndex = 25;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(31, 145);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(280, 72);
            this.LastNameLabel.TabIndex = 24;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(348, 72);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(440, 78);
            this.FirstNameValue.TabIndex = 23;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(24, 65);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(286, 72);
            this.FirstNameLabel.TabIndex = 22;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(205, 699);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(163, 72);
            this.TeamOneScoreLabel.TabIndex = 14;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 59;
            this.TeamMembersListBox.Location = new System.Drawing.Point(936, 43);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(544, 710);
            this.TeamMembersListBox.TabIndex = 22;
            // 
            // RemoveSelectedMemberButton
            // 
            this.RemoveSelectedMemberButton.BackColor = System.Drawing.Color.Tomato;
            this.RemoveSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedMemberButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveSelectedMemberButton.Location = new System.Drawing.Point(1074, 761);
            this.RemoveSelectedMemberButton.Name = "RemoveSelectedMemberButton";
            this.RemoveSelectedMemberButton.Size = new System.Drawing.Size(406, 72);
            this.RemoveSelectedMemberButton.TabIndex = 23;
            this.RemoveSelectedMemberButton.Text = "Remove Selected";
            this.RemoveSelectedMemberButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedMemberButton.Click += new System.EventHandler(this.RemoveSelectedMemberButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.Black;
            this.CreateTeamButton.Location = new System.Drawing.Point(91, 907);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(1389, 114);
            this.CreateTeamButton.TabIndex = 26;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = false;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1566, 1033);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.RemoveSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox CellPhoneNumberValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailAddressValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button RemoveSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}