namespace WelshWanderers.Views
{
    partial class Restore
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
            this.TableBackupInfo = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavHome = new System.Windows.Forms.Button();
            this.EventRestore = new System.Windows.Forms.Button();
            this.LabelBackupRecent = new System.Windows.Forms.Label();
            this.InputOrder = new System.Windows.Forms.CheckBox();
            this.InputSortBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableBackupInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(80, 15);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(106, 33);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Restore";
            // 
            // TableBackupInfo
            // 
            this.TableBackupInfo.AllowUserToAddRows = false;
            this.TableBackupInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableBackupInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableBackupInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableBackupInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDateTime,
            this.ColType,
            this.ColNumber});
            this.TableBackupInfo.Location = new System.Drawing.Point(12, 148);
            this.TableBackupInfo.MultiSelect = false;
            this.TableBackupInfo.Name = "TableBackupInfo";
            this.TableBackupInfo.ReadOnly = true;
            this.TableBackupInfo.RowHeadersVisible = false;
            this.TableBackupInfo.RowHeadersWidth = 10;
            this.TableBackupInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableBackupInfo.ShowCellToolTips = false;
            this.TableBackupInfo.Size = new System.Drawing.Size(243, 255);
            this.TableBackupInfo.TabIndex = 2;
            // 
            // ColID
            // 
            this.ColID.HeaderText = " ";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColID.Visible = false;
            this.ColID.Width = 35;
            // 
            // ColDateTime
            // 
            this.ColDateTime.HeaderText = "Date Time";
            this.ColDateTime.Name = "ColDateTime";
            this.ColDateTime.ReadOnly = true;
            this.ColDateTime.Width = 140;
            // 
            // ColType
            // 
            this.ColType.HeaderText = "Type";
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            // 
            // ColNumber
            // 
            this.ColNumber.HeaderText = "Number";
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.ReadOnly = true;
            this.ColNumber.Visible = false;
            // 
            // NavHome
            // 
            this.NavHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavHome.Location = new System.Drawing.Point(12, 12);
            this.NavHome.Name = "NavHome";
            this.NavHome.Size = new System.Drawing.Size(60, 30);
            this.NavHome.TabIndex = 4;
            this.NavHome.Text = "Back";
            this.NavHome.UseVisualStyleBackColor = true;
            this.NavHome.Click += new System.EventHandler(this.NavHome_Click);
            // 
            // EventRestore
            // 
            this.EventRestore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventRestore.Location = new System.Drawing.Point(12, 409);
            this.EventRestore.Name = "EventRestore";
            this.EventRestore.Size = new System.Drawing.Size(240, 30);
            this.EventRestore.TabIndex = 3;
            this.EventRestore.Text = "Restore selected backup";
            this.EventRestore.UseVisualStyleBackColor = true;
            this.EventRestore.Click += new System.EventHandler(this.EventRestore_Click);
            // 
            // LabelBackupRecent
            // 
            this.LabelBackupRecent.AutoSize = true;
            this.LabelBackupRecent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBackupRecent.Location = new System.Drawing.Point(62, 70);
            this.LabelBackupRecent.Name = "LabelBackupRecent";
            this.LabelBackupRecent.Size = new System.Drawing.Size(142, 18);
            this.LabelBackupRecent.TabIndex = 33;
            this.LabelBackupRecent.Text = "Most recent backup:";
            this.LabelBackupRecent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InputOrder
            // 
            this.InputOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.InputOrder.AutoSize = true;
            this.InputOrder.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOrder.Location = new System.Drawing.Point(197, 114);
            this.InputOrder.Name = "InputOrder";
            this.InputOrder.Size = new System.Drawing.Size(55, 28);
            this.InputOrder.TabIndex = 1;
            this.InputOrder.Text = "Order";
            this.InputOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InputOrder.UseVisualStyleBackColor = true;
            this.InputOrder.CheckedChanged += new System.EventHandler(this.InputOrder_CheckedChanged);
            // 
            // InputSortBy
            // 
            this.InputSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputSortBy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSortBy.FormattingEnabled = true;
            this.InputSortBy.Items.AddRange(new object[] {
            "All",
            "Week",
            "Month",
            "Year"});
            this.InputSortBy.Location = new System.Drawing.Point(12, 116);
            this.InputSortBy.Name = "InputSortBy";
            this.InputSortBy.Size = new System.Drawing.Size(121, 26);
            this.InputSortBy.TabIndex = 0;
            this.InputSortBy.SelectedIndexChanged += new System.EventHandler(this.InputSortBy_SelectedIndexChanged);
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 451);
            this.Controls.Add(this.InputSortBy);
            this.Controls.Add(this.InputOrder);
            this.Controls.Add(this.LabelBackupRecent);
            this.Controls.Add(this.EventRestore);
            this.Controls.Add(this.NavHome);
            this.Controls.Add(this.TableBackupInfo);
            this.Controls.Add(this.LabelHeader);
            this.Name = "Restore";
            this.Text = "Restore";
            this.Load += new System.EventHandler(this.Restore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableBackupInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridView TableBackupInfo;
        private System.Windows.Forms.Button NavHome;
        private System.Windows.Forms.Button EventRestore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.Label LabelBackupRecent;
        private System.Windows.Forms.CheckBox InputOrder;
        private System.Windows.Forms.ComboBox InputSortBy;
    }
}