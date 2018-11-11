namespace VisualCSharp.Forms
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
            this.lblHomeAdminTitle = new System.Windows.Forms.Label();
            this.BtnUserJoinRequests = new System.Windows.Forms.Button();
            this.BtnAddMeeting = new System.Windows.Forms.Button();
            this.BtnViewMeetings = new System.Windows.Forms.Button();
            this.BtnManageUsers = new System.Windows.Forms.Button();
            this.BtnSignOutAdmim = new System.Windows.Forms.Button();
            this.BtnMyAccountAdmin = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblHomeAdminTitle
            // 
            this.lblHomeAdminTitle.AutoSize = true;
            this.lblHomeAdminTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAdminTitle.Location = new System.Drawing.Point(188, 183);
            this.lblHomeAdminTitle.Name = "lblHomeAdminTitle";
            this.lblHomeAdminTitle.Size = new System.Drawing.Size(108, 42);
            this.lblHomeAdminTitle.TabIndex = 5;
            this.lblHomeAdminTitle.Text = "Home";
            // 
            // BtnUserJoinRequests
            // 
            this.BtnUserJoinRequests.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserJoinRequests.Location = new System.Drawing.Point(270, 400);
            this.BtnUserJoinRequests.Name = "BtnUserJoinRequests";
            this.BtnUserJoinRequests.Size = new System.Drawing.Size(151, 68);
            this.BtnUserJoinRequests.TabIndex = 7;
            this.BtnUserJoinRequests.Text = "User Join Requests";
            this.BtnUserJoinRequests.UseVisualStyleBackColor = true;
            this.BtnUserJoinRequests.Click += new System.EventHandler(this.BtnUserJoinRequests_Click);
            // 
            // BtnAddMeeting
            // 
            this.BtnAddMeeting.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMeeting.Location = new System.Drawing.Point(70, 282);
            this.BtnAddMeeting.Name = "BtnAddMeeting";
            this.BtnAddMeeting.Size = new System.Drawing.Size(151, 68);
            this.BtnAddMeeting.TabIndex = 8;
            this.BtnAddMeeting.Text = "Add Meeting";
            this.BtnAddMeeting.UseVisualStyleBackColor = true;
            this.BtnAddMeeting.Click += new System.EventHandler(this.BtnAddMeeting_Click);
            // 
            // BtnViewMeetings
            // 
            this.BtnViewMeetings.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewMeetings.Location = new System.Drawing.Point(270, 282);
            this.BtnViewMeetings.Name = "BtnViewMeetings";
            this.BtnViewMeetings.Size = new System.Drawing.Size(151, 68);
            this.BtnViewMeetings.TabIndex = 9;
            this.BtnViewMeetings.Text = "View Meetings";
            this.BtnViewMeetings.UseVisualStyleBackColor = true;
            this.BtnViewMeetings.Click += new System.EventHandler(this.BtnViewMeetings_Click);
            // 
            // BtnManageUsers
            // 
            this.BtnManageUsers.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageUsers.Location = new System.Drawing.Point(70, 400);
            this.BtnManageUsers.Name = "BtnManageUsers";
            this.BtnManageUsers.Size = new System.Drawing.Size(151, 68);
            this.BtnManageUsers.TabIndex = 10;
            this.BtnManageUsers.Text = "Manage Users";
            this.BtnManageUsers.UseVisualStyleBackColor = true;
            this.BtnManageUsers.Click += new System.EventHandler(this.BtnManageUsers_Click);
            // 
            // BtnSignOutAdmim
            // 
            this.BtnSignOutAdmim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOutAdmim.Location = new System.Drawing.Point(70, 594);
            this.BtnSignOutAdmim.Name = "BtnSignOutAdmim";
            this.BtnSignOutAdmim.Size = new System.Drawing.Size(113, 34);
            this.BtnSignOutAdmim.TabIndex = 11;
            this.BtnSignOutAdmim.Text = "Sign Out";
            this.BtnSignOutAdmim.UseVisualStyleBackColor = true;
            this.BtnSignOutAdmim.Click += new System.EventHandler(this.BtnSignOutAdmim_Click);
            // 
            // BtnMyAccountAdmin
            // 
            this.BtnMyAccountAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyAccountAdmin.Location = new System.Drawing.Point(270, 594);
            this.BtnMyAccountAdmin.Name = "BtnMyAccountAdmin";
            this.BtnMyAccountAdmin.Size = new System.Drawing.Size(113, 34);
            this.BtnMyAccountAdmin.TabIndex = 12;
            this.BtnMyAccountAdmin.Text = "My Account";
            this.BtnMyAccountAdmin.UseVisualStyleBackColor = true;
            this.BtnMyAccountAdmin.Click += new System.EventHandler(this.BtnMyAccountAdmin_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.BtnMyAccountAdmin);
            this.Controls.Add(this.BtnSignOutAdmim);
            this.Controls.Add(this.BtnManageUsers);
            this.Controls.Add(this.BtnViewMeetings);
            this.Controls.Add(this.BtnAddMeeting);
            this.Controls.Add(this.BtnUserJoinRequests);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHomeAdminTitle);
            this.Name = "AdminHomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHomeAdminTitle;
        private System.Windows.Forms.Button BtnUserJoinRequests;
        private System.Windows.Forms.Button BtnAddMeeting;
        private System.Windows.Forms.Button BtnViewMeetings;
        private System.Windows.Forms.Button BtnManageUsers;
        private System.Windows.Forms.Button BtnSignOutAdmim;
        private System.Windows.Forms.Button BtnMyAccountAdmin;

    }
}