namespace WelshWanderers
{
    partial class ViewMatch
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
            this.InputHomeMatch = new System.Windows.Forms.CheckBox();
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.InputPostcode = new System.Windows.Forms.TextBox();
            this.InputAddressB = new System.Windows.Forms.TextBox();
            this.InputAddressA = new System.Windows.Forms.TextBox();
            this.InputTimeM = new System.Windows.Forms.TextBox();
            this.InputTimeH = new System.Windows.Forms.TextBox();
            this.InputOpponent = new System.Windows.Forms.TextBox();
            this.LabelPostcode = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelOpponent = new System.Windows.Forms.Label();
            this.LabelLeague = new System.Windows.Forms.Label();
            this.InputLeague = new System.Windows.Forms.ComboBox();
            this.NavBack = new System.Windows.Forms.Button();
            this.EventSave = new System.Windows.Forms.Button();
            this.LabelChangesMade = new System.Windows.Forms.Label();
            this.EventEdit = new System.Windows.Forms.Button();
            this.EventCancelEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(77, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(150, 33);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "View Match";
            // 
            // InputHomeMatch
            // 
            this.InputHomeMatch.AutoSize = true;
            this.InputHomeMatch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputHomeMatch.Location = new System.Drawing.Point(97, 194);
            this.InputHomeMatch.Name = "InputHomeMatch";
            this.InputHomeMatch.Size = new System.Drawing.Size(111, 22);
            this.InputHomeMatch.TabIndex = 5;
            this.InputHomeMatch.Text = "Home Match";
            this.InputHomeMatch.UseVisualStyleBackColor = true;
            this.InputHomeMatch.CheckedChanged += new System.EventHandler(this.InputHomeMatch_CheckedChanged);
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(97, 128);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(195, 27);
            this.InputDate.TabIndex = 2;
            this.InputDate.Value = new System.DateTime(2018, 11, 4, 0, 0, 0, 0);
            this.InputDate.ValueChanged += new System.EventHandler(this.InputDate_ValueChanged);
            // 
            // InputPostcode
            // 
            this.InputPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPostcode.Location = new System.Drawing.Point(97, 288);
            this.InputPostcode.Name = "InputPostcode";
            this.InputPostcode.Size = new System.Drawing.Size(195, 27);
            this.InputPostcode.TabIndex = 8;
            this.InputPostcode.TextChanged += new System.EventHandler(this.InputPostcode_TextChanged);
            // 
            // InputAddressB
            // 
            this.InputAddressB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddressB.Location = new System.Drawing.Point(97, 255);
            this.InputAddressB.Name = "InputAddressB";
            this.InputAddressB.Size = new System.Drawing.Size(195, 27);
            this.InputAddressB.TabIndex = 7;
            this.InputAddressB.TextChanged += new System.EventHandler(this.InputAddressB_TextChanged);
            // 
            // InputAddressA
            // 
            this.InputAddressA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddressA.Location = new System.Drawing.Point(97, 222);
            this.InputAddressA.Name = "InputAddressA";
            this.InputAddressA.Size = new System.Drawing.Size(195, 27);
            this.InputAddressA.TabIndex = 6;
            this.InputAddressA.TextChanged += new System.EventHandler(this.InputAddressA_TextChanged);
            // 
            // InputTimeM
            // 
            this.InputTimeM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeM.Location = new System.Drawing.Point(199, 161);
            this.InputTimeM.Name = "InputTimeM";
            this.InputTimeM.Size = new System.Drawing.Size(93, 27);
            this.InputTimeM.TabIndex = 4;
            this.InputTimeM.TextChanged += new System.EventHandler(this.InputTimeM_TextChanged);
            // 
            // InputTimeH
            // 
            this.InputTimeH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTimeH.Location = new System.Drawing.Point(97, 161);
            this.InputTimeH.Name = "InputTimeH";
            this.InputTimeH.Size = new System.Drawing.Size(93, 27);
            this.InputTimeH.TabIndex = 3;
            this.InputTimeH.TextChanged += new System.EventHandler(this.InputTimeH_TextChanged);
            // 
            // InputOpponent
            // 
            this.InputOpponent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOpponent.Location = new System.Drawing.Point(97, 97);
            this.InputOpponent.Name = "InputOpponent";
            this.InputOpponent.Size = new System.Drawing.Size(195, 27);
            this.InputOpponent.TabIndex = 1;
            this.InputOpponent.TextChanged += new System.EventHandler(this.InputOpponent_TextChanged);
            // 
            // LabelPostcode
            // 
            this.LabelPostcode.AutoSize = true;
            this.LabelPostcode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPostcode.Location = new System.Drawing.Point(12, 292);
            this.LabelPostcode.Name = "LabelPostcode";
            this.LabelPostcode.Size = new System.Drawing.Size(67, 18);
            this.LabelPostcode.TabIndex = 52;
            this.LabelPostcode.Text = "Postcode";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(12, 226);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(60, 18);
            this.LabelAddress.TabIndex = 51;
            this.LabelAddress.Text = "Address";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(12, 165);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(41, 18);
            this.LabelTime.TabIndex = 50;
            this.LabelTime.Text = "Time";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(12, 133);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(39, 18);
            this.LabelDate.TabIndex = 49;
            this.LabelDate.Text = "Date";
            // 
            // LabelOpponent
            // 
            this.LabelOpponent.AutoSize = true;
            this.LabelOpponent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponent.Location = new System.Drawing.Point(12, 101);
            this.LabelOpponent.Name = "LabelOpponent";
            this.LabelOpponent.Size = new System.Drawing.Size(72, 18);
            this.LabelOpponent.TabIndex = 48;
            this.LabelOpponent.Text = "Opponent";
            // 
            // LabelLeague
            // 
            this.LabelLeague.AutoSize = true;
            this.LabelLeague.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLeague.Location = new System.Drawing.Point(12, 68);
            this.LabelLeague.Name = "LabelLeague";
            this.LabelLeague.Size = new System.Drawing.Size(55, 18);
            this.LabelLeague.TabIndex = 47;
            this.LabelLeague.Text = "League";
            // 
            // InputLeague
            // 
            this.InputLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputLeague.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLeague.FormattingEnabled = true;
            this.InputLeague.Location = new System.Drawing.Point(97, 64);
            this.InputLeague.Name = "InputLeague";
            this.InputLeague.Size = new System.Drawing.Size(195, 27);
            this.InputLeague.TabIndex = 0;
            this.InputLeague.SelectedIndexChanged += new System.EventHandler(this.InputLeague_SelectedIndexChanged);
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(12, 12);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(59, 30);
            this.NavBack.TabIndex = 12;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            this.NavBack.Click += new System.EventHandler(this.NavBack_Click);
            // 
            // EventSave
            // 
            this.EventSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSave.Location = new System.Drawing.Point(233, 12);
            this.EventSave.Name = "EventSave";
            this.EventSave.Size = new System.Drawing.Size(59, 30);
            this.EventSave.TabIndex = 11;
            this.EventSave.Text = "Save";
            this.EventSave.UseVisualStyleBackColor = true;
            this.EventSave.Click += new System.EventHandler(this.EventSave_Click);
            // 
            // LabelChangesMade
            // 
            this.LabelChangesMade.AutoSize = true;
            this.LabelChangesMade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChangesMade.Location = new System.Drawing.Point(98, 321);
            this.LabelChangesMade.Name = "LabelChangesMade";
            this.LabelChangesMade.Size = new System.Drawing.Size(92, 38);
            this.LabelChangesMade.TabIndex = 63;
            this.LabelChangesMade.Text = "0 change(s)\r\nmade";
            // 
            // EventEdit
            // 
            this.EventEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEdit.Location = new System.Drawing.Point(97, 321);
            this.EventEdit.Name = "EventEdit";
            this.EventEdit.Size = new System.Drawing.Size(195, 30);
            this.EventEdit.TabIndex = 9;
            this.EventEdit.Text = "Edit";
            this.EventEdit.UseVisualStyleBackColor = true;
            this.EventEdit.Click += new System.EventHandler(this.EventEdit_Click);
            // 
            // EventCancelEdit
            // 
            this.EventCancelEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCancelEdit.Location = new System.Drawing.Point(199, 321);
            this.EventCancelEdit.Name = "EventCancelEdit";
            this.EventCancelEdit.Size = new System.Drawing.Size(93, 30);
            this.EventCancelEdit.TabIndex = 10;
            this.EventCancelEdit.Text = "Cancel Edit";
            this.EventCancelEdit.UseVisualStyleBackColor = true;
            this.EventCancelEdit.Click += new System.EventHandler(this.EventCancelEdit_Click);
            // 
            // ViewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 368);
            this.Controls.Add(this.EventCancelEdit);
            this.Controls.Add(this.EventEdit);
            this.Controls.Add(this.LabelChangesMade);
            this.Controls.Add(this.EventSave);
            this.Controls.Add(this.NavBack);
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
            this.Controls.Add(this.LabelLeague);
            this.Controls.Add(this.InputLeague);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ViewMatch";
            this.Text = "EditMatch";
            this.Load += new System.EventHandler(this.ViewMatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.CheckBox InputHomeMatch;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.TextBox InputPostcode;
        private System.Windows.Forms.TextBox InputAddressB;
        private System.Windows.Forms.TextBox InputAddressA;
        private System.Windows.Forms.TextBox InputTimeM;
        private System.Windows.Forms.TextBox InputTimeH;
        private System.Windows.Forms.TextBox InputOpponent;
        private System.Windows.Forms.Label LabelPostcode;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelOpponent;
        private System.Windows.Forms.Label LabelLeague;
        private System.Windows.Forms.ComboBox InputLeague;
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.Button EventSave;
        private System.Windows.Forms.Label LabelChangesMade;
        private System.Windows.Forms.Button EventEdit;
        private System.Windows.Forms.Button EventCancelEdit;
    }
}