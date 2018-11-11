namespace VisualCSharp.Forms
{
    partial class coachHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coachHomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHomeCoachTitle = new System.Windows.Forms.Label();
            this.BtnAddMatch = new System.Windows.Forms.Button();
            this.BtnAddTraining = new System.Windows.Forms.Button();
            this.BtnViewTrainings = new System.Windows.Forms.Button();
            this.BtnViewMatches = new System.Windows.Forms.Button();
            this.BtnMyAccountCoach = new System.Windows.Forms.Button();
            this.BtnSignOutCoach = new System.Windows.Forms.Button();
            this.BtnEmails = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblHomeCoachTitle
            // 
            this.lblHomeCoachTitle.AutoSize = true;
            this.lblHomeCoachTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeCoachTitle.Location = new System.Drawing.Point(188, 183);
            this.lblHomeCoachTitle.Name = "lblHomeCoachTitle";
            this.lblHomeCoachTitle.Size = new System.Drawing.Size(108, 42);
            this.lblHomeCoachTitle.TabIndex = 7;
            this.lblHomeCoachTitle.Text = "Home";
            // 
            // BtnAddMatch
            // 
            this.BtnAddMatch.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMatch.Location = new System.Drawing.Point(35, 248);
            this.BtnAddMatch.Name = "BtnAddMatch";
            this.BtnAddMatch.Size = new System.Drawing.Size(151, 68);
            this.BtnAddMatch.TabIndex = 10;
            this.BtnAddMatch.Text = "Add Match";
            this.BtnAddMatch.UseVisualStyleBackColor = true;
            this.BtnAddMatch.Click += new System.EventHandler(this.BtnAddMatch_Click);
            // 
            // BtnAddTraining
            // 
            this.BtnAddTraining.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTraining.Location = new System.Drawing.Point(35, 350);
            this.BtnAddTraining.Name = "BtnAddTraining";
            this.BtnAddTraining.Size = new System.Drawing.Size(151, 68);
            this.BtnAddTraining.TabIndex = 11;
            this.BtnAddTraining.Text = "Add Training";
            this.BtnAddTraining.UseVisualStyleBackColor = true;
            this.BtnAddTraining.Click += new System.EventHandler(this.BtnAddTraining_Click);
            // 
            // BtnViewTrainings
            // 
            this.BtnViewTrainings.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewTrainings.Location = new System.Drawing.Point(258, 350);
            this.BtnViewTrainings.Name = "BtnViewTrainings";
            this.BtnViewTrainings.Size = new System.Drawing.Size(151, 68);
            this.BtnViewTrainings.TabIndex = 12;
            this.BtnViewTrainings.Text = "View Trainings";
            this.BtnViewTrainings.UseVisualStyleBackColor = true;
            this.BtnViewTrainings.Click += new System.EventHandler(this.BtnViewTrainings_Click);
            // 
            // BtnViewMatches
            // 
            this.BtnViewMatches.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewMatches.Location = new System.Drawing.Point(258, 248);
            this.BtnViewMatches.Name = "BtnViewMatches";
            this.BtnViewMatches.Size = new System.Drawing.Size(151, 68);
            this.BtnViewMatches.TabIndex = 13;
            this.BtnViewMatches.Text = "View Matches";
            this.BtnViewMatches.UseVisualStyleBackColor = true;
            this.BtnViewMatches.Click += new System.EventHandler(this.BtnViewMatches_Click);
            // 
            // BtnMyAccountCoach
            // 
            this.BtnMyAccountCoach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyAccountCoach.Location = new System.Drawing.Point(296, 564);
            this.BtnMyAccountCoach.Name = "BtnMyAccountCoach";
            this.BtnMyAccountCoach.Size = new System.Drawing.Size(113, 34);
            this.BtnMyAccountCoach.TabIndex = 15;
            this.BtnMyAccountCoach.Text = "My Account";
            this.BtnMyAccountCoach.UseVisualStyleBackColor = true;
            this.BtnMyAccountCoach.Click += new System.EventHandler(this.BtnMyAccountCoach_Click);
            // 
            // BtnSignOutCoach
            // 
            this.BtnSignOutCoach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOutCoach.Location = new System.Drawing.Point(45, 564);
            this.BtnSignOutCoach.Name = "BtnSignOutCoach";
            this.BtnSignOutCoach.Size = new System.Drawing.Size(113, 34);
            this.BtnSignOutCoach.TabIndex = 14;
            this.BtnSignOutCoach.Text = "Sign Out";
            this.BtnSignOutCoach.UseVisualStyleBackColor = true;
            this.BtnSignOutCoach.Click += new System.EventHandler(this.BtnSignOutCoach_Click);
            // 
            // BtnEmails
            // 
            this.BtnEmails.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmails.Location = new System.Drawing.Point(145, 461);
            this.BtnEmails.Name = "BtnEmails";
            this.BtnEmails.Size = new System.Drawing.Size(151, 68);
            this.BtnEmails.TabIndex = 16;
            this.BtnEmails.Text = "Emails";
            this.BtnEmails.UseVisualStyleBackColor = true;
            // 
            // coachHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.BtnEmails);
            this.Controls.Add(this.BtnMyAccountCoach);
            this.Controls.Add(this.BtnSignOutCoach);
            this.Controls.Add(this.BtnViewMatches);
            this.Controls.Add(this.BtnViewTrainings);
            this.Controls.Add(this.BtnAddTraining);
            this.Controls.Add(this.BtnAddMatch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHomeCoachTitle);
            this.Name = "coachHomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHomeCoachTitle;
        private System.Windows.Forms.Button BtnAddMatch;
        private System.Windows.Forms.Button BtnAddTraining;
        private System.Windows.Forms.Button BtnViewTrainings;
        private System.Windows.Forms.Button BtnViewMatches;
        private System.Windows.Forms.Button BtnMyAccountCoach;
        private System.Windows.Forms.Button BtnSignOutCoach;
        private System.Windows.Forms.Button BtnEmails;

    }
}