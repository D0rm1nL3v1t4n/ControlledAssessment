namespace WelshWanderers
{
    partial class MyAccount
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
            this.InputDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.InputPostcode = new System.Windows.Forms.TextBox();
            this.InputTelephoneNumber = new System.Windows.Forms.TextBox();
            this.InputEmailAddress = new System.Windows.Forms.TextBox();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.LabelPostcode = new System.Windows.Forms.Label();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelEmailAddress = new System.Windows.Forms.Label();
            this.LabelTelephoneNumber = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.InputTitle = new System.Windows.Forms.ComboBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.NavHome = new System.Windows.Forms.Button();
            this.EventNavSave = new System.Windows.Forms.Button();
            this.LabelChangesMade = new System.Windows.Forms.Label();
            this.EventNavChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputDateOfBirth
            // 
            this.InputDateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDateOfBirth.Location = new System.Drawing.Point(151, 157);
            this.InputDateOfBirth.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.InputDateOfBirth.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.InputDateOfBirth.Name = "InputDateOfBirth";
            this.InputDateOfBirth.Size = new System.Drawing.Size(161, 27);
            this.InputDateOfBirth.TabIndex = 3;
            this.InputDateOfBirth.Value = new System.DateTime(2018, 10, 26, 0, 0, 0, 0);
            this.InputDateOfBirth.ValueChanged += new System.EventHandler(this.InputDateOfBirth_ValueChanged);
            // 
            // InputPostcode
            // 
            this.InputPostcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPostcode.Location = new System.Drawing.Point(151, 256);
            this.InputPostcode.Name = "InputPostcode";
            this.InputPostcode.Size = new System.Drawing.Size(161, 27);
            this.InputPostcode.TabIndex = 6;
            this.InputPostcode.TextChanged += new System.EventHandler(this.InputPostcode_TextChanged);
            // 
            // InputTelephoneNumber
            // 
            this.InputTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTelephoneNumber.Location = new System.Drawing.Point(151, 223);
            this.InputTelephoneNumber.Name = "InputTelephoneNumber";
            this.InputTelephoneNumber.Size = new System.Drawing.Size(161, 27);
            this.InputTelephoneNumber.TabIndex = 5;
            this.InputTelephoneNumber.TextChanged += new System.EventHandler(this.InputTelephoneNumber_TextChanged);
            // 
            // InputEmailAddress
            // 
            this.InputEmailAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEmailAddress.Location = new System.Drawing.Point(151, 190);
            this.InputEmailAddress.Name = "InputEmailAddress";
            this.InputEmailAddress.Size = new System.Drawing.Size(161, 27);
            this.InputEmailAddress.TabIndex = 4;
            this.InputEmailAddress.TextChanged += new System.EventHandler(this.InputEmailAddress_TextChanged);
            // 
            // InputLastName
            // 
            this.InputLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLastName.Location = new System.Drawing.Point(151, 124);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(161, 27);
            this.InputLastName.TabIndex = 2;
            this.InputLastName.TextChanged += new System.EventHandler(this.InputLastName_TextChanged);
            // 
            // LabelPostcode
            // 
            this.LabelPostcode.AutoSize = true;
            this.LabelPostcode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPostcode.Location = new System.Drawing.Point(12, 260);
            this.LabelPostcode.Name = "LabelPostcode";
            this.LabelPostcode.Size = new System.Drawing.Size(67, 18);
            this.LabelPostcode.TabIndex = 30;
            this.LabelPostcode.Text = "Postcode";
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDateOfBirth.Location = new System.Drawing.Point(12, 161);
            this.LabelDateOfBirth.Name = "LabelDateOfBirth";
            this.LabelDateOfBirth.Size = new System.Drawing.Size(91, 18);
            this.LabelDateOfBirth.TabIndex = 29;
            this.LabelDateOfBirth.Text = "Date of Birth";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(12, 128);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(79, 18);
            this.LabelLastName.TabIndex = 28;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelEmailAddress
            // 
            this.LabelEmailAddress.AutoSize = true;
            this.LabelEmailAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmailAddress.Location = new System.Drawing.Point(12, 194);
            this.LabelEmailAddress.Name = "LabelEmailAddress";
            this.LabelEmailAddress.Size = new System.Drawing.Size(98, 18);
            this.LabelEmailAddress.TabIndex = 27;
            this.LabelEmailAddress.Text = "Email Address";
            // 
            // LabelTelephoneNumber
            // 
            this.LabelTelephoneNumber.AutoSize = true;
            this.LabelTelephoneNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTelephoneNumber.Location = new System.Drawing.Point(12, 227);
            this.LabelTelephoneNumber.Name = "LabelTelephoneNumber";
            this.LabelTelephoneNumber.Size = new System.Drawing.Size(133, 18);
            this.LabelTelephoneNumber.TabIndex = 26;
            this.LabelTelephoneNumber.Text = "Telephone Number";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.Location = new System.Drawing.Point(12, 95);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(79, 18);
            this.LabelFirstName.TabIndex = 25;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 62);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(35, 18);
            this.LabelTitle.TabIndex = 24;
            this.LabelTitle.Text = "Title";
            // 
            // InputFirstName
            // 
            this.InputFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFirstName.Location = new System.Drawing.Point(151, 91);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(161, 27);
            this.InputFirstName.TabIndex = 1;
            this.InputFirstName.TextChanged += new System.EventHandler(this.InputFirstName_TextChanged);
            // 
            // InputTitle
            // 
            this.InputTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTitle.FormattingEnabled = true;
            this.InputTitle.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs"});
            this.InputTitle.Location = new System.Drawing.Point(151, 58);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(161, 27);
            this.InputTitle.TabIndex = 0;
            this.InputTitle.SelectedIndexChanged += new System.EventHandler(this.InputTitle_SelectedIndexChanged);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(87, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(151, 33);
            this.LabelHeader.TabIndex = 21;
            this.LabelHeader.Text = "My Account";
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 12);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(67, 30);
            this.NavHome.TabIndex = 9;
            this.NavHome.Text = "Back";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // EventNavSave
            // 
            this.EventNavSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSave.Location = new System.Drawing.Point(254, 12);
            this.EventNavSave.Name = "EventNavSave";
            this.EventNavSave.Size = new System.Drawing.Size(58, 30);
            this.EventNavSave.TabIndex = 8;
            this.EventNavSave.Text = "Save";
            this.EventNavSave.UseVisualStyleBackColor = true;
            this.EventNavSave.Click += new System.EventHandler(this.EventNavSave_Click);
            // 
            // LabelChangesMade
            // 
            this.LabelChangesMade.AutoSize = true;
            this.LabelChangesMade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChangesMade.Location = new System.Drawing.Point(147, 322);
            this.LabelChangesMade.Name = "LabelChangesMade";
            this.LabelChangesMade.Size = new System.Drawing.Size(91, 19);
            this.LabelChangesMade.TabIndex = 64;
            this.LabelChangesMade.Text = "No changes";
            // 
            // EventNavChangePassword
            // 
            this.EventNavChangePassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavChangePassword.Location = new System.Drawing.Point(151, 289);
            this.EventNavChangePassword.Name = "EventNavChangePassword";
            this.EventNavChangePassword.Size = new System.Drawing.Size(161, 30);
            this.EventNavChangePassword.TabIndex = 7;
            this.EventNavChangePassword.Text = "Change Password";
            this.EventNavChangePassword.UseVisualStyleBackColor = true;
            this.EventNavChangePassword.Click += new System.EventHandler(this.EventNavChangePassword_Click);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.EventNavChangePassword);
            this.Controls.Add(this.LabelChangesMade);
            this.Controls.Add(this.EventNavSave);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.InputDateOfBirth);
            this.Controls.Add(this.InputPostcode);
            this.Controls.Add(this.InputTelephoneNumber);
            this.Controls.Add(this.InputEmailAddress);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.LabelPostcode);
            this.Controls.Add(this.LabelDateOfBirth);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelEmailAddress);
            this.Controls.Add(this.LabelTelephoneNumber);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.InputFirstName);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.LabelHeader);
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker InputDateOfBirth;
        private System.Windows.Forms.TextBox InputPostcode;
        private System.Windows.Forms.TextBox InputTelephoneNumber;
        private System.Windows.Forms.TextBox InputEmailAddress;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.Label LabelPostcode;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelEmailAddress;
        private System.Windows.Forms.Label LabelTelephoneNumber;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.ComboBox InputTitle;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button EventNavSave;
        private System.Windows.Forms.Label LabelChangesMade;
        private System.Windows.Forms.Button EventNavChangePassword;
    }
}