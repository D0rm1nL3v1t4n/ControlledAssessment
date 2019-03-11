namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    partial class AddMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMatchForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddMatch = new System.Windows.Forms.Label();
            this.grpbxAddMatch = new System.Windows.Forms.GroupBox();
            this.chkbxHomeMatch = new System.Windows.Forms.CheckBox();
            this.LblPostcode = new System.Windows.Forms.Label();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.TxtAddressLine2 = new System.Windows.Forms.TextBox();
            this.TxtAddressLine1 = new System.Windows.Forms.TextBox();
            this.LblAddressLine1 = new System.Windows.Forms.Label();
            this.lblMatchDateTime = new System.Windows.Forms.Label();
            this.MatchDateTime = new System.Windows.Forms.DateTimePicker();
            this.CmbTeamType = new System.Windows.Forms.ComboBox();
            this.lblTeamType = new System.Windows.Forms.Label();
            this.CmbMatchType = new System.Windows.Forms.ComboBox();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblMatchType = new System.Windows.Forms.Label();
            this.TxtOpponent = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.grpbxTeamSelection = new System.Windows.Forms.GroupBox();
            this.LblPlayersAdded = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.lblSearchPlayers = new System.Windows.Forms.Label();
            this.BtnRemovePlayers = new System.Windows.Forms.Button();
            this.BtnAddPlayers = new System.Windows.Forms.Button();
            this.LblPlayersSelected = new System.Windows.Forms.Label();
            this.listPlayersSelected = new System.Windows.Forms.CheckedListBox();
            this.LblFilter = new System.Windows.Forms.Label();
            this.TxtSearchFilter = new System.Windows.Forms.TextBox();
            this.listSearchPlayers = new System.Windows.Forms.CheckedListBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxAddMatch.SuspendLayout();
            this.grpbxTeamSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddMatch
            // 
            this.lblAddMatch.AutoSize = true;
            this.lblAddMatch.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMatch.Location = new System.Drawing.Point(151, 183);
            this.lblAddMatch.Name = "lblAddMatch";
            this.lblAddMatch.Size = new System.Drawing.Size(182, 42);
            this.lblAddMatch.TabIndex = 5;
            this.lblAddMatch.Text = "Add Match";
            // 
            // grpbxAddMatch
            // 
            this.grpbxAddMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxAddMatch.Controls.Add(this.chkbxHomeMatch);
            this.grpbxAddMatch.Controls.Add(this.LblPostcode);
            this.grpbxAddMatch.Controls.Add(this.TxtPostcode);
            this.grpbxAddMatch.Controls.Add(this.TxtAddressLine2);
            this.grpbxAddMatch.Controls.Add(this.TxtAddressLine1);
            this.grpbxAddMatch.Controls.Add(this.LblAddressLine1);
            this.grpbxAddMatch.Controls.Add(this.lblMatchDateTime);
            this.grpbxAddMatch.Controls.Add(this.MatchDateTime);
            this.grpbxAddMatch.Controls.Add(this.CmbTeamType);
            this.grpbxAddMatch.Controls.Add(this.lblTeamType);
            this.grpbxAddMatch.Controls.Add(this.CmbMatchType);
            this.grpbxAddMatch.Controls.Add(this.lblOpponent);
            this.grpbxAddMatch.Controls.Add(this.lblMatchType);
            this.grpbxAddMatch.Controls.Add(this.TxtOpponent);
            this.grpbxAddMatch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddMatch.Location = new System.Drawing.Point(37, 235);
            this.grpbxAddMatch.Name = "grpbxAddMatch";
            this.grpbxAddMatch.Size = new System.Drawing.Size(410, 247);
            this.grpbxAddMatch.TabIndex = 12;
            this.grpbxAddMatch.TabStop = false;
            this.grpbxAddMatch.Text = "Details";
            // 
            // chkbxHomeMatch
            // 
            this.chkbxHomeMatch.AutoSize = true;
            this.chkbxHomeMatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxHomeMatch.Location = new System.Drawing.Point(28, 177);
            this.chkbxHomeMatch.Name = "chkbxHomeMatch";
            this.chkbxHomeMatch.Size = new System.Drawing.Size(108, 23);
            this.chkbxHomeMatch.TabIndex = 18;
            this.chkbxHomeMatch.Text = "Home Match";
            this.chkbxHomeMatch.UseVisualStyleBackColor = true;
            this.chkbxHomeMatch.CheckedChanged += new System.EventHandler(this.chkbxHomeMatch_CheckedChanged);
            // 
            // LblPostcode
            // 
            this.LblPostcode.AutoSize = true;
            this.LblPostcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPostcode.Location = new System.Drawing.Point(24, 219);
            this.LblPostcode.Name = "LblPostcode";
            this.LblPostcode.Size = new System.Drawing.Size(66, 19);
            this.LblPostcode.TabIndex = 17;
            this.LblPostcode.Text = "Postcode";
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPostcode.Location = new System.Drawing.Point(155, 212);
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(201, 26);
            this.TxtPostcode.TabIndex = 16;
            // 
            // TxtAddressLine2
            // 
            this.TxtAddressLine2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddressLine2.Location = new System.Drawing.Point(155, 180);
            this.TxtAddressLine2.Name = "TxtAddressLine2";
            this.TxtAddressLine2.Size = new System.Drawing.Size(201, 26);
            this.TxtAddressLine2.TabIndex = 15;
            // 
            // TxtAddressLine1
            // 
            this.TxtAddressLine1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddressLine1.Location = new System.Drawing.Point(155, 148);
            this.TxtAddressLine1.Name = "TxtAddressLine1";
            this.TxtAddressLine1.Size = new System.Drawing.Size(201, 26);
            this.TxtAddressLine1.TabIndex = 14;
            // 
            // LblAddressLine1
            // 
            this.LblAddressLine1.AutoSize = true;
            this.LblAddressLine1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressLine1.Location = new System.Drawing.Point(24, 155);
            this.LblAddressLine1.Name = "LblAddressLine1";
            this.LblAddressLine1.Size = new System.Drawing.Size(60, 19);
            this.LblAddressLine1.TabIndex = 13;
            this.LblAddressLine1.Text = "Address";
            // 
            // lblMatchDateTime
            // 
            this.lblMatchDateTime.AutoSize = true;
            this.lblMatchDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchDateTime.Location = new System.Drawing.Point(24, 123);
            this.lblMatchDateTime.Name = "lblMatchDateTime";
            this.lblMatchDateTime.Size = new System.Drawing.Size(97, 19);
            this.lblMatchDateTime.TabIndex = 12;
            this.lblMatchDateTime.Text = "Time and Date";
            // 
            // MatchDateTime
            // 
            this.MatchDateTime.CustomFormat = "dd/MM/yyyy hh:mm";
            this.MatchDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchDateTime.Location = new System.Drawing.Point(155, 116);
            this.MatchDateTime.Name = "MatchDateTime";
            this.MatchDateTime.Size = new System.Drawing.Size(201, 26);
            this.MatchDateTime.TabIndex = 11;
            this.MatchDateTime.Value = new System.DateTime(2018, 10, 19, 10, 10, 10, 0);
            // 
            // CmbTeamType
            // 
            this.CmbTeamType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTeamType.FormattingEnabled = true;
            this.CmbTeamType.Items.AddRange(new object[] {
            "Juniors",
            "Mens",
            "Womens"});
            this.CmbTeamType.Location = new System.Drawing.Point(155, 85);
            this.CmbTeamType.Name = "CmbTeamType";
            this.CmbTeamType.Size = new System.Drawing.Size(134, 25);
            this.CmbTeamType.TabIndex = 10;
            this.CmbTeamType.SelectedIndexChanged += new System.EventHandler(this.CmbTeamType_SelectedIndexChanged);
            // 
            // lblTeamType
            // 
            this.lblTeamType.AutoSize = true;
            this.lblTeamType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamType.Location = new System.Drawing.Point(24, 91);
            this.lblTeamType.Name = "lblTeamType";
            this.lblTeamType.Size = new System.Drawing.Size(76, 19);
            this.lblTeamType.TabIndex = 9;
            this.lblTeamType.Text = "Team Type";
            // 
            // CmbMatchType
            // 
            this.CmbMatchType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMatchType.FormattingEnabled = true;
            this.CmbMatchType.Items.AddRange(new object[] {
            "Friendly",
            "League",
            "Tournament",
            "Training",
            "Other"});
            this.CmbMatchType.Location = new System.Drawing.Point(155, 22);
            this.CmbMatchType.Name = "CmbMatchType";
            this.CmbMatchType.Size = new System.Drawing.Size(135, 25);
            this.CmbMatchType.TabIndex = 8;
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(24, 60);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(70, 19);
            this.lblOpponent.TabIndex = 6;
            this.lblOpponent.Text = "Opponent";
            // 
            // lblMatchType
            // 
            this.lblMatchType.AutoSize = true;
            this.lblMatchType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchType.Location = new System.Drawing.Point(24, 28);
            this.lblMatchType.Name = "lblMatchType";
            this.lblMatchType.Size = new System.Drawing.Size(82, 19);
            this.lblMatchType.TabIndex = 5;
            this.lblMatchType.Text = "Match Type";
            // 
            // TxtOpponent
            // 
            this.TxtOpponent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOpponent.Location = new System.Drawing.Point(155, 53);
            this.TxtOpponent.Name = "TxtOpponent";
            this.TxtOpponent.Size = new System.Drawing.Size(201, 26);
            this.TxtOpponent.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(349, 806);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 36);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // grpbxTeamSelection
            // 
            this.grpbxTeamSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxTeamSelection.Controls.Add(this.LblPlayersAdded);
            this.grpbxTeamSelection.Controls.Add(this.BtnClear);
            this.grpbxTeamSelection.Controls.Add(this.lblSearchPlayers);
            this.grpbxTeamSelection.Controls.Add(this.BtnRemovePlayers);
            this.grpbxTeamSelection.Controls.Add(this.BtnAddPlayers);
            this.grpbxTeamSelection.Controls.Add(this.LblPlayersSelected);
            this.grpbxTeamSelection.Controls.Add(this.listPlayersSelected);
            this.grpbxTeamSelection.Controls.Add(this.LblFilter);
            this.grpbxTeamSelection.Controls.Add(this.TxtSearchFilter);
            this.grpbxTeamSelection.Controls.Add(this.listSearchPlayers);
            this.grpbxTeamSelection.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxTeamSelection.Location = new System.Drawing.Point(37, 488);
            this.grpbxTeamSelection.Name = "grpbxTeamSelection";
            this.grpbxTeamSelection.Size = new System.Drawing.Size(410, 312);
            this.grpbxTeamSelection.TabIndex = 13;
            this.grpbxTeamSelection.TabStop = false;
            this.grpbxTeamSelection.Text = "Team Selection";
            // 
            // LblPlayersAdded
            // 
            this.LblPlayersAdded.AutoSize = true;
            this.LblPlayersAdded.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayersAdded.Location = new System.Drawing.Point(268, 274);
            this.LblPlayersAdded.Name = "LblPlayersAdded";
            this.LblPlayersAdded.Size = new System.Drawing.Size(125, 19);
            this.LblPlayersAdded.TabIndex = 24;
            this.LblPlayersAdded.Text = "No Players Added";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(220, 235);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(51, 36);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblSearchPlayers
            // 
            this.lblSearchPlayers.AutoSize = true;
            this.lblSearchPlayers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPlayers.Location = new System.Drawing.Point(8, 36);
            this.lblSearchPlayers.Name = "lblSearchPlayers";
            this.lblSearchPlayers.Size = new System.Drawing.Size(124, 21);
            this.lblSearchPlayers.TabIndex = 22;
            this.lblSearchPlayers.Text = "Search Players:";
            // 
            // BtnRemovePlayers
            // 
            this.BtnRemovePlayers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemovePlayers.Location = new System.Drawing.Point(277, 235);
            this.BtnRemovePlayers.Name = "BtnRemovePlayers";
            this.BtnRemovePlayers.Size = new System.Drawing.Size(116, 36);
            this.BtnRemovePlayers.TabIndex = 21;
            this.BtnRemovePlayers.Text = "Remove Players";
            this.BtnRemovePlayers.UseVisualStyleBackColor = true;
            this.BtnRemovePlayers.Click += new System.EventHandler(this.BtnRemovePlayers_Click);
            // 
            // BtnAddPlayers
            // 
            this.BtnAddPlayers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPlayers.Location = new System.Drawing.Point(12, 266);
            this.BtnAddPlayers.Name = "BtnAddPlayers";
            this.BtnAddPlayers.Size = new System.Drawing.Size(98, 36);
            this.BtnAddPlayers.TabIndex = 14;
            this.BtnAddPlayers.Text = "Add Players";
            this.BtnAddPlayers.UseVisualStyleBackColor = true;
            this.BtnAddPlayers.Click += new System.EventHandler(this.BtnAddPlayers_Click);
            // 
            // LblPlayersSelected
            // 
            this.LblPlayersSelected.AutoSize = true;
            this.LblPlayersSelected.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayersSelected.Location = new System.Drawing.Point(220, 36);
            this.LblPlayersSelected.Name = "LblPlayersSelected";
            this.LblPlayersSelected.Size = new System.Drawing.Size(136, 21);
            this.LblPlayersSelected.TabIndex = 20;
            this.LblPlayersSelected.Text = "Players Selected:";
            // 
            // listPlayersSelected
            // 
            this.listPlayersSelected.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlayersSelected.FormattingEnabled = true;
            this.listPlayersSelected.Location = new System.Drawing.Point(220, 65);
            this.listPlayersSelected.Name = "listPlayersSelected";
            this.listPlayersSelected.Size = new System.Drawing.Size(173, 164);
            this.listPlayersSelected.TabIndex = 19;
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter.Location = new System.Drawing.Point(8, 67);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(40, 19);
            this.LblFilter.TabIndex = 18;
            this.LblFilter.Text = "Filter";
            // 
            // TxtSearchFilter
            // 
            this.TxtSearchFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchFilter.Location = new System.Drawing.Point(54, 64);
            this.TxtSearchFilter.Name = "TxtSearchFilter";
            this.TxtSearchFilter.Size = new System.Drawing.Size(145, 26);
            this.TxtSearchFilter.TabIndex = 18;
            this.TxtSearchFilter.TextChanged += new System.EventHandler(this.TxtSearchFilter_TextChanged);
            // 
            // listSearchPlayers
            // 
            this.listSearchPlayers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSearchPlayers.FormattingEnabled = true;
            this.listSearchPlayers.Location = new System.Drawing.Point(12, 96);
            this.listSearchPlayers.Name = "listSearchPlayers";
            this.listSearchPlayers.Size = new System.Drawing.Size(187, 164);
            this.listSearchPlayers.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(37, 806);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(98, 36);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 852);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.grpbxTeamSelection);
            this.Controls.Add(this.grpbxAddMatch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lblAddMatch);
            this.Name = "AddMatchForm";
            this.Text = "Add Match";
            this.Load += new System.EventHandler(this.AddMatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxAddMatch.ResumeLayout(false);
            this.grpbxAddMatch.PerformLayout();
            this.grpbxTeamSelection.ResumeLayout(false);
            this.grpbxTeamSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddMatch;
        private System.Windows.Forms.GroupBox grpbxAddMatch;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label lblMatchType;
        private System.Windows.Forms.TextBox TxtOpponent;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CmbMatchType;
        private System.Windows.Forms.ComboBox CmbTeamType;
        private System.Windows.Forms.Label lblTeamType;
        private System.Windows.Forms.Label lblMatchDateTime;
        private System.Windows.Forms.DateTimePicker MatchDateTime;
        private System.Windows.Forms.Label LblPostcode;
        private System.Windows.Forms.TextBox TxtPostcode;
        private System.Windows.Forms.TextBox TxtAddressLine1;
        private System.Windows.Forms.Label LblAddressLine1;
        private System.Windows.Forms.GroupBox grpbxTeamSelection;
        private System.Windows.Forms.Button BtnRemovePlayers;
        private System.Windows.Forms.Button BtnAddPlayers;
        private System.Windows.Forms.Label LblPlayersSelected;
        private System.Windows.Forms.CheckedListBox listPlayersSelected;
        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.TextBox TxtSearchFilter;
        private System.Windows.Forms.CheckedListBox listSearchPlayers;
        private System.Windows.Forms.Label lblSearchPlayers;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblPlayersAdded;
        private System.Windows.Forms.TextBox TxtAddressLine2;
        private System.Windows.Forms.CheckBox chkbxHomeMatch;
        private System.Windows.Forms.Button BtnCancel;
    }
}