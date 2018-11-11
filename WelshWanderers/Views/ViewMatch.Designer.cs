namespace WelshWanderers
{
    partial class ViewMatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.TableViewMatches = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOpponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavEdit = new System.Windows.Forms.Button();
            this.NavHome = new System.Windows.Forms.Button();
            this.NavAddResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(257, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(176, 33);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "View Matches";
            // 
            // TableViewMatches
            // 
            this.TableViewMatches.AllowUserToAddRows = false;
            this.TableViewMatches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableViewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TableViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColMatchType,
            this.ColOpponent,
            this.ColTeamType,
            this.ColDateAndTime,
            this.ColAddress,
            this.ColAddress2,
            this.ColPostcode});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableViewMatches.DefaultCellStyle = dataGridViewCellStyle6;
            this.TableViewMatches.Location = new System.Drawing.Point(15, 72);
            this.TableViewMatches.Name = "TableViewMatches";
            this.TableViewMatches.ReadOnly = true;
            this.TableViewMatches.RowHeadersVisible = false;
            this.TableViewMatches.RowHeadersWidth = 10;
            this.TableViewMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewMatches.ShowCellToolTips = false;
            this.TableViewMatches.Size = new System.Drawing.Size(660, 312);
            this.TableViewMatches.TabIndex = 15;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 30;
            // 
            // ColMatchType
            // 
            this.ColMatchType.HeaderText = "Match Type";
            this.ColMatchType.Name = "ColMatchType";
            this.ColMatchType.ReadOnly = true;
            this.ColMatchType.Width = 85;
            // 
            // ColOpponent
            // 
            this.ColOpponent.HeaderText = "Opponent";
            this.ColOpponent.Name = "ColOpponent";
            this.ColOpponent.ReadOnly = true;
            this.ColOpponent.Width = 80;
            // 
            // ColTeamType
            // 
            this.ColTeamType.HeaderText = "Team Type";
            this.ColTeamType.Name = "ColTeamType";
            this.ColTeamType.ReadOnly = true;
            this.ColTeamType.Width = 70;
            // 
            // ColDateAndTime
            // 
            this.ColDateAndTime.HeaderText = "Date & Time";
            this.ColDateAndTime.Name = "ColDateAndTime";
            this.ColDateAndTime.ReadOnly = true;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            this.ColAddress.Width = 112;
            // 
            // ColAddress2
            // 
            this.ColAddress2.HeaderText = " ";
            this.ColAddress2.Name = "ColAddress2";
            this.ColAddress2.ReadOnly = true;
            this.ColAddress2.Width = 112;
            // 
            // ColPostcode
            // 
            this.ColPostcode.HeaderText = "Postcode";
            this.ColPostcode.Name = "ColPostcode";
            this.ColPostcode.ReadOnly = true;
            this.ColPostcode.Width = 68;
            // 
            // NavEdit
            // 
            this.NavEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavEdit.Location = new System.Drawing.Point(586, 390);
            this.NavEdit.Name = "NavEdit";
            this.NavEdit.Size = new System.Drawing.Size(89, 48);
            this.NavEdit.TabIndex = 32;
            this.NavEdit.Text = "Edit";
            this.NavEdit.UseVisualStyleBackColor = true;
            this.NavEdit.Click += new System.EventHandler(this.NavEdit_Click);
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 390);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 48);
            this.NavHome.TabIndex = 31;
            this.NavHome.Text = "Home";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // NavAddResult
            // 
            this.NavAddResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavAddResult.Location = new System.Drawing.Point(491, 390);
            this.NavAddResult.Name = "NavAddResult";
            this.NavAddResult.Size = new System.Drawing.Size(89, 48);
            this.NavAddResult.TabIndex = 33;
            this.NavAddResult.Text = "Add Result";
            this.NavAddResult.UseVisualStyleBackColor = true;
            this.NavAddResult.Click += new System.EventHandler(this.NavAddResult_Click);
            // 
            // ViewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 453);
            this.Controls.Add(this.NavAddResult);
            this.Controls.Add(this.NavEdit);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.TableViewMatches);
            this.Controls.Add(this.LabelHeader);
            this.Name = "ViewMatch";
            this.Text = "ViewMatch";
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableViewMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatchType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostcode;
        private System.Windows.Forms.Button NavEdit;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button NavAddResult;
    }
}