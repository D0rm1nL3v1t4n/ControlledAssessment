namespace WelshWanderers
{
    partial class Home
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
            this.NavManageUsers = new System.Windows.Forms.Button();
            this.NavViewLeagues = new System.Windows.Forms.Button();
            this.NavUserJoinRequests = new System.Windows.Forms.Button();
            this.NavAddMatch = new System.Windows.Forms.Button();
            this.NavViewTrainings = new System.Windows.Forms.Button();
            this.NavAddTraining = new System.Windows.Forms.Button();
            this.NavViewMatches = new System.Windows.Forms.Button();
            this.NavMyEmails = new System.Windows.Forms.Button();
            this.NavLeagueStatistics = new System.Windows.Forms.Button();
            this.NavMatchNotifications = new System.Windows.Forms.Button();
            this.EventNavSignOut = new System.Windows.Forms.Button();
            this.NavMyAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(159, 9);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(99, 33);
            this.LabelHeader.TabIndex = 5;
            this.LabelHeader.Text = "Sign In";
            // 
            // NavManageUsers
            // 
            this.NavManageUsers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavManageUsers.Location = new System.Drawing.Point(160, 68);
            this.NavManageUsers.Name = "NavManageUsers";
            this.NavManageUsers.Size = new System.Drawing.Size(95, 48);
            this.NavManageUsers.TabIndex = 6;
            this.NavManageUsers.Text = "Manage Users";
            this.NavManageUsers.UseVisualStyleBackColor = true;
            this.NavManageUsers.Click += new System.EventHandler(this.NavManageUsers_Click);
            // 
            // NavViewLeagues
            // 
            this.NavViewLeagues.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavViewLeagues.Location = new System.Drawing.Point(162, 176);
            this.NavViewLeagues.Name = "NavViewLeagues";
            this.NavViewLeagues.Size = new System.Drawing.Size(95, 48);
            this.NavViewLeagues.TabIndex = 8;
            this.NavViewLeagues.Text = "Leagues";
            this.NavViewLeagues.UseVisualStyleBackColor = true;
            this.NavViewLeagues.Click += new System.EventHandler(this.NavViewLeagues_Click);
            // 
            // NavUserJoinRequests
            // 
            this.NavUserJoinRequests.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavUserJoinRequests.Location = new System.Drawing.Point(162, 122);
            this.NavUserJoinRequests.Name = "NavUserJoinRequests";
            this.NavUserJoinRequests.Size = new System.Drawing.Size(95, 48);
            this.NavUserJoinRequests.TabIndex = 9;
            this.NavUserJoinRequests.Text = "User Join Requests";
            this.NavUserJoinRequests.UseVisualStyleBackColor = true;
            this.NavUserJoinRequests.Click += new System.EventHandler(this.NavUserJoinRequests_Click);
            // 
            // NavAddMatch
            // 
            this.NavAddMatch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavAddMatch.Location = new System.Drawing.Point(110, 84);
            this.NavAddMatch.Name = "NavAddMatch";
            this.NavAddMatch.Size = new System.Drawing.Size(95, 48);
            this.NavAddMatch.TabIndex = 10;
            this.NavAddMatch.Text = "Add Match";
            this.NavAddMatch.UseVisualStyleBackColor = true;
            this.NavAddMatch.Click += new System.EventHandler(this.NavAddMatch_Click);
            // 
            // NavViewTrainings
            // 
            this.NavViewTrainings.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavViewTrainings.Location = new System.Drawing.Point(211, 153);
            this.NavViewTrainings.Name = "NavViewTrainings";
            this.NavViewTrainings.Size = new System.Drawing.Size(95, 48);
            this.NavViewTrainings.TabIndex = 11;
            this.NavViewTrainings.Text = "View Trainings";
            this.NavViewTrainings.UseVisualStyleBackColor = true;
            this.NavViewTrainings.Click += new System.EventHandler(this.NavViewTrainings_Click);
            // 
            // NavAddTraining
            // 
            this.NavAddTraining.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavAddTraining.Location = new System.Drawing.Point(211, 84);
            this.NavAddTraining.Name = "NavAddTraining";
            this.NavAddTraining.Size = new System.Drawing.Size(95, 48);
            this.NavAddTraining.TabIndex = 12;
            this.NavAddTraining.Text = "Add Training";
            this.NavAddTraining.UseVisualStyleBackColor = true;
            this.NavAddTraining.Click += new System.EventHandler(this.NavAddTraining_Click);
            // 
            // NavViewMatches
            // 
            this.NavViewMatches.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavViewMatches.Location = new System.Drawing.Point(110, 153);
            this.NavViewMatches.Name = "NavViewMatches";
            this.NavViewMatches.Size = new System.Drawing.Size(95, 48);
            this.NavViewMatches.TabIndex = 13;
            this.NavViewMatches.Text = "View Matches";
            this.NavViewMatches.UseVisualStyleBackColor = true;
            this.NavViewMatches.Click += new System.EventHandler(this.NavViewMatches_Click);
            // 
            // NavMyEmails
            // 
            this.NavMyEmails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavMyEmails.Location = new System.Drawing.Point(160, 207);
            this.NavMyEmails.Name = "NavMyEmails";
            this.NavMyEmails.Size = new System.Drawing.Size(95, 48);
            this.NavMyEmails.TabIndex = 14;
            this.NavMyEmails.Text = "My Emails";
            this.NavMyEmails.UseVisualStyleBackColor = true;
            // 
            // NavLeagueStatistics
            // 
            this.NavLeagueStatistics.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavLeagueStatistics.Location = new System.Drawing.Point(110, 76);
            this.NavLeagueStatistics.Name = "NavLeagueStatistics";
            this.NavLeagueStatistics.Size = new System.Drawing.Size(95, 48);
            this.NavLeagueStatistics.TabIndex = 15;
            this.NavLeagueStatistics.Text = "League Statistics";
            this.NavLeagueStatistics.UseVisualStyleBackColor = true;
            this.NavLeagueStatistics.Click += new System.EventHandler(this.NavLeagueStatistics_Click);
            // 
            // NavMatchNotifications
            // 
            this.NavMatchNotifications.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavMatchNotifications.Location = new System.Drawing.Point(211, 76);
            this.NavMatchNotifications.Name = "NavMatchNotifications";
            this.NavMatchNotifications.Size = new System.Drawing.Size(95, 48);
            this.NavMatchNotifications.TabIndex = 16;
            this.NavMatchNotifications.Text = "Match Notifications";
            this.NavMatchNotifications.UseVisualStyleBackColor = true;
            this.NavMatchNotifications.Click += new System.EventHandler(this.NavMatchNotifications_Click);
            // 
            // EventNavSignOut
            // 
            this.EventNavSignOut.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavSignOut.Location = new System.Drawing.Point(37, 264);
            this.EventNavSignOut.Name = "EventNavSignOut";
            this.EventNavSignOut.Size = new System.Drawing.Size(95, 48);
            this.EventNavSignOut.TabIndex = 17;
            this.EventNavSignOut.Text = "Sign Out";
            this.EventNavSignOut.UseVisualStyleBackColor = true;
            this.EventNavSignOut.Click += new System.EventHandler(this.EventNavSignOut_Click);
            // 
            // NavMyAccount
            // 
            this.NavMyAccount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavMyAccount.Location = new System.Drawing.Point(284, 264);
            this.NavMyAccount.Name = "NavMyAccount";
            this.NavMyAccount.Size = new System.Drawing.Size(95, 48);
            this.NavMyAccount.TabIndex = 18;
            this.NavMyAccount.Text = "My Account";
            this.NavMyAccount.UseVisualStyleBackColor = true;
            this.NavMyAccount.Click += new System.EventHandler(this.NavMyAccount_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 384);
            this.Controls.Add(this.NavMyAccount);
            this.Controls.Add(this.EventNavSignOut);
            this.Controls.Add(this.NavMatchNotifications);
            this.Controls.Add(this.NavLeagueStatistics);
            this.Controls.Add(this.NavMyEmails);
            this.Controls.Add(this.NavViewMatches);
            this.Controls.Add(this.NavAddTraining);
            this.Controls.Add(this.NavViewTrainings);
            this.Controls.Add(this.NavAddMatch);
            this.Controls.Add(this.NavUserJoinRequests);
            this.Controls.Add(this.NavViewLeagues);
            this.Controls.Add(this.NavManageUsers);
            this.Controls.Add(this.LabelHeader);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button NavManageUsers;
        private System.Windows.Forms.Button NavViewLeagues;
        private System.Windows.Forms.Button NavUserJoinRequests;
        private System.Windows.Forms.Button NavAddMatch;
        private System.Windows.Forms.Button NavViewTrainings;
        private System.Windows.Forms.Button NavAddTraining;
        private System.Windows.Forms.Button NavViewMatches;
        private System.Windows.Forms.Button NavMyEmails;
        private System.Windows.Forms.Button NavLeagueStatistics;
        private System.Windows.Forms.Button NavMatchNotifications;
        private System.Windows.Forms.Button EventNavSignOut;
        private System.Windows.Forms.Button NavMyAccount;
    }
}