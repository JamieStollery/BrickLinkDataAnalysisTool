namespace GUI.View
{
    partial class ItemView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fmsItemSearch = new GUI.View.FilterModeSelector();
            this.cbItemSearchType = new System.Windows.Forms.ComboBox();
            this.tbItemSearchValue = new System.Windows.Forms.TextBox();
            this.cbItemCondition = new System.Windows.Forms.ComboBox();
            this.clbItemTypes = new System.Windows.Forms.CheckedListBox();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.fmsItemCount = new GUI.View.FilterModeSelector();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(603, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbItemSearchType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbItemSearchValue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCondition, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clbItemTypes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvColors, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbItemCount, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 312);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // fmsItemSearch
            // 
            this.fmsItemSearch.AutoSize = true;
            this.fmsItemSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsItemSearch.Location = new System.Drawing.Point(3, 3);
            this.fmsItemSearch.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemSearch.Mode1Checked = false;
            this.fmsItemSearch.Mode1Text = "Strict";
            this.fmsItemSearch.Mode2Checked = true;
            this.fmsItemSearch.Mode2Text = "Loose";
            this.fmsItemSearch.Name = "fmsItemSearch";
            this.fmsItemSearch.Size = new System.Drawing.Size(236, 28);
            this.fmsItemSearch.TabIndex = 2;
            // 
            // cbItemSearchType
            // 
            this.cbItemSearchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemSearchType.FormattingEnabled = true;
            this.cbItemSearchType.Location = new System.Drawing.Point(3, 37);
            this.cbItemSearchType.Name = "cbItemSearchType";
            this.cbItemSearchType.Size = new System.Drawing.Size(236, 23);
            this.cbItemSearchType.TabIndex = 3;
            // 
            // tbItemSearchValue
            // 
            this.tbItemSearchValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbItemSearchValue.Location = new System.Drawing.Point(3, 66);
            this.tbItemSearchValue.Name = "tbItemSearchValue";
            this.tbItemSearchValue.Size = new System.Drawing.Size(236, 23);
            this.tbItemSearchValue.TabIndex = 4;
            // 
            // cbItemCondition
            // 
            this.cbItemCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemCondition.FormattingEnabled = true;
            this.cbItemCondition.Location = new System.Drawing.Point(3, 95);
            this.cbItemCondition.Name = "cbItemCondition";
            this.cbItemCondition.Size = new System.Drawing.Size(236, 23);
            this.cbItemCondition.TabIndex = 5;
            // 
            // clbItemTypes
            // 
            this.clbItemTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbItemTypes.FormattingEnabled = true;
            this.clbItemTypes.Location = new System.Drawing.Point(3, 124);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(236, 185);
            this.clbItemTypes.TabIndex = 6;
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.ColumnHeadersVisible = false;
            this.dgvColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColors.Location = new System.Drawing.Point(245, 124);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.Size = new System.Drawing.Size(236, 185);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.Text = "dataGridView1";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(726, 200);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.Text = "dataGridView1";
            // 
            // fmsItemCount
            // 
            this.fmsItemCount.AutoSize = true;
            this.fmsItemCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsItemCount.Location = new System.Drawing.Point(245, 3);
            this.fmsItemCount.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemCount.Mode1Checked = true;
            this.fmsItemCount.Mode1Text = "Min";
            this.fmsItemCount.Mode2Checked = false;
            this.fmsItemCount.Mode2Text = "Max";
            this.fmsItemCount.Name = "fmsItemCount";
            this.fmsItemCount.Size = new System.Drawing.Size(236, 28);
            this.fmsItemCount.TabIndex = 7;
            // 
            // tbItemCount
            // 
            this.tbItemCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbItemCount.Location = new System.Drawing.Point(245, 37);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(236, 23);
            this.tbItemCount.TabIndex = 8;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemView";
            this.Size = new System.Drawing.Size(726, 512);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FilterModeSelector fmsItemSearch;
        private System.Windows.Forms.ComboBox cbItemSearchType;
        private System.Windows.Forms.TextBox tbItemSearchValue;
        private System.Windows.Forms.ComboBox cbItemCondition;
        private System.Windows.Forms.CheckedListBox clbItemTypes;
        private System.Windows.Forms.DataGridView dgvColors;
        private FilterModeSelector fmsItemCount;
        private System.Windows.Forms.TextBox tbItemCount;
    }
}
