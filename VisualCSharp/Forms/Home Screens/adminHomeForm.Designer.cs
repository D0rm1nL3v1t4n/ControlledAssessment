namespace VisualCSharp.Forms.Home_Screens
{
    partial class AdminHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHomeCoachTitle = new System.Windows.Forms.Label();
            this.BtnMyAccountPlayer = new System.Windows.Forms.Button();
            this.BtnSignOutPlayer = new System.Windows.Forms.Button();
            this.BtnViewMatches = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblHomeCoachTitle
            // 
            this.lblHomeCoachTitle.AutoSize = true;
            this.lblHomeCoachTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeCoachTitle.Location = new System.Drawing.Point(211, 183);
            this.lblHomeCoachTitle.Name = "lblHomeCoachTitle";
            this.lblHomeCoachTitle.Size = new System.Drawing.Size(108, 42);
            this.lblHomeCoachTitle.TabIndex = 11;
            this.lblHomeCoachTitle.Text = "Home";
            // 
            // BtnMyAccountPlayer
            // 
            this.BtnMyAccountPlayer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyAccountPlayer.Location = new System.Drawing.Point(334, 487);
            this.BtnMyAccountPlayer.Name = "BtnMyAccountPlayer";
            this.BtnMyAccountPlayer.Size = new System.Drawing.Size(113, 34);
            this.BtnMyAccountPlayer.TabIndex = 20;
            this.BtnMyAccountPlayer.Text = "My Account";
            this.BtnMyAccountPlayer.UseVisualStyleBackColor = true;
            this.BtnMyAccountPlayer.Click += new System.EventHandler(this.BtnMyAccountPlayer_Click);
            // 
            // BtnSignOutPlayer
            // 
            this.BtnSignOutPlayer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOutPlayer.Location = new System.Drawing.Point(83, 487);
            this.BtnSignOutPlayer.Name = "BtnSignOutPlayer";
            this.BtnSignOutPlayer.Size = new System.Drawing.Size(113, 34);
            this.BtnSignOutPlayer.TabIndex = 19;
            this.BtnSignOutPlayer.Text = "Sign Out";
            this.BtnSignOutPlayer.UseVisualStyleBackColor = true;
            this.BtnSignOutPlayer.Click += new System.EventHandler(this.BtnSignOutPlayer_Click);
            // 
            // BtnViewMatches
            // 
            this.BtnViewMatches.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewMatches.Location = new System.Drawing.Point(69, 249);
            this.BtnViewMatches.Name = "BtnViewMatches";
            this.BtnViewMatches.Size = new System.Drawing.Size(151, 68);
            this.BtnViewMatches.TabIndex = 21;
            this.BtnViewMatches.Text = "Manage users";
            this.BtnViewMatches.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 68);
            this.button1.TabIndex = 22;
            this.button1.Text = "User Join Requests";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(69, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 68);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add Meeting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(296, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 68);
            this.button3.TabIndex = 24;
            this.button3.Text = "View Meeting";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // adminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 568);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnViewMatches);
            this.Controls.Add(this.BtnMyAccountPlayer);
            this.Controls.Add(this.BtnSignOutPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHomeCoachTitle);
            this.Name = "adminHomeForm";
            this.Text = "adminHomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHomeCoachTitle;
        private System.Windows.Forms.Button BtnMyAccountPlayer;
        private System.Windows.Forms.Button BtnSignOutPlayer;
        private System.Windows.Forms.Button BtnViewMatches;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}