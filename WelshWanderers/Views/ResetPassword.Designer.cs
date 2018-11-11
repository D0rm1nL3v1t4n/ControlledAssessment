namespace WelshWanderers
{
    partial class ResetPassword
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
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.EventNavChangePassword = new System.Windows.Forms.Button();
            this.EventEnter = new System.Windows.Forms.Button();
            this.LabelMsgUsername = new System.Windows.Forms.Label();
            this.LabelMsgEmail = new System.Windows.Forms.Label();
            this.LabelUserEmail = new System.Windows.Forms.Label();
            this.LabelMsgCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputNewPassword = new System.Windows.Forms.TextBox();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.LableConfirmNewPassword = new System.Windows.Forms.Label();
            this.InputConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.NavCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputUsername
            // 
            this.InputUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(53, 109);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(188, 27);
            this.InputUsername.TabIndex = 3;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(91, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(202, 33);
            this.LabelHeader.TabIndex = 5;
            this.LabelHeader.Text = "Reset Password";
            // 
            // EventNavChangePassword
            // 
            this.EventNavChangePassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavChangePassword.Location = new System.Drawing.Point(250, 409);
            this.EventNavChangePassword.Name = "EventNavChangePassword";
            this.EventNavChangePassword.Size = new System.Drawing.Size(89, 48);
            this.EventNavChangePassword.TabIndex = 7;
            this.EventNavChangePassword.Text = "Change Password";
            this.EventNavChangePassword.UseVisualStyleBackColor = true;
            this.EventNavChangePassword.Click += new System.EventHandler(this.EventNavChangePassword_Click);
            // 
            // EventEnter
            // 
            this.EventEnter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEnter.Location = new System.Drawing.Point(247, 98);
            this.EventEnter.Name = "EventEnter";
            this.EventEnter.Size = new System.Drawing.Size(89, 48);
            this.EventEnter.TabIndex = 8;
            this.EventEnter.Text = "Enter";
            this.EventEnter.UseVisualStyleBackColor = true;
            this.EventEnter.Click += new System.EventHandler(this.EventEnter_Click);
            // 
            // LabelMsgUsername
            // 
            this.LabelMsgUsername.AutoSize = true;
            this.LabelMsgUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsgUsername.Location = new System.Drawing.Point(50, 87);
            this.LabelMsgUsername.Name = "LabelMsgUsername";
            this.LabelMsgUsername.Size = new System.Drawing.Size(163, 19);
            this.LabelMsgUsername.TabIndex = 9;
            this.LabelMsgUsername.Text = "Enter your username:";
            // 
            // LabelMsgEmail
            // 
            this.LabelMsgEmail.AutoSize = true;
            this.LabelMsgEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsgEmail.Location = new System.Drawing.Point(50, 171);
            this.LabelMsgEmail.Name = "LabelMsgEmail";
            this.LabelMsgEmail.Size = new System.Drawing.Size(252, 57);
            this.LabelMsgEmail.TabIndex = 10;
            this.LabelMsgEmail.Text = "The following email address\r\nwill be sent an email with a 6 digit\r\ncode to reset " +
    "your password:";
            // 
            // LabelUserEmail
            // 
            this.LabelUserEmail.AutoSize = true;
            this.LabelUserEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserEmail.Location = new System.Drawing.Point(78, 246);
            this.LabelUserEmail.Name = "LabelUserEmail";
            this.LabelUserEmail.Size = new System.Drawing.Size(59, 19);
            this.LabelUserEmail.TabIndex = 11;
            this.LabelUserEmail.Text = "EMPTY";
            // 
            // LabelMsgCode
            // 
            this.LabelMsgCode.AutoSize = true;
            this.LabelMsgCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMsgCode.Location = new System.Drawing.Point(49, 289);
            this.LabelMsgCode.Name = "LabelMsgCode";
            this.LabelMsgCode.Size = new System.Drawing.Size(98, 19);
            this.LabelMsgCode.TabIndex = 12;
            this.LabelMsgCode.Text = "6 digit code:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(153, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 27);
            this.textBox1.TabIndex = 13;
            // 
            // InputNewPassword
            // 
            this.InputNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNewPassword.Location = new System.Drawing.Point(189, 340);
            this.InputNewPassword.Name = "InputNewPassword";
            this.InputNewPassword.Size = new System.Drawing.Size(150, 27);
            this.InputNewPassword.TabIndex = 14;
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.AutoSize = true;
            this.LabelNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewPassword.Location = new System.Drawing.Point(71, 343);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(112, 19);
            this.LabelNewPassword.TabIndex = 15;
            this.LabelNewPassword.Text = "New Password";
            // 
            // LableConfirmNewPassword
            // 
            this.LableConfirmNewPassword.AutoSize = true;
            this.LableConfirmNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableConfirmNewPassword.Location = new System.Drawing.Point(45, 379);
            this.LableConfirmNewPassword.Name = "LableConfirmNewPassword";
            this.LableConfirmNewPassword.Size = new System.Drawing.Size(138, 19);
            this.LableConfirmNewPassword.TabIndex = 16;
            this.LableConfirmNewPassword.Text = "Confirm Password";
            // 
            // InputConfirmNewPassword
            // 
            this.InputConfirmNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputConfirmNewPassword.Location = new System.Drawing.Point(189, 376);
            this.InputConfirmNewPassword.Name = "InputConfirmNewPassword";
            this.InputConfirmNewPassword.Size = new System.Drawing.Size(150, 27);
            this.InputConfirmNewPassword.TabIndex = 18;
            // 
            // NavCancel
            // 
            this.NavCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavCancel.Location = new System.Drawing.Point(38, 409);
            this.NavCancel.Name = "NavCancel";
            this.NavCancel.Size = new System.Drawing.Size(89, 48);
            this.NavCancel.TabIndex = 19;
            this.NavCancel.Text = "Cancel";
            this.NavCancel.UseVisualStyleBackColor = true;
            this.NavCancel.Click += new System.EventHandler(this.NavCancel_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 485);
            this.Controls.Add(this.NavCancel);
            this.Controls.Add(this.InputConfirmNewPassword);
            this.Controls.Add(this.LableConfirmNewPassword);
            this.Controls.Add(this.LabelNewPassword);
            this.Controls.Add(this.InputNewPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelMsgCode);
            this.Controls.Add(this.LabelUserEmail);
            this.Controls.Add(this.LabelMsgEmail);
            this.Controls.Add(this.LabelMsgUsername);
            this.Controls.Add(this.EventEnter);
            this.Controls.Add(this.EventNavChangePassword);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.InputUsername);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button EventNavChangePassword;
        private System.Windows.Forms.Button EventEnter;
        private System.Windows.Forms.Label LabelMsgUsername;
        private System.Windows.Forms.Label LabelMsgEmail;
        private System.Windows.Forms.Label LabelUserEmail;
        private System.Windows.Forms.Label LabelMsgCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox InputNewPassword;
        private System.Windows.Forms.Label LabelNewPassword;
        private System.Windows.Forms.Label LableConfirmNewPassword;
        private System.Windows.Forms.TextBox InputConfirmNewPassword;
        private System.Windows.Forms.Button NavCancel;
    }
}