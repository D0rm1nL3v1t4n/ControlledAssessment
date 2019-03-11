namespace VisualCSharp.Forms
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.grpbxResetPassword = new System.Windows.Forms.GroupBox();
            this.BtnCancelResetPassword = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblSixDigitCode = new System.Windows.Forms.Label();
            this.TxtSixDigitCode = new System.Windows.Forms.TextBox();
            this.lblEmailAddressShow = new System.Windows.Forms.Label();
            this.lblResetPasswordMessage = new System.Windows.Forms.Label();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.BtnEnterUsername = new System.Windows.Forms.Button();
            this.TxtUsernameSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxResetPassword.SuspendLayout();
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
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.Location = new System.Drawing.Point(118, 183);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(248, 42);
            this.lblResetPassword.TabIndex = 5;
            this.lblResetPassword.Text = "Reset Password";
            // 
            // grpbxResetPassword
            // 
            this.grpbxResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxResetPassword.Controls.Add(this.BtnCancelResetPassword);
            this.grpbxResetPassword.Controls.Add(this.btnChangePassword);
            this.grpbxResetPassword.Controls.Add(this.lblConfirmNewPassword);
            this.grpbxResetPassword.Controls.Add(this.lblNewPassword);
            this.grpbxResetPassword.Controls.Add(this.txtConfirmNewPassword);
            this.grpbxResetPassword.Controls.Add(this.txtNewPassword);
            this.grpbxResetPassword.Controls.Add(this.lblSixDigitCode);
            this.grpbxResetPassword.Controls.Add(this.TxtSixDigitCode);
            this.grpbxResetPassword.Controls.Add(this.lblEmailAddressShow);
            this.grpbxResetPassword.Controls.Add(this.lblResetPasswordMessage);
            this.grpbxResetPassword.Controls.Add(this.lblEnterUsername);
            this.grpbxResetPassword.Controls.Add(this.BtnEnterUsername);
            this.grpbxResetPassword.Controls.Add(this.TxtUsernameSearch);
            this.grpbxResetPassword.Location = new System.Drawing.Point(76, 237);
            this.grpbxResetPassword.Name = "grpbxResetPassword";
            this.grpbxResetPassword.Size = new System.Drawing.Size(333, 342);
            this.grpbxResetPassword.TabIndex = 12;
            this.grpbxResetPassword.TabStop = false;
            this.grpbxResetPassword.Enter += new System.EventHandler(this.grpbxResetPassword_Enter);
            // 
            // BtnCancelResetPassword
            // 
            this.BtnCancelResetPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelResetPassword.Location = new System.Drawing.Point(21, 300);
            this.BtnCancelResetPassword.Name = "BtnCancelResetPassword";
            this.BtnCancelResetPassword.Size = new System.Drawing.Size(69, 27);
            this.BtnCancelResetPassword.TabIndex = 16;
            this.BtnCancelResetPassword.Text = "Cancel";
            this.BtnCancelResetPassword.UseVisualStyleBackColor = true;
            this.BtnCancelResetPassword.Click += new System.EventHandler(this.BtnCancelResetPassword_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(182, 300);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(135, 27);
            this.btnChangePassword.TabIndex = 15;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(17, 268);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(122, 19);
            this.lblConfirmNewPassword.TabIndex = 14;
            this.lblConfirmNewPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(17, 236);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(103, 19);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(145, 268);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(172, 26);
            this.txtConfirmNewPassword.TabIndex = 12;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(145, 236);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(172, 26);
            this.txtNewPassword.TabIndex = 11;
            // 
            // lblSixDigitCode
            // 
            this.lblSixDigitCode.AutoSize = true;
            this.lblSixDigitCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSixDigitCode.Location = new System.Drawing.Point(45, 176);
            this.lblSixDigitCode.Name = "lblSixDigitCode";
            this.lblSixDigitCode.Size = new System.Drawing.Size(83, 19);
            this.lblSixDigitCode.TabIndex = 10;
            this.lblSixDigitCode.Text = "6 digit code:";
            // 
            // TxtSixDigitCode
            // 
            this.TxtSixDigitCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSixDigitCode.Location = new System.Drawing.Point(145, 176);
            this.TxtSixDigitCode.Name = "TxtSixDigitCode";
            this.TxtSixDigitCode.Size = new System.Drawing.Size(103, 26);
            this.TxtSixDigitCode.TabIndex = 8;
            // 
            // lblEmailAddressShow
            // 
            this.lblEmailAddressShow.AutoSize = true;
            this.lblEmailAddressShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddressShow.Location = new System.Drawing.Point(17, 139);
            this.lblEmailAddressShow.Name = "lblEmailAddressShow";
            this.lblEmailAddressShow.Size = new System.Drawing.Size(0, 19);
            this.lblEmailAddressShow.TabIndex = 7;
            // 
            // lblResetPasswordMessage
            // 
            this.lblResetPasswordMessage.AutoSize = true;
            this.lblResetPasswordMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPasswordMessage.Location = new System.Drawing.Point(16, 84);
            this.lblResetPasswordMessage.Name = "lblResetPasswordMessage";
            this.lblResetPasswordMessage.Size = new System.Drawing.Size(301, 38);
            this.lblResetPasswordMessage.TabIndex = 6;
            this.lblResetPasswordMessage.Text = "The following email address will be sent an\r\nemail with a 6 digit code to reset y" +
    "our password:";
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.AutoSize = true;
            this.lblEnterUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUsername.Location = new System.Drawing.Point(16, 16);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(136, 19);
            this.lblEnterUsername.TabIndex = 5;
            this.lblEnterUsername.Text = "Enter your username:";
            // 
            // BtnEnterUsername
            // 
            this.BtnEnterUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnterUsername.Location = new System.Drawing.Point(226, 37);
            this.BtnEnterUsername.Name = "BtnEnterUsername";
            this.BtnEnterUsername.Size = new System.Drawing.Size(91, 27);
            this.BtnEnterUsername.TabIndex = 3;
            this.BtnEnterUsername.Text = "Enter";
            this.BtnEnterUsername.UseVisualStyleBackColor = true;
            this.BtnEnterUsername.Click += new System.EventHandler(this.BtnEnterUsername_Click);
            // 
            // TxtUsernameSearch
            // 
            this.TxtUsernameSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsernameSearch.Location = new System.Drawing.Point(20, 38);
            this.TxtUsernameSearch.Name = "TxtUsernameSearch";
            this.TxtUsernameSearch.Size = new System.Drawing.Size(198, 26);
            this.TxtUsernameSearch.TabIndex = 1;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 629);
            this.Controls.Add(this.grpbxResetPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResetPassword);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ResetPasswordForm";
            this.Text = "resetPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxResetPassword.ResumeLayout(false);
            this.grpbxResetPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.GroupBox grpbxResetPassword;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.Button BtnEnterUsername;
        private System.Windows.Forms.TextBox TxtUsernameSearch;
        private System.Windows.Forms.Label lblEmailAddressShow;
        private System.Windows.Forms.Label lblResetPasswordMessage;
        private System.Windows.Forms.TextBox TxtSixDigitCode;
        private System.Windows.Forms.Label lblSixDigitCode;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Button BtnCancelResetPassword;
        private System.Windows.Forms.Button btnChangePassword;
    }
}