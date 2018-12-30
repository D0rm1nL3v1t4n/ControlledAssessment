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
            this.NavSignIn = new System.Windows.Forms.Button();
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
            this.LabelHeader.Location = new System.Drawing.Point(283, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(140, 33);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Add Match";
            // 
            // InputLeague
            // 
            this.InputLeague.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLeague.FormattingEnabled = true;
            this.InputLeague.Location = new System.Drawing.Point(151, 75);
            this.InputLeague.Name = "InputLeague";
            this.InputLeague.Size = new System.Drawing.Size(161, 27);
            this.InputLeague.TabIndex = 7;
            this.InputLeague.SelectedIndexChanged += new System.EventHandler(this.InputLeague_SelectedIndexChanged);
            // 
            // LabelLeague
            // 
            this.LabelLeague.AutoSize = true;
            this.LabelLeague.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLeague.Location = new System.Drawing.Point(86, 78);
            this.LabelLeague.Name = "LabelLeague";
            this.LabelLeague.Size = new System.Drawing.Size(59, 19);
            this.LabelLeague.TabIndex = 9;
            this.LabelLeague.Text = "League";
            // 
            // NavSignIn
            // 
            this.NavSignIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavSignIn.Location = new System.Drawing.Point(84, 490);
            this.NavSignIn.Name = "NavSignIn";
            this.NavSignIn.Size = new System.Drawing.Size(89, 48);
            this.NavSignIn.TabIndex = 28;
            this.NavSignIn.Text = "Cancel";
            this.NavSignIn.UseVisualStyleBackColor = true;
            this.NavSignIn.Click += new System.EventHandler(this.NavSignIn_Click);
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(538, 490);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(89, 48);
            this.EventNavSave.TabIndex = 29;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            this.EventNavSave.Click += new System.EventHandler(this.EventNavSave_Click);
            // 
            // EventAddPlayers
            // 
            this.EventAddPlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventAddPlayers.Location = new System.Drawing.Point(256, 259);
            this.EventAddPlayers.Name = "EventAddPlayers";
            this.EventAddPlayers.Size = new System.Drawing.Size(89, 47);
            this.EventAddPlayers.TabIndex = 30;
            this.EventAddPlayers.Text = "Add Players";
            this.EventAddPlayers.UseVisualStyleBackColor = true;
            this.EventAddPlayers.Click += new System.EventHandler(this.EventAddPlayers_Click);
            // 
            // EventClear
            // 
            this.EventClear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventClear.Location = new System.Drawing.Point(461, 259);
            this.EventClear.Name = "EventClear";
            this.EventClear.Size = new System.Drawing.Size(71, 47);
            this.EventClear.TabIndex = 31;
            this.EventClear.Text = "Clear";
            this.EventClear.UseVisualStyleBackColor = true;
            this.EventClear.Click += new System.EventHandler(this.EventClear_Click);
            // 
            // EventRemovePlayers
            // 
            this.EventRemovePlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventRemovePlayers.Location = new System.Drawing.Point(366, 259);
            this.EventRemovePlayers.Name = "EventRemovePlayers";
            this.EventRemovePlayers.Size = new System.Drawing.Size(89, 47);
            this.EventRemovePlayers.TabIndex = 32;
            this.EventRemovePlayers.Text = "Remove Players";
            this.EventRemovePlayers.UseVisualStyleBackColor = true;
            this.EventRemovePlayers.Click += new System.EventHandler(this.EventRemovePlayers_Click);
            // 
            // LabelOpponent
            // 
            this.LabelOpponent.AutoSize = true;
            this.LabelOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponent.Location = new System.Drawing.Point(66, 111);
            this.LabelOpponent.Name = "LabelOpponent";
            this.LabelOpponent.Size = new System.Drawing.Size(79, 19);
            this.LabelOpponent.TabIndex = 33;
            this.LabelOpponent.Text = "Opponent";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(104, 144);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(41, 19);
            this.LabelDate.TabIndex = 34;
            this.LabelDate.Text = "Date";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(100, 177);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(45, 19);
            this.LabelTime.TabIndex = 35;
            this.LabelTime.Text = "Time";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(407, 111);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(66, 19);
            this.LabelAddress.TabIndex = 36;
            this.LabelAddress.Text = "Address";
            // 
            // LabelPostcode
            // 
            this.LabelPostcode.AutoSize = true;
            this.LabelPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPostcode.Location = new System.Drawing.Point(401, 177);
            this.LabelPostcode.Name = "LabelPostcode";
            this.LabelPostcode.Size = new System.Drawing.Size(72, 19);
            this.LabelPostcode.TabIndex = 37;
            this.LabelPostcode.Text = "Postcode";
            // 
            // InputOpponent
            // 
            this.InputOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponent.Location = new System.Drawing.Point(151, 108);
            this.InputOpponent.Name = "InputOpponent";
            this.InputOpponent.Size = new System.Drawing.Size(161, 27);
            this.InputOpponent.TabIndex = 38;
            // 
            // InputTimeH
            // 
            this.InputTimeH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeH.Location = new System.Drawing.Point(151, 174);
            this.InputTimeH.Name = "InputTimeH";
            this.InputTimeH.Size = new System.Drawing.Size(59, 27);
            this.InputTimeH.TabIndex = 39;
            // 
            // InputTimeM
            // 
            this.InputTimeM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeM.Location = new System.Drawing.Point(216, 174);
            this.InputTimeM.Name = "InputTimeM";
            this.InputTimeM.Size = new System.Drawing.Size(59, 27);
            this.InputTimeM.TabIndex = 40;
            // 
            // InputAddressA
            // 
            this.InputAddressA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddressA.Location = new System.Drawing.Point(479, 108);
            this.InputAddressA.Name = "InputAddressA";
            this.InputAddressA.Size = new System.Drawing.Size(161, 27);
            this.InputAddressA.TabIndex = 41;
            // 
            // InputAddressB
            // 
            this.InputAddressB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddressB.Location = new System.Drawing.Point(479, 141);
            this.InputAddressB.Name = "InputAddressB";
            this.InputAddressB.Size = new System.Drawing.Size(161, 27);
            this.InputAddressB.TabIndex = 42;
            // 
            // InputPostcode
            // 
            this.InputPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPostcode.Location = new System.Drawing.Point(479, 174);
            this.InputPostcode.Name = "InputPostcode";
            this.InputPostcode.Size = new System.Drawing.Size(161, 27);
            this.InputPostcode.TabIndex = 43;
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(151, 141);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(161, 27);
            this.InputDate.TabIndex = 44;
            this.InputDate.Value = new System.DateTime(2018, 11, 4, 0, 0, 0, 0);
            // 
            // InputHomeMatch
            // 
            this.InputHomeMatch.AutoSize = true;
            this.InputHomeMatch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputHomeMatch.Location = new System.Drawing.Point(375, 133);
            this.InputHomeMatch.Name = "InputHomeMatch";
            this.InputHomeMatch.Size = new System.Drawing.Size(98, 20);
            this.InputHomeMatch.TabIndex = 45;
            this.InputHomeMatch.Text = "Home Match";
            this.InputHomeMatch.UseVisualStyleBackColor = true;
            this.InputHomeMatch.CheckedChanged += new System.EventHandler(this.InputHomeMatch_CheckedChanged);
            // 
            // ListFindPlayers
            // 
            this.ListFindPlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFindPlayers.FormattingEnabled = true;
            this.ListFindPlayers.Location = new System.Drawing.Point(84, 312);
            this.ListFindPlayers.Name = "ListFindPlayers";
            this.ListFindPlayers.Size = new System.Drawing.Size(261, 172);
            this.ListFindPlayers.TabIndex = 46;
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilter.Location = new System.Drawing.Point(85, 262);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(44, 19);
            this.LabelFilter.TabIndex = 47;
            this.LabelFilter.Text = "Filter";
            // 
            // InputFilter
            // 
            this.InputFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFilter.Location = new System.Drawing.Point(135, 259);
            this.InputFilter.Name = "InputFilter";
            this.InputFilter.Size = new System.Drawing.Size(115, 27);
            this.InputFilter.TabIndex = 48;
            this.InputFilter.TextChanged += new System.EventHandler(this.InputFilter_TextChanged);
            // 
            // ListSelectedPlayers
            // 
            this.ListSelectedPlayers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSelectedPlayers.FormattingEnabled = true;
            this.ListSelectedPlayers.Location = new System.Drawing.Point(366, 312);
            this.ListSelectedPlayers.Name = "ListSelectedPlayers";
            this.ListSelectedPlayers.Size = new System.Drawing.Size(261, 172);
            this.ListSelectedPlayers.TabIndex = 51;
            // 
            // LabelPlayersAdded
            // 
            this.LabelPlayersAdded.AutoSize = true;
            this.LabelPlayersAdded.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayersAdded.Location = new System.Drawing.Point(538, 259);
            this.LabelPlayersAdded.Name = "LabelPlayersAdded";
            this.LabelPlayersAdded.Size = new System.Drawing.Size(84, 38);
            this.LabelPlayersAdded.TabIndex = 52;
            this.LabelPlayersAdded.Text = "No players\r\nadded";
            // 
            // EventPreviewEmail
            // 
            this.EventPreviewEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPreviewEmail.Location = new System.Drawing.Point(443, 492);
            this.EventPreviewEmail.Name = "EventPreviewEmail";
            this.EventPreviewEmail.Size = new System.Drawing.Size(89, 48);
            this.EventPreviewEmail.TabIndex = 53;
            this.EventPreviewEmail.Text = "Preview Email";
            this.EventPreviewEmail.UseVisualStyleBackColor = true;
            this.EventPreviewEmail.Click += new System.EventHandler(this.EventPreviewEmail_Click);
            // 
            // AddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 552);
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
            this.Controls.Add(this.NavSignIn);
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
        private System.Windows.Forms.Button NavSignIn;
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