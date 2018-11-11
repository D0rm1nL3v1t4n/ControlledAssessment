namespace VisualCSharp.Forms
{
    partial class playerHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerHomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHomeCoachTitle = new System.Windows.Forms.Label();
            this.BtnViewMatches = new System.Windows.Forms.Button();
            this.BtnViewTrainings = new System.Windows.Forms.Button();
            this.BtnPlayerStatistics = new System.Windows.Forms.Button();
            this.BtnMyAccountPlayer = new System.Windows.Forms.Button();
            this.BtnSignOutPlayer = new System.Windows.Forms.Button();
            this.BtnMatchNotifications = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblHomeCoachTitle
            // 
            this.lblHomeCoachTitle.AutoSize = true;
            this.lblHomeCoachTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeCoachTitle.Location = new System.Drawing.Point(188, 183);
            this.lblHomeCoachTitle.Name = "lblHomeCoachTitle";
            this.lblHomeCoachTitle.Size = new System.Drawing.Size(108, 42);
            this.lblHomeCoachTitle.TabIndex = 9;
            this.lblHomeCoachTitle.Text = "Home";
            // 
            // BtnViewMatches
            // 
            this.BtnViewMatches.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewMatches.Location = new System.Drawing.Point(46, 268);
            this.BtnViewMatches.Name = "BtnViewMatches";
            this.BtnViewMatches.Size = new System.Drawing.Size(151, 68);
            this.BtnViewMatches.TabIndex = 15;
            this.BtnViewMatches.Text = "View Matches";
            this.BtnViewMatches.UseVisualStyleBackColor = true;
            this.BtnViewMatches.Click += new System.EventHandler(this.BtnViewMatches_Click);
            // 
            // BtnViewTrainings
            // 
            this.BtnViewTrainings.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewTrainings.Location = new System.Drawing.Point(280, 268);
            this.BtnViewTrainings.Name = "BtnViewTrainings";
            this.BtnViewTrainings.Size = new System.Drawing.Size(151, 68);
            this.BtnViewTrainings.TabIndex = 14;
            this.BtnViewTrainings.Text = "View Trainings";
            this.BtnViewTrainings.UseVisualStyleBackColor = true;
            this.BtnViewTrainings.Click += new System.EventHandler(this.BtnViewTrainings_Click);
            // 
            // BtnPlayerStatistics
            // 
            this.BtnPlayerStatistics.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayerStatistics.Location = new System.Drawing.Point(280, 390);
            this.BtnPlayerStatistics.Name = "BtnPlayerStatistics";
            this.BtnPlayerStatistics.Size = new System.Drawing.Size(151, 68);
            this.BtnPlayerStatistics.TabIndex = 16;
            this.BtnPlayerStatistics.Text = "Player Statistics";
            this.BtnPlayerStatistics.UseVisualStyleBackColor = true;
            this.BtnPlayerStatistics.Click += new System.EventHandler(this.BtnPlayerStatistics_Click);
            // 
            // BtnMyAccountPlayer
            // 
            this.BtnMyAccountPlayer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyAccountPlayer.Location = new System.Drawing.Point(297, 566);
            this.BtnMyAccountPlayer.Name = "BtnMyAccountPlayer";
            this.BtnMyAccountPlayer.Size = new System.Drawing.Size(113, 34);
            this.BtnMyAccountPlayer.TabIndex = 18;
            this.BtnMyAccountPlayer.Text = "My Account";
            this.BtnMyAccountPlayer.UseVisualStyleBackColor = true;
            this.BtnMyAccountPlayer.Click += new System.EventHandler(this.BtnMyAccountPlayer_Click);
            // 
            // BtnSignOutPlayer
            // 
            this.BtnSignOutPlayer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOutPlayer.Location = new System.Drawing.Point(46, 566);
            this.BtnSignOutPlayer.Name = "BtnSignOutPlayer";
            this.BtnSignOutPlayer.Size = new System.Drawing.Size(113, 34);
            this.BtnSignOutPlayer.TabIndex = 17;
            this.BtnSignOutPlayer.Text = "Sign Out";
            this.BtnSignOutPlayer.UseVisualStyleBackColor = true;
            this.BtnSignOutPlayer.Click += new System.EventHandler(this.BtnSignOutPlayer_Click);
            // 
            // BtnMatchNotifications
            // 
            this.BtnMatchNotifications.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMatchNotifications.Location = new System.Drawing.Point(46, 390);
            this.BtnMatchNotifications.Name = "BtnMatchNotifications";
            this.BtnMatchNotifications.Size = new System.Drawing.Size(151, 68);
            this.BtnMatchNotifications.TabIndex = 19;
            this.BtnMatchNotifications.Text = "Match Notifications";
            this.BtnMatchNotifications.UseVisualStyleBackColor = true;
            this.BtnMatchNotifications.Click += new System.EventHandler(this.BtnMatchNotifications_Click);
            // 
            // playerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 640);
            this.Controls.Add(this.BtnMatchNotifications);
            this.Controls.Add(this.BtnMyAccountPlayer);
            this.Controls.Add(this.BtnSignOutPlayer);
            this.Controls.Add(this.BtnPlayerStatistics);
            this.Controls.Add(this.BtnViewMatches);
            this.Controls.Add(this.BtnViewTrainings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHomeCoachTitle);
            this.Name = "playerHomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHomeCoachTitle;
        private System.Windows.Forms.Button BtnViewMatches;
        private System.Windows.Forms.Button BtnViewTrainings;
        private System.Windows.Forms.Button BtnPlayerStatistics;
        private System.Windows.Forms.Button BtnMyAccountPlayer;
        private System.Windows.Forms.Button BtnSignOutPlayer;
        private System.Windows.Forms.Button BtnMatchNotifications;
    }
}