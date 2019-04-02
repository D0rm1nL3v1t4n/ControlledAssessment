namespace WelshWanderers
{
    partial class AddMatch
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.InputLeague = new System.Windows.Forms.ComboBox();
            this.LabelLeague = new System.Windows.Forms.Label();
            this.NavHome = new System.Windows.Forms.Button();
            this.EventNavSave = new System.Windows.Forms.Button();
            this.EventAddPlayers = new System.Windows.Forms.Button();
            this.EventClear = new System.Windows.Forms.Button();
            this.EventRemovePlayers = new System.Windows.Forms.Button();
            this.LabelOpponent = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelPostcode = new System.Windows.Forms.Label();
            this.InputOpponent = new System.Windows.Forms.TextBox();
            this.InputTimeH = new System.Windows.Forms.TextBox();
            this.InputTimeM = new System.Windows.Forms.TextBox();
            this.InputAddressA = new System.Windows.Forms.TextBox();
            this.InputAddressB = new System.Windows.Forms.TextBox();
            this.InputPostcode = new System.Windows.Forms.TextBox();
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.InputHomeMatch = new System.Windows.Forms.CheckBox();
            this.ListFindPlayers = new System.Windows.Forms.CheckedListBox();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.InputFilter = new System.Windows.Forms.TextBox();
            this.ListSelectedPlayers = new System.Windows.Forms.CheckedListBox();
            this.LabelPlayersAdded = new System.Windows.Forms.Label();
            this.EventPreviewEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(282, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(140, 33);
            this.LabelHeader.TabIndex = 25;
            this.LabelHeader.Text = "Add Match";
            // 
            // InputLeague
            // 
            this.InputLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputLeague.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLeague.FormattingEnabled = true;
            this.InputLeague.Location = new System.Drawing.Point(97, 67);
            this.InputLeague.Name = "InputLeague";
            this.InputLeague.Size = new System.Drawing.Size(161, 27);
            this.InputLeague.TabIndex = 0;
            this.InputLeague.SelectedIndexChanged += new System.EventHandler(this.InputLeague_SelectedIndexChanged);
            // 
            // LabelLeague
            // 
            this.LabelLeague.AutoSize = true;
            this.LabelLeague.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLeague.Location = new System.Drawing.Point(12, 70);
            this.LabelLeague.Name = "LabelLeague";
            this.LabelLeague.Size = new System.Drawing.Size(55, 18);
            this.LabelLeague.TabIndex = 24;
            this.LabelLeague.Text = "League";
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 12);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 30);
            this.NavHome.TabIndex = 23;
            this.NavHome.Text = "Back";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(612, 12);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(81, 30);
            this.EventNavSave.TabIndex = 16;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            this.EventNavSave.Click += new System.EventHandler(this.EventNavSave_Click);
            // 
            // EventAddPlayers
            // 
            this.EventAddPlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventAddPlayers.Location = new System.Drawing.Point(278, 296);
            this.EventAddPlayers.Name = "EventAddPlayers";
            this.EventAddPlayers.Size = new System.Drawing.Size(200, 30);
            this.EventAddPlayers.TabIndex = 11;
            this.EventAddPlayers.Text = "Add Players";
            this.EventAddPlayers.UseVisualStyleBackColor = true;
            this.EventAddPlayers.Click += new System.EventHandler(this.EventAddPlayers_Click);
            // 
            // EventClear
            // 
            this.EventClear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventClear.Location = new System.Drawing.Point(493, 62);
            this.EventClear.Name = "EventClear";
            this.EventClear.Size = new System.Drawing.Size(97, 30);
            this.EventClear.TabIndex = 12;
            this.EventClear.Text = "Clear";
            this.EventClear.UseVisualStyleBackColor = true;
            this.EventClear.Click += new System.EventHandler(this.EventClear_Click);
            // 
            // EventRemovePlayers
            // 
            this.EventRemovePlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventRemovePlayers.Location = new System.Drawing.Point(493, 296);
            this.EventRemovePlayers.Name = "EventRemovePlayers";
            this.EventRemovePlayers.Size = new System.Drawing.Size(200, 30);
            this.EventRemovePlayers.TabIndex = 14;
            this.EventRemovePlayers.Text = "Remove Players";
            this.EventRemovePlayers.UseVisualStyleBackColor = true;
            this.EventRemovePlayers.Click += new System.EventHandler(this.EventRemovePlayers_Click);
            // 
            // LabelOpponent
            // 
            this.LabelOpponent.AutoSize = true;
            this.LabelOpponent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponent.Location = new System.Drawing.Point(12, 104);
            this.LabelOpponent.Name = "LabelOpponent";
            this.LabelOpponent.Size = new System.Drawing.Size(72, 18);
            this.LabelOpponent.TabIndex = 22;
            this.LabelOpponent.Text = "Opponent";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(12, 138);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(39, 18);
            this.LabelDate.TabIndex = 21;
            this.LabelDate.Text = "Date";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(12, 169);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(41, 18);
            this.LabelTime.TabIndex = 20;
            this.LabelTime.Text = "Time";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(12, 233);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(60, 18);
            this.LabelAddress.TabIndex = 19;
            this.LabelAddress.Text = "Address";
            // 
            // LabelPostcode
            // 
            this.LabelPostcode.AutoSize = true;
            this.LabelPostcode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPostcode.Location = new System.Drawing.Point(12, 299);
            this.LabelPostcode.Name = "LabelPostcode";
            this.LabelPostcode.Size = new System.Drawing.Size(67, 18);
            this.LabelPostcode.TabIndex = 18;
            this.LabelPostcode.Text = "Postcode";
            // 
            // InputOpponent
            // 
            this.InputOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponent.Location = new System.Drawing.Point(97, 100);
            this.InputOpponent.Name = "InputOpponent";
            this.InputOpponent.Size = new System.Drawing.Size(161, 27);
            this.InputOpponent.TabIndex = 1;
            // 
            // InputTimeH
            // 
            this.InputTimeH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeH.Location = new System.Drawing.Point(97, 166);
            this.InputTimeH.Name = "InputTimeH";
            this.InputTimeH.Size = new System.Drawing.Size(77, 27);
            this.InputTimeH.TabIndex = 3;
            // 
            // InputTimeM
            // 
            this.InputTimeM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeM.Location = new System.Drawing.Point(181, 166);
            this.InputTimeM.Name = "InputTimeM";
            this.InputTimeM.Size = new System.Drawing.Size(77, 27);
            this.InputTimeM.TabIndex = 4;
            // 
            // InputAddressA
            // 
            this.InputAddressA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddressA.Location = new System.Drawing.Point(97, 230);
            this.InputAddressA.Name = "InputAddressA";
            this.InputAddressA.Size = new System.Drawing.Size(161, 27);
            this.InputAddressA.TabIndex = 6;
            // 
            // InputAddressB
            // 
            this.InputAddressB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddressB.Location = new System.Drawing.Point(97, 263);
            this.InputAddressB.Name = "InputAddressB";
            this.InputAddressB.Size = new System.Drawing.Size(161, 27);
            this.InputAddressB.TabIndex = 7;
            // 
            // InputPostcode
            // 
            this.InputPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPostcode.Location = new System.Drawing.Point(97, 296);
            this.InputPostcode.Name = "InputPostcode";
            this.InputPostcode.Size = new System.Drawing.Size(161, 27);
            this.InputPostcode.TabIndex = 8;
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(97, 133);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(161, 27);
            this.InputDate.TabIndex = 2;
            this.InputDate.Value = System.DateTime.Today.Date;
            // 
            // InputHomeMatch
            // 
            this.InputHomeMatch.AutoSize = true;
            this.InputHomeMatch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputHomeMatch.Location = new System.Drawing.Point(97, 204);
            this.InputHomeMatch.Name = "InputHomeMatch";
            this.InputHomeMatch.Size = new System.Drawing.Size(111, 22);
            this.InputHomeMatch.TabIndex = 5;
            this.InputHomeMatch.Text = "Home Match";
            this.InputHomeMatch.UseVisualStyleBackColor = true;
            this.InputHomeMatch.CheckedChanged += new System.EventHandler(this.InputHomeMatch_CheckedChanged);
            // 
            // ListFindPlayers
            // 
            this.ListFindPlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFindPlayers.FormattingEnabled = true;
            this.ListFindPlayers.Location = new System.Drawing.Point(278, 97);
            this.ListFindPlayers.Name = "ListFindPlayers";
            this.ListFindPlayers.Size = new System.Drawing.Size(200, 193);
            this.ListFindPlayers.TabIndex = 10;
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilter.Location = new System.Drawing.Point(275, 68);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(38, 18);
            this.LabelFilter.TabIndex = 18;
            this.LabelFilter.Text = "Filter";
            // 
            // InputFilter
            // 
            this.InputFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFilter.Location = new System.Drawing.Point(319, 63);
            this.InputFilter.Name = "InputFilter";
            this.InputFilter.Size = new System.Drawing.Size(159, 27);
            this.InputFilter.TabIndex = 9;
            this.InputFilter.TextChanged += new System.EventHandler(this.InputFilter_TextChanged);
            // 
            // ListSelectedPlayers
            // 
            this.ListSelectedPlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSelectedPlayers.FormattingEnabled = true;
            this.ListSelectedPlayers.Location = new System.Drawing.Point(493, 97);
            this.ListSelectedPlayers.Name = "ListSelectedPlayers";
            this.ListSelectedPlayers.Size = new System.Drawing.Size(200, 193);
            this.ListSelectedPlayers.TabIndex = 13;
            // 
            // LabelPlayersAdded
            // 
            this.LabelPlayersAdded.AutoSize = true;
            this.LabelPlayersAdded.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayersAdded.Location = new System.Drawing.Point(596, 74);
            this.LabelPlayersAdded.Name = "LabelPlayersAdded";
            this.LabelPlayersAdded.Size = new System.Drawing.Size(79, 18);
            this.LabelPlayersAdded.TabIndex = 17;
            this.LabelPlayersAdded.Text = "0 player(s)";
            // 
            // EventPreviewEmail
            // 
            this.EventPreviewEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPreviewEmail.Location = new System.Drawing.Point(493, 12);
            this.EventPreviewEmail.Name = "EventPreviewEmail";
            this.EventPreviewEmail.Size = new System.Drawing.Size(113, 30);
            this.EventPreviewEmail.TabIndex = 15;
            this.EventPreviewEmail.Text = "Preview Email";
            this.EventPreviewEmail.UseVisualStyleBackColor = true;
            this.EventPreviewEmail.Click += new System.EventHandler(this.EventPreviewEmail_Click);
            // 
            // AddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 342);
            this.Controls.Add(this.EventPreviewEmail);
            this.Controls.Add(this.LabelPlayersAdded);
            this.Controls.Add(this.ListSelectedPlayers);
            this.Controls.Add(this.InputFilter);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.ListFindPlayers);
            this.Controls.Add(this.InputHomeMatch);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.InputPostcode);
            this.Controls.Add(this.InputAddressB);
            this.Controls.Add(this.InputAddressA);
            this.Controls.Add(this.InputTimeM);
            this.Controls.Add(this.InputTimeH);
            this.Controls.Add(this.InputOpponent);
            this.Controls.Add(this.LabelPostcode);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelOpponent);
            this.Controls.Add(this.EventRemovePlayers);
            this.Controls.Add(this.EventClear);
            this.Controls.Add(this.EventAddPlayers);
            this.Controls.Add(this.EventNavSave);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.LabelLeague);
            this.Controls.Add(this.InputLeague);
            this.Controls.Add(this.LabelHeader);
            this.Name = "AddMatch";
            this.Text = "AddMatch";
            this.Load += new System.EventHandler(this.AddMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.ComboBox InputLeague;
        private System.Windows.Forms.Label LabelLeague;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button EventNavSave;
        private System.Windows.Forms.Button EventAddPlayers;
        private System.Windows.Forms.Button EventClear;
        private System.Windows.Forms.Button EventRemovePlayers;
        private System.Windows.Forms.Label LabelOpponent;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelPostcode;
        private System.Windows.Forms.TextBox InputOpponent;
        private System.Windows.Forms.TextBox InputTimeH;
        private System.Windows.Forms.TextBox InputTimeM;
        private System.Windows.Forms.TextBox InputAddressA;
        private System.Windows.Forms.TextBox InputAddressB;
        private System.Windows.Forms.TextBox InputPostcode;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.CheckBox InputHomeMatch;
        private System.Windows.Forms.CheckedListBox ListFindPlayers;
        private System.Windows.Forms.Label LabelFilter;
        private System.Windows.Forms.TextBox InputFilter;
        private System.Windows.Forms.CheckedListBox ListSelectedPlayers;
        private System.Windows.Forms.Label LabelPlayersAdded;
        private System.Windows.Forms.Button EventPreviewEmail;
    }
}