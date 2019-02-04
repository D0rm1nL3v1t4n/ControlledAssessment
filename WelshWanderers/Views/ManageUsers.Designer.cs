namespace WelshWanderers
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableManageUsers = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.InputAccessLevel = new System.Windows.Forms.ComboBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAccessLevel = new System.Windows.Forms.Label();
            this.NavHome = new System.Windows.Forms.Button();
            this.EventDelete = new System.Windows.Forms.Button();
            this.NavView = new System.Windows.Forms.Button();
            this.EventFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // TableManageUsers
            // 
            this.TableManageUsers.AllowUserToAddRows = false;
            this.TableManageUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableManageUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableManageUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColUsername,
            this.ColFirstName,
            this.ColLastName,
            this.ColAccessLevel,
            this.ColTeam});
            this.TableManageUsers.Location = new System.Drawing.Point(12, 99);
            this.TableManageUsers.Name = "TableManageUsers";
            this.TableManageUsers.ReadOnly = true;
            this.TableManageUsers.RowHeadersVisible = false;
            this.TableManageUsers.RowHeadersWidth = 10;
            this.TableManageUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableManageUsers.ShowCellToolTips = false;
            this.TableManageUsers.Size = new System.Drawing.Size(573, 299);
            this.TableManageUsers.TabIndex = 3;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 40;
            // 
            // ColUsername
            // 
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.ReadOnly = true;
            this.ColUsername.Width = 120;
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "First Name";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.ReadOnly = true;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Last Name";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.ReadOnly = true;
            // 
            // ColAccessLevel
            // 
            this.ColAccessLevel.HeaderText = "Access Level";
            this.ColAccessLevel.Name = "ColAccessLevel";
            this.ColAccessLevel.ReadOnly = true;
            this.ColAccessLevel.Width = 110;
            // 
            // ColTeam
            // 
            this.ColTeam.HeaderText = "Team";
            this.ColTeam.Name = "ColTeam";
            this.ColTeam.ReadOnly = true;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(207, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(182, 33);
            this.LabelHeader.TabIndex = 21;
            this.LabelHeader.Text = "Manage Users";
            // 
            // InputAccessLevel
            // 
            this.InputAccessLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAccessLevel.FormattingEnabled = true;
            this.InputAccessLevel.Items.AddRange(new object[] {
            "Player",
            "Coach",
            "Admin"});
            this.InputAccessLevel.Location = new System.Drawing.Point(109, 66);
            this.InputAccessLevel.Name = "InputAccessLevel";
            this.InputAccessLevel.Size = new System.Drawing.Size(121, 27);
            this.InputAccessLevel.TabIndex = 0;
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(409, 66);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(176, 27);
            this.InputName.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(356, 70);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(47, 18);
            this.LabelName.TabIndex = 44;
            this.LabelName.Text = "Name";
            // 
            // LabelAccessLevel
            // 
            this.LabelAccessLevel.AutoSize = true;
            this.LabelAccessLevel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccessLevel.Location = new System.Drawing.Point(12, 70);
            this.LabelAccessLevel.Name = "LabelAccessLevel";
            this.LabelAccessLevel.Size = new System.Drawing.Size(91, 18);
            this.LabelAccessLevel.TabIndex = 45;
            this.LabelAccessLevel.Text = "Access Level";
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 12);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 30);
            this.NavHome.TabIndex = 6;
            this.NavHome.Text = "Back";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // EventDelete
            // 
            this.EventDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDelete.Location = new System.Drawing.Point(496, 404);
            this.EventDelete.Name = "EventDelete";
            this.EventDelete.Size = new System.Drawing.Size(89, 30);
            this.EventDelete.TabIndex = 5;
            this.EventDelete.Text = "Delete User";
            this.EventDelete.UseVisualStyleBackColor = true;
            this.EventDelete.Click += new System.EventHandler(this.EventDelete_Click);
            // 
            // NavView
            // 
            this.NavView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavView.Location = new System.Drawing.Point(12, 404);
            this.NavView.Name = "NavView";
            this.NavView.Size = new System.Drawing.Size(89, 30);
            this.NavView.TabIndex = 4;
            this.NavView.Text = "View";
            this.NavView.UseVisualStyleBackColor = true;
            this.NavView.Click += new System.EventHandler(this.NavView_Click);
            // 
            // EventFilter
            // 
            this.EventFilter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventFilter.Location = new System.Drawing.Point(504, 30);
            this.EventFilter.Name = "EventFilter";
            this.EventFilter.Size = new System.Drawing.Size(81, 30);
            this.EventFilter.TabIndex = 2;
            this.EventFilter.Text = "Filter";
            this.EventFilter.UseVisualStyleBackColor = true;
            this.EventFilter.Click += new System.EventHandler(this.EventFilter_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 446);
            this.Controls.Add(this.EventFilter);
            this.Controls.Add(this.NavView);
            this.Controls.Add(this.EventDelete);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.LabelAccessLevel);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputAccessLevel);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.TableManageUsers);
            this.Name = "ManageUsers";
            this.Text = "ManageCurrentUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableManageUsers;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.ComboBox InputAccessLevel;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeam;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAccessLevel;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button EventDelete;
        private System.Windows.Forms.Button NavView;
        private System.Windows.Forms.Button EventFilter;
    }
}