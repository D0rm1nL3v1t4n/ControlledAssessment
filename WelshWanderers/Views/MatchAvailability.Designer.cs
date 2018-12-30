namespace WelshWanderers
{
    partial class MatchAvailability
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
            this.TableMatchAvailability = new System.Windows.Forms.DataGridView();
            this.NavHome = new System.Windows.Forms.Button();
            this.EventSave = new System.Windows.Forms.Button();
            this.EventMatchDetails = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLeague = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOpponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailability = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchAvailability)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(186, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(218, 33);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "Match Availability";
            // 
            // TableMatchAvailability
            // 
            this.TableMatchAvailability.AllowUserToAddRows = false;
            this.TableMatchAvailability.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMatchAvailability.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableMatchAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMatchAvailability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColLeague,
            this.ColOpponent,
            this.ColDate,
            this.ColTime,
            this.ColAvailability});
            this.TableMatchAvailability.Location = new System.Drawing.Point(44, 81);
            this.TableMatchAvailability.MultiSelect = false;
            this.TableMatchAvailability.Name = "TableMatchAvailability";
            this.TableMatchAvailability.RowHeadersVisible = false;
            this.TableMatchAvailability.RowHeadersWidth = 10;
            this.TableMatchAvailability.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableMatchAvailability.ShowCellToolTips = false;
            this.TableMatchAvailability.Size = new System.Drawing.Size(503, 197);
            this.TableMatchAvailability.TabIndex = 17;
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(44, 284);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(89, 48);
            this.NavHome.TabIndex = 31;
            this.NavHome.Text = "Home";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // EventSave
            // 
            this.EventSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSave.Location = new System.Drawing.Point(458, 284);
            this.EventSave.Name = "EventSave";
            this.EventSave.Size = new System.Drawing.Size(89, 48);
            this.EventSave.TabIndex = 32;
            this.EventSave.Text = "Save";
            this.EventSave.UseVisualStyleBackColor = true;
            this.EventSave.Click += new System.EventHandler(this.EventSave_Click);
            // 
            // EventMatchDetails
            // 
            this.EventMatchDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventMatchDetails.Location = new System.Drawing.Point(363, 284);
            this.EventMatchDetails.Name = "EventMatchDetails";
            this.EventMatchDetails.Size = new System.Drawing.Size(89, 48);
            this.EventMatchDetails.TabIndex = 33;
            this.EventMatchDetails.Text = "Match Details";
            this.EventMatchDetails.UseVisualStyleBackColor = true;
            this.EventMatchDetails.Click += new System.EventHandler(this.EventMatchDetails_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            this.ColID.Width = 35;
            // 
            // ColLeague
            // 
            this.ColLeague.HeaderText = "League";
            this.ColLeague.Name = "ColLeague";
            this.ColLeague.ReadOnly = true;
            this.ColLeague.Width = 120;
            // 
            // ColOpponent
            // 
            this.ColOpponent.HeaderText = "Opponent";
            this.ColOpponent.Name = "ColOpponent";
            this.ColOpponent.ReadOnly = true;
            this.ColOpponent.Width = 110;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            this.ColDate.Width = 90;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            this.ColTime.Width = 80;
            // 
            // ColAvailability
            // 
            this.ColAvailability.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColAvailability.HeaderText = "Available";
            this.ColAvailability.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ColAvailability.Name = "ColAvailability";
            this.ColAvailability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MatchAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 355);
            this.Controls.Add(this.EventMatchDetails);
            this.Controls.Add(this.EventSave);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.TableMatchAvailability);
            this.Controls.Add(this.LabelHeader);
            this.Name = "MatchAvailability";
            this.Text = "MatchNotifications";
            this.Load += new System.EventHandler(this.MatchAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableMatchAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableMatchAvailability;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button EventSave;
        private System.Windows.Forms.Button EventMatchDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLeague;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColAvailability;
    }
}