namespace WelshWanderers
{
    partial class LeagueStats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableLeagueStats = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelLeague = new System.Windows.Forms.Label();
            this.InputLeague = new System.Windows.Forms.ComboBox();
            this.NavHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableLeagueStats)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(155, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(167, 33);
            this.LabelHeader.TabIndex = 8;
            this.LabelHeader.Text = "League Stats";
            // 
            // TableLeagueStats
            // 
            this.TableLeagueStats.AllowUserToAddRows = false;
            this.TableLeagueStats.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableLeagueStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableLeagueStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLeagueStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColPlayed,
            this.ColGoals,
            this.ColMajors});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableLeagueStats.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableLeagueStats.Location = new System.Drawing.Point(56, 104);
            this.TableLeagueStats.Name = "TableLeagueStats";
            this.TableLeagueStats.ReadOnly = true;
            this.TableLeagueStats.RowHeadersVisible = false;
            this.TableLeagueStats.RowHeadersWidth = 10;
            this.TableLeagueStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableLeagueStats.ShowCellToolTips = false;
            this.TableLeagueStats.Size = new System.Drawing.Size(369, 334);
            this.TableLeagueStats.TabIndex = 16;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 30;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 85;
            // 
            // ColPlayed
            // 
            this.ColPlayed.HeaderText = "Played";
            this.ColPlayed.Name = "ColPlayed";
            this.ColPlayed.ReadOnly = true;
            this.ColPlayed.Width = 80;
            // 
            // ColGoals
            // 
            this.ColGoals.HeaderText = "Goals";
            this.ColGoals.Name = "ColGoals";
            this.ColGoals.ReadOnly = true;
            this.ColGoals.Width = 70;
            // 
            // ColMajors
            // 
            this.ColMajors.HeaderText = "Majors";
            this.ColMajors.Name = "ColMajors";
            this.ColMajors.ReadOnly = true;
            // 
            // LabelLeague
            // 
            this.LabelLeague.AutoSize = true;
            this.LabelLeague.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLeague.Location = new System.Drawing.Point(52, 74);
            this.LabelLeague.Name = "LabelLeague";
            this.LabelLeague.Size = new System.Drawing.Size(59, 19);
            this.LabelLeague.TabIndex = 18;
            this.LabelLeague.Text = "League";
            // 
            // InputLeague
            // 
            this.InputLeague.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLeague.FormattingEnabled = true;
            this.InputLeague.Location = new System.Drawing.Point(117, 71);
            this.InputLeague.Name = "InputLeague";
            this.InputLeague.Size = new System.Drawing.Size(108, 27);
            this.InputLeague.TabIndex = 17;
            this.InputLeague.SelectedIndexChanged += new System.EventHandler(this.InputLeague_SelectedIndexChanged);
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(56, 444);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 48);
            this.NavHome.TabIndex = 29;
            this.NavHome.Text = "Home";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // LeagueStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 506);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.LabelLeague);
            this.Controls.Add(this.InputLeague);
            this.Controls.Add(this.TableLeagueStats);
            this.Controls.Add(this.LabelHeader);
            this.Name = "LeagueStats";
            this.Text = "PlayerStats";
            this.Load += new System.EventHandler(this.LeagueStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableLeagueStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableLeagueStats;
        private System.Windows.Forms.Label LabelLeague;
        private System.Windows.Forms.ComboBox InputLeague;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMajors;
    }
}