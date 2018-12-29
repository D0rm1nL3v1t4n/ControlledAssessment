namespace WelshWanderers
{
    partial class MatchResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableMatchResults = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWelshWanderers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWanderersGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOpponentGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavBack = new System.Windows.Forms.Button();
            this.NavViewMatch = new System.Windows.Forms.Button();
            this.NavMatchDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(189, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(179, 33);
            this.LabelHeader.TabIndex = 8;
            this.LabelHeader.Text = "Match Results";
            // 
            // TableMatchResults
            // 
            this.TableMatchResults.AllowUserToAddRows = false;
            this.TableMatchResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMatchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableMatchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMatchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColTeam,
            this.ColWelshWanderers,
            this.ColWanderersGoals,
            this.ColOpponentGoals,
            this.ColAwayTeam});
            this.TableMatchResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TableMatchResults.Enabled = false;
            this.TableMatchResults.Location = new System.Drawing.Point(17, 100);
            this.TableMatchResults.Name = "TableMatchResults";
            this.TableMatchResults.RowHeadersVisible = false;
            this.TableMatchResults.RowHeadersWidth = 10;
            this.TableMatchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableMatchResults.ShowCellToolTips = false;
            this.TableMatchResults.Size = new System.Drawing.Size(523, 251);
            this.TableMatchResults.TabIndex = 26;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 40;
            // 
            // ColTeam
            // 
            this.ColTeam.HeaderText = "Team";
            this.ColTeam.Name = "ColTeam";
            // 
            // ColWelshWanderers
            // 
            this.ColWelshWanderers.HeaderText = "Welsh Wanderers";
            this.ColWelshWanderers.Name = "ColWelshWanderers";
            this.ColWelshWanderers.ReadOnly = true;
            this.ColWelshWanderers.Width = 150;
            // 
            // ColWanderersGoals
            // 
            this.ColWanderersGoals.HeaderText = "";
            this.ColWanderersGoals.Name = "ColWanderersGoals";
            this.ColWanderersGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColWanderersGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColWanderersGoals.Width = 50;
            // 
            // ColOpponentGoals
            // 
            this.ColOpponentGoals.HeaderText = "";
            this.ColOpponentGoals.Name = "ColOpponentGoals";
            this.ColOpponentGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColOpponentGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColOpponentGoals.Width = 50;
            // 
            // ColAwayTeam
            // 
            this.ColAwayTeam.HeaderText = "Opponent";
            this.ColAwayTeam.Name = "ColAwayTeam";
            this.ColAwayTeam.Width = 130;
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(17, 357);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(89, 48);
            this.NavBack.TabIndex = 31;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            this.NavBack.Click += new System.EventHandler(this.NavBack_Click);
            // 
            // NavViewMatch
            // 
            this.NavViewMatch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavViewMatch.Location = new System.Drawing.Point(451, 357);
            this.NavViewMatch.Name = "NavViewMatch";
            this.NavViewMatch.Size = new System.Drawing.Size(89, 48);
            this.NavViewMatch.TabIndex = 32;
            this.NavViewMatch.Text = "View Match";
            this.NavViewMatch.UseVisualStyleBackColor = true;
            this.NavViewMatch.Click += new System.EventHandler(this.NavViewMatch_Click);
            // 
            // NavMatchDetails
            // 
            this.NavMatchDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavMatchDetails.Location = new System.Drawing.Point(356, 357);
            this.NavMatchDetails.Name = "NavMatchDetails";
            this.NavMatchDetails.Size = new System.Drawing.Size(89, 48);
            this.NavMatchDetails.TabIndex = 33;
            this.NavMatchDetails.Text = "Match Details";
            this.NavMatchDetails.UseVisualStyleBackColor = true;
            this.NavMatchDetails.Click += new System.EventHandler(this.NavMatchDetails_Click);
            // 
            // MatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 439);
            this.Controls.Add(this.NavMatchDetails);
            this.Controls.Add(this.NavViewMatch);
            this.Controls.Add(this.NavBack);
            this.Controls.Add(this.TableMatchResults);
            this.Controls.Add(this.LabelHeader);
            this.Name = "MatchResults";
            this.Text = "ViewMatchResults";
            this.Load += new System.EventHandler(this.ViewMatchResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableMatchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWelshWanderers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWanderersGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponentGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAwayTeam;
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.Button NavViewMatch;
        private System.Windows.Forms.Button NavMatchDetails;
    }
}