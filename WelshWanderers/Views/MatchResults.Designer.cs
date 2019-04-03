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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableMatchResults = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWelshWanderers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWanderersGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOpponentGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavBack = new System.Windows.Forms.Button();
            this.NavViewMatch = new System.Windows.Forms.Button();
            this.NavMatchDetails = new System.Windows.Forms.Button();
            this.InputFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(124, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(179, 33);
            this.LabelHeader.TabIndex = 8;
            this.LabelHeader.Text = "Match Results";
            // 
            // TableMatchResults
            // 
            this.TableMatchResults.AllowUserToAddRows = false;
            this.TableMatchResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMatchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableMatchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMatchResults.ColumnHeadersVisible = false;
            this.TableMatchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColWelshWanderers,
            this.ColWanderersGoals,
            this.ColOpponentGoals,
            this.ColAwayTeam,
            this.ColDate});
            this.TableMatchResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TableMatchResults.Location = new System.Drawing.Point(12, 96);
            this.TableMatchResults.Name = "TableMatchResults";
            this.TableMatchResults.ReadOnly = true;
            this.TableMatchResults.RowHeadersVisible = false;
            this.TableMatchResults.RowHeadersWidth = 10;
            this.TableMatchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableMatchResults.ShowCellToolTips = false;
            this.TableMatchResults.Size = new System.Drawing.Size(403, 250);
            this.TableMatchResults.TabIndex = 1;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 40;
            // 
            // ColWelshWanderers
            // 
            this.ColWelshWanderers.HeaderText = "";
            this.ColWelshWanderers.Name = "ColWelshWanderers";
            this.ColWelshWanderers.ReadOnly = true;
            this.ColWelshWanderers.Width = 120;
            // 
            // ColWanderersGoals
            // 
            this.ColWanderersGoals.HeaderText = "";
            this.ColWanderersGoals.Name = "ColWanderersGoals";
            this.ColWanderersGoals.ReadOnly = true;
            this.ColWanderersGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColWanderersGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColWanderersGoals.Width = 30;
            // 
            // ColOpponentGoals
            // 
            this.ColOpponentGoals.HeaderText = "";
            this.ColOpponentGoals.Name = "ColOpponentGoals";
            this.ColOpponentGoals.ReadOnly = true;
            this.ColOpponentGoals.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColOpponentGoals.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColOpponentGoals.Width = 30;
            // 
            // ColAwayTeam
            // 
            this.ColAwayTeam.HeaderText = "";
            this.ColAwayTeam.Name = "ColAwayTeam";
            this.ColAwayTeam.ReadOnly = true;
            this.ColAwayTeam.Width = 120;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // NavBack
            // 
            this.NavBack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBack.Location = new System.Drawing.Point(12, 12);
            this.NavBack.Name = "NavBack";
            this.NavBack.Size = new System.Drawing.Size(80, 30);
            this.NavBack.TabIndex = 4;
            this.NavBack.Text = "Back";
            this.NavBack.UseVisualStyleBackColor = true;
            this.NavBack.Click += new System.EventHandler(this.NavBack_Click);
            // 
            // NavViewMatch
            // 
            this.NavViewMatch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavViewMatch.Location = new System.Drawing.Point(12, 352);
            this.NavViewMatch.Name = "NavViewMatch";
            this.NavViewMatch.Size = new System.Drawing.Size(119, 30);
            this.NavViewMatch.TabIndex = 2;
            this.NavViewMatch.Text = "View Result";
            this.NavViewMatch.UseVisualStyleBackColor = true;
            this.NavViewMatch.Click += new System.EventHandler(this.NavViewMatch_Click);
            // 
            // NavMatchDetails
            // 
            this.NavMatchDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavMatchDetails.Location = new System.Drawing.Point(296, 352);
            this.NavMatchDetails.Name = "NavMatchDetails";
            this.NavMatchDetails.Size = new System.Drawing.Size(119, 30);
            this.NavMatchDetails.TabIndex = 3;
            this.NavMatchDetails.Text = "Match Details";
            this.NavMatchDetails.UseVisualStyleBackColor = true;
            this.NavMatchDetails.Click += new System.EventHandler(this.NavMatchDetails_Click);
            // 
            // InputFilter
            // 
            this.InputFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFilter.FormattingEnabled = true;
            this.InputFilter.Items.AddRange(new object[] {
            "All",
            "Junior",
            "Men",
            "Women"});
            this.InputFilter.Location = new System.Drawing.Point(12, 63);
            this.InputFilter.Name = "InputFilter";
            this.InputFilter.Size = new System.Drawing.Size(170, 27);
            this.InputFilter.TabIndex = 0;
            this.InputFilter.SelectedIndexChanged += new System.EventHandler(this.InputFilter_SelectedIndexChanged);
            // 
            // MatchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 394);
            this.Controls.Add(this.InputFilter);
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
        private System.Windows.Forms.Button NavBack;
        private System.Windows.Forms.Button NavViewMatch;
        private System.Windows.Forms.Button NavMatchDetails;
        private System.Windows.Forms.ComboBox InputFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWelshWanderers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWanderersGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponentGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAwayTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
    }
}