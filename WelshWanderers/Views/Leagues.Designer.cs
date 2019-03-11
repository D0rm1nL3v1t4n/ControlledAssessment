namespace WelshWanderers
{
    partial class ManageLeagues
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableViewLeagues = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavHome = new System.Windows.Forms.Button();
            this.EventNavCreate = new System.Windows.Forms.Button();
            this.EventNavEdit = new System.Windows.Forms.Button();
            this.EventDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewLeagues)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(135, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(112, 33);
            this.LabelHeader.TabIndex = 18;
            this.LabelHeader.Text = "Leagues";
            // 
            // TableViewLeagues
            // 
            this.TableViewLeagues.AllowUserToAddRows = false;
            this.TableViewLeagues.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableViewLeagues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableViewLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewLeagues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColTeam});
            this.TableViewLeagues.Location = new System.Drawing.Point(12, 64);
            this.TableViewLeagues.Name = "TableViewLeagues";
            this.TableViewLeagues.ReadOnly = true;
            this.TableViewLeagues.RowHeadersVisible = false;
            this.TableViewLeagues.RowHeadersWidth = 10;
            this.TableViewLeagues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewLeagues.ShowCellToolTips = false;
            this.TableViewLeagues.Size = new System.Drawing.Size(263, 244);
            this.TableViewLeagues.TabIndex = 0;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 40;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 140;
            // 
            // ColTeam
            // 
            this.ColTeam.HeaderText = "Team";
            this.ColTeam.Name = "ColTeam";
            this.ColTeam.ReadOnly = true;
            this.ColTeam.Width = 80;
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 12);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(64, 30);
            this.NavHome.TabIndex = 4;
            this.NavHome.Text = "Back";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // EventNavCreate
            // 
            this.EventNavCreate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavCreate.Location = new System.Drawing.Point(281, 64);
            this.EventNavCreate.Name = "EventNavCreate";
            this.EventNavCreate.Size = new System.Drawing.Size(89, 32);
            this.EventNavCreate.TabIndex = 1;
            this.EventNavCreate.Text = "Create";
            this.EventNavCreate.UseVisualStyleBackColor = true;
            this.EventNavCreate.Click += new System.EventHandler(this.EventNavCreate_Click);
            // 
            // EventNavEdit
            // 
            this.EventNavEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNavEdit.Location = new System.Drawing.Point(281, 102);
            this.EventNavEdit.Name = "EventNavEdit";
            this.EventNavEdit.Size = new System.Drawing.Size(89, 32);
            this.EventNavEdit.TabIndex = 2;
            this.EventNavEdit.Text = "Edit";
            this.EventNavEdit.UseVisualStyleBackColor = true;
            this.EventNavEdit.Click += new System.EventHandler(this.EventNavEdit_Click);
            // 
            // EventDelete
            // 
            this.EventDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDelete.Location = new System.Drawing.Point(281, 276);
            this.EventDelete.Name = "EventDelete";
            this.EventDelete.Size = new System.Drawing.Size(89, 32);
            this.EventDelete.TabIndex = 3;
            this.EventDelete.Text = "Delete";
            this.EventDelete.UseVisualStyleBackColor = true;
            this.EventDelete.Click += new System.EventHandler(this.EventDelete_Click);
            // 
            // ManageLeagues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 320);
            this.Controls.Add(this.EventDelete);
            this.Controls.Add(this.EventNavEdit);
            this.Controls.Add(this.EventNavCreate);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.TableViewLeagues);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ManageLeagues";
            this.Text = "ManageLeagues";
            this.Load += new System.EventHandler(this.ManageLeagues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableViewLeagues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableViewLeagues;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button EventNavCreate;
        private System.Windows.Forms.Button EventNavEdit;
        private System.Windows.Forms.Button EventDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeam;
    }
}