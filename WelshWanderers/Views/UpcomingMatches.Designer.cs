namespace WelshWanderers
{
    partial class UpcomingMatches
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
            this.TableViewMatches = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLeague = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOpponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavEditMatch = new System.Windows.Forms.Button();
            this.NavHome = new System.Windows.Forms.Button();
            this.NavViewResult = new System.Windows.Forms.Button();
            this.InputFilter = new System.Windows.Forms.ComboBox();
            this.NavAddResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(263, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(176, 33);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "View Matches";
            // 
            // TableViewMatches
            // 
            this.TableViewMatches.AllowUserToAddRows = false;
            this.TableViewMatches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableViewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColLeague,
            this.ColOpponent,
            this.ColDate,
            this.ColTime,
            this.ColAddress,
            this.ColAddress2,
            this.ColPostcode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableViewMatches.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableViewMatches.Location = new System.Drawing.Point(16, 104);
            this.TableViewMatches.Name = "TableViewMatches";
            this.TableViewMatches.ReadOnly = true;
            this.TableViewMatches.RowHeadersVisible = false;
            this.TableViewMatches.RowHeadersWidth = 10;
            this.TableViewMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewMatches.ShowCellToolTips = false;
            this.TableViewMatches.Size = new System.Drawing.Size(671, 312);
            this.TableViewMatches.TabIndex = 15;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 30;
            // 
            // ColLeague
            // 
            this.ColLeague.HeaderText = "League";
            this.ColLeague.Name = "ColLeague";
            this.ColLeague.ReadOnly = true;
            this.ColLeague.Width = 105;
            // 
            // ColOpponent
            // 
            this.ColOpponent.HeaderText = "Opponent";
            this.ColOpponent.Name = "ColOpponent";
            this.ColOpponent.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            this.ColDate.Width = 80;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            this.ColTime.Width = 60;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            this.ColAddress.Width = 122;
            // 
            // ColAddress2
            // 
            this.ColAddress2.HeaderText = " ";
            this.ColAddress2.Name = "ColAddress2";
            this.ColAddress2.ReadOnly = true;
            this.ColAddress2.Width = 122;
            // 
            // ColPostcode
            // 
            this.ColPostcode.HeaderText = "Postcode";
            this.ColPostcode.Name = "ColPostcode";
            this.ColPostcode.ReadOnly = true;
            this.ColPostcode.Width = 78;
            // 
            // NavEditMatch
            // 
            this.NavEditMatch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavEditMatch.Location = new System.Drawing.Point(598, 422);
            this.NavEditMatch.Name = "NavEditMatch";
            this.NavEditMatch.Size = new System.Drawing.Size(89, 48);
            this.NavEditMatch.TabIndex = 32;
            this.NavEditMatch.Text = "Edit";
            this.NavEditMatch.UseVisualStyleBackColor = true;
            this.NavEditMatch.Click += new System.EventHandler(this.NavEdit_Click);
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(16, 422);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 48);
            this.NavHome.TabIndex = 31;
            this.NavHome.Text = "Home";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // NavViewResult
            // 
            this.NavViewResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavViewResult.Location = new System.Drawing.Point(354, 422);
            this.NavViewResult.Name = "NavViewResult";
            this.NavViewResult.Size = new System.Drawing.Size(89, 48);
            this.NavViewResult.TabIndex = 34;
            this.NavViewResult.Text = "View Result";
            this.NavViewResult.UseVisualStyleBackColor = true;
            this.NavViewResult.Click += new System.EventHandler(this.NavViewResult_Click);
            // 
            // InputFilter
            // 
            this.InputFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFilter.FormattingEnabled = true;
            this.InputFilter.Items.AddRange(new object[] {
            "All",
            "Upcoming",
            "Past"});
            this.InputFilter.Location = new System.Drawing.Point(16, 71);
            this.InputFilter.Name = "InputFilter";
            this.InputFilter.Size = new System.Drawing.Size(170, 27);
            this.InputFilter.TabIndex = 43;
            this.InputFilter.SelectedIndexChanged += new System.EventHandler(this.InputFilter_SelectedIndexChanged);
            // 
            // NavAddResult
            // 
            this.NavAddResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavAddResult.Location = new System.Drawing.Point(259, 422);
            this.NavAddResult.Name = "NavAddResult";
            this.NavAddResult.Size = new System.Drawing.Size(89, 48);
            this.NavAddResult.TabIndex = 44;
            this.NavAddResult.Text = "Add Result";
            this.NavAddResult.UseVisualStyleBackColor = true;
            this.NavAddResult.Click += new System.EventHandler(this.NavAddResult_Click);
            // 
            // UpcomingMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.NavAddResult);
            this.Controls.Add(this.InputFilter);
            this.Controls.Add(this.NavViewResult);
            this.Controls.Add(this.NavEditMatch);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.TableViewMatches);
            this.Controls.Add(this.LabelHeader);
            this.Name = "UpcomingMatches";
            this.Text = "ViewMatch";
            this.Load += new System.EventHandler(this.ViewMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableViewMatches;
        private System.Windows.Forms.Button NavEditMatch;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button NavViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLeague;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostcode;
        private System.Windows.Forms.ComboBox InputFilter;
        private System.Windows.Forms.Button NavAddResult;
    }
}