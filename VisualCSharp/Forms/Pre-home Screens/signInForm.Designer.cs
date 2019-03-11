namespace VisualCSharp
{
    partial class signInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInForm));
            this.lblSignInTitle = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.BtnResetPassword = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.grpbxSignIn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignInTitle
            // 
            this.lblSignInTitle.AutoSize = true;
            this.lblSignInTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInTitle.Location = new System.Drawing.Point(181, 183);
            this.lblSignInTitle.Name = "lblSignInTitle";
            this.lblSignInTitle.Size = new System.Drawing.Size(123, 42);
            this.lblSignInTitle.TabIndex = 0;
            this.lblSignInTitle.Text = "Sign In";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(107, 13);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(183, 26);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(107, 45);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(183, 26);
            this.TxtPassword.TabIndex = 2;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.Location = new System.Drawing.Point(192, 77);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(98, 36);
            this.BtnSignIn.TabIndex = 3;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 23);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // BtnResetPassword
            // 
            this.BtnResetPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetPassword.Location = new System.Drawing.Point(251, 358);
            this.BtnResetPassword.Name = "BtnResetPassword";
            this.BtnResetPassword.Size = new System.Drawing.Size(142, 36);
            this.BtnResetPassword.TabIndex = 7;
            this.BtnResetPassword.Text = "Reset Password";
            this.BtnResetPassword.UseVisualStyleBackColor = true;
            this.BtnResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(89, 358);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(98, 36);
            this.BtnRegister.TabIndex = 8;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // grpbxSignIn
            // 
            this.grpbxSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpbxSignIn.Controls.Add(this.lblPassword);
            this.grpbxSignIn.Controls.Add(this.lblUsername);
            this.grpbxSignIn.Controls.Add(this.BtnSignIn);
            this.grpbxSignIn.Controls.Add(this.TxtPassword);
            this.grpbxSignIn.Controls.Add(this.TxtUsername);
            this.grpbxSignIn.Location = new System.Drawing.Point(91, 232);
            this.grpbxSignIn.Name = "grpbxSignIn";
            this.grpbxSignIn.Size = new System.Drawing.Size(302, 121);
            this.grpbxSignIn.TabIndex = 11;
            this.grpbxSignIn.TabStop = false;
            // 
            // signInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 428);
            this.Controls.Add(this.grpbxSignIn);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnResetPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSignInTitle);
            this.Name = "signInForm";
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxSignIn.ResumeLayout(false);
            this.grpbxSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignInTitle;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;


        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button BtnResetPassword;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.GroupBox grpbxSignIn;
    }
}

