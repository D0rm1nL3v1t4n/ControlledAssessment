namespace VisualCSharp.Forms.Sub_home_Screens.Shared_sub_Screens
{
    partial class ViewMatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMatches));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblViewMatches = new System.Windows.Forms.Label();
            this.TableViewMatches = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOpponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditMatch = new System.Windows.Forms.Button();
            this.BtnAddResults = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblViewMatches
            // 
            this.lblViewMatches.AutoSize = true;
            this.lblViewMatches.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewMatches.Location = new System.Drawing.Point(228, 183);
            this.lblViewMatches.Name = "lblViewMatches";
            this.lblViewMatches.Size = new System.Drawing.Size(228, 42);
            this.lblViewMatches.TabIndex = 7;
            this.lblViewMatches.Text = "View Matches";
            // 
            // TableViewMatches
            // 
            this.TableViewMatches.AllowUserToAddRows = false;
            this.TableViewMatches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableViewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.TableViewMatches.Location = new System.Drawing.Point(12, 256);
            this.TableViewMatches.Name = "TableViewMatches";
            this.TableViewMatches.ReadOnly = true;
            this.TableViewMatches.RowHeadersVisible = false;
            this.TableViewMatches.RowHeadersWidth = 10;
            this.TableViewMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableViewMatches.ShowCellToolTips = false;
            this.TableViewMatches.Size = new System.Drawing.Size(660, 251);
            this.TableViewMatches.TabIndex = 14;
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
            // BtnEditMatch
            // 
            this.BtnEditMatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditMatch.Location = new System.Drawing.Point(591, 513);
            this.BtnEditMatch.Name = "BtnEditMatch";
            this.BtnEditMatch.Size = new System.Drawing.Size(81, 36);
            this.BtnEditMatch.TabIndex = 15;
            this.BtnEditMatch.Text = "Edit";
            this.BtnEditMatch.UseVisualStyleBackColor = true;
            this.BtnEditMatch.Click += new System.EventHandler(this.BtnEditMatch_Click);
            // 
            // BtnAddResults
            // 
            this.BtnAddResults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddResults.Location = new System.Drawing.Point(475, 513);
            this.BtnAddResults.Name = "BtnAddResults";
            this.BtnAddResults.Size = new System.Drawing.Size(110, 36);
            this.BtnAddResults.TabIndex = 16;
            this.BtnAddResults.Text = "Add Results";
            this.BtnAddResults.UseVisualStyleBackColor = true;
            this.BtnAddResults.Click += new System.EventHandler(this.BtnAddResults_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 513);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(81, 36);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ViewMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 566);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAddResults);
            this.Controls.Add(this.BtnEditMatch);
            this.Controls.Add(this.TableViewMatches);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblViewMatches);
            this.Name = "ViewMatches";
            this.Text = "View Matches";
            this.Load += new System.EventHandler(this.ViewMatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblViewMatches;
        private System.Windows.Forms.DataGridView TableViewMatches;
        private System.Windows.Forms.Button BtnEditMatch;
        private System.Windows.Forms.Button BtnAddResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatchType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostcode;
        private System.Windows.Forms.Button BtnBack;
    }
}