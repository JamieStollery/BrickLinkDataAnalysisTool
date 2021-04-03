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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.fmsItemSearch = new GUI.View.FilterModeSelector();
            this.cbItemSearchType = new System.Windows.Forms.ComboBox();
            this.tbItemSearchValue = new System.Windows.Forms.TextBox();
            this.cbItemCondition = new System.Windows.Forms.ComboBox();
            this.clbItemTypes = new System.Windows.Forms.CheckedListBox();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.fmsItemCount = new GUI.View.FilterModeSelector();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHideFilters = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbItemSearchControls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbItemCountControls = new System.Windows.Forms.GroupBox();
            this.gbItemConditionControls = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbItemTypeControls = new System.Windows.Forms.GroupBox();
            this.gbItemColorControls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbItemSearchControls.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbItemCountControls.SuspendLayout();
            this.gbItemConditionControls.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbItemTypeControls.SuspendLayout();
            this.gbItemColorControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Silver;
            this.btnBack.Location = new System.Drawing.Point(711, 231);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
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
            this.dgvItems.Size = new System.Drawing.Size(834, 374);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.Text = "dataGridView1";
            // 
            // fmsItemSearch
            // 
            this.fmsItemSearch.AutoSize = true;
            this.fmsItemSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.fmsItemSearch.Location = new System.Drawing.Point(3, 19);
            this.fmsItemSearch.MinimumSize = new System.Drawing.Size(114, 27);
            this.fmsItemSearch.Mode1Checked = false;
            this.fmsItemSearch.Mode1Text = "Strict";
            this.fmsItemSearch.Mode2Checked = true;
            this.fmsItemSearch.Mode2Text = "Loose";
            this.fmsItemSearch.Name = "fmsItemSearch";
            this.fmsItemSearch.Size = new System.Drawing.Size(299, 29);
            this.fmsItemSearch.TabIndex = 2;
            // 
            // cbItemSearchType
            // 
            this.cbItemSearchType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemSearchType.FormattingEnabled = true;
            this.cbItemSearchType.Location = new System.Drawing.Point(3, 3);
            this.cbItemSearchType.Name = "cbItemSearchType";
            this.cbItemSearchType.Size = new System.Drawing.Size(293, 24);
            this.cbItemSearchType.TabIndex = 3;
            // 
            // tbItemSearchValue
            // 
            this.tbItemSearchValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbItemSearchValue.Location = new System.Drawing.Point(3, 33);
            this.tbItemSearchValue.Name = "tbItemSearchValue";
            this.tbItemSearchValue.Size = new System.Drawing.Size(293, 23);
            this.tbItemSearchValue.TabIndex = 4;
            // 
            // cbItemCondition
            // 
            this.cbItemCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCondition.FormattingEnabled = true;
            this.cbItemCondition.Location = new System.Drawing.Point(3, 19);
            this.cbItemCondition.Name = "cbItemCondition";
            this.cbItemCondition.Size = new System.Drawing.Size(299, 24);
            this.cbItemCondition.TabIndex = 5;
            // 
            // clbItemTypes
            // 
            this.clbItemTypes.CheckOnClick = true;
            this.clbItemTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbItemTypes.FormattingEnabled = true;
            this.clbItemTypes.Location = new System.Drawing.Point(3, 19);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(150, 233);
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
            this.dgvColors.Location = new System.Drawing.Point(3, 19);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.Size = new System.Drawing.Size(150, 233);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.Text = "dataGridView1";
            // 
            // fmsItemCount
            // 
            this.fmsItemCount.AutoSize = true;
            this.fmsItemCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.fmsItemCount.Location = new System.Drawing.Point(3, 19);
            this.fmsItemCount.MinimumSize = new System.Drawing.Size(114, 27);
            this.fmsItemCount.Mode1Checked = true;
            this.fmsItemCount.Mode1Text = "Min";
            this.fmsItemCount.Mode2Checked = false;
            this.fmsItemCount.Mode2Text = "Max";
            this.fmsItemCount.Name = "fmsItemCount";
            this.fmsItemCount.Size = new System.Drawing.Size(296, 29);
            this.fmsItemCount.TabIndex = 7;
            // 
            // tbItemCount
            // 
            this.tbItemCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbItemCount.Location = new System.Drawing.Point(3, 48);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(296, 23);
            this.tbItemCount.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvItems);
            this.splitContainer1.Panel1.Controls.Add(this.btnHideFilters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.btnBack);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(834, 664);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // btnHideFilters
            // 
            this.btnHideFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHideFilters.FlatAppearance.BorderSize = 0;
            this.btnHideFilters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnHideFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideFilters.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHideFilters.ForeColor = System.Drawing.Color.Silver;
            this.btnHideFilters.Location = new System.Drawing.Point(0, 374);
            this.btnHideFilters.Name = "btnHideFilters";
            this.btnHideFilters.Size = new System.Drawing.Size(834, 26);
            this.btnHideFilters.TabIndex = 7;
            this.btnHideFilters.Text = "v";
            this.btnHideFilters.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gbItemSearchControls);
            this.flowLayoutPanel2.Controls.Add(this.gbItemCountControls);
            this.flowLayoutPanel2.Controls.Add(this.gbItemConditionControls);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(324, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(311, 260);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // gbItemSearchControls
            // 
            this.gbItemSearchControls.Controls.Add(this.tableLayoutPanel2);
            this.gbItemSearchControls.Controls.Add(this.fmsItemSearch);
            this.gbItemSearchControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemSearchControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemSearchControls.Location = new System.Drawing.Point(3, 3);
            this.gbItemSearchControls.Name = "gbItemSearchControls";
            this.gbItemSearchControls.Size = new System.Drawing.Size(305, 114);
            this.gbItemSearchControls.TabIndex = 3;
            this.gbItemSearchControls.TabStop = false;
            this.gbItemSearchControls.Text = "Item Search";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbItemSearchValue, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbItemSearchType, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 61);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // gbItemCountControls
            // 
            this.gbItemCountControls.Controls.Add(this.tbItemCount);
            this.gbItemCountControls.Controls.Add(this.fmsItemCount);
            this.gbItemCountControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemCountControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemCountControls.Location = new System.Drawing.Point(3, 123);
            this.gbItemCountControls.Name = "gbItemCountControls";
            this.gbItemCountControls.Size = new System.Drawing.Size(302, 77);
            this.gbItemCountControls.TabIndex = 4;
            this.gbItemCountControls.TabStop = false;
            this.gbItemCountControls.Text = "Item Count";
            // 
            // gbItemConditionControls
            // 
            this.gbItemConditionControls.Controls.Add(this.cbItemCondition);
            this.gbItemConditionControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemConditionControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemConditionControls.Location = new System.Drawing.Point(3, 206);
            this.gbItemConditionControls.Name = "gbItemConditionControls";
            this.gbItemConditionControls.Size = new System.Drawing.Size(305, 52);
            this.gbItemConditionControls.TabIndex = 5;
            this.gbItemConditionControls.TabStop = false;
            this.gbItemConditionControls.Text = "Item Condition";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbItemTypeControls);
            this.flowLayoutPanel1.Controls.Add(this.gbItemColorControls);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 260);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // gbItemTypeControls
            // 
            this.gbItemTypeControls.Controls.Add(this.clbItemTypes);
            this.gbItemTypeControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemTypeControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemTypeControls.Location = new System.Drawing.Point(3, 3);
            this.gbItemTypeControls.Name = "gbItemTypeControls";
            this.gbItemTypeControls.Size = new System.Drawing.Size(156, 255);
            this.gbItemTypeControls.TabIndex = 0;
            this.gbItemTypeControls.TabStop = false;
            this.gbItemTypeControls.Text = "Item Type";
            // 
            // gbItemColorControls
            // 
            this.gbItemColorControls.Controls.Add(this.dgvColors);
            this.gbItemColorControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemColorControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemColorControls.Location = new System.Drawing.Point(165, 3);
            this.gbItemColorControls.Name = "gbItemColorControls";
            this.gbItemColorControls.Size = new System.Drawing.Size(156, 255);
            this.gbItemColorControls.TabIndex = 1;
            this.gbItemColorControls.TabStop = false;
            this.gbItemColorControls.Text = "Item Color";
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "ItemView";
            this.Size = new System.Drawing.Size(834, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gbItemSearchControls.ResumeLayout(false);
            this.gbItemSearchControls.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbItemCountControls.ResumeLayout(false);
            this.gbItemCountControls.PerformLayout();
            this.gbItemConditionControls.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbItemTypeControls.ResumeLayout(false);
            this.gbItemColorControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnBack;
        private FilterModeSelector fmsItemSearch;
        private System.Windows.Forms.ComboBox cbItemSearchType;
        private System.Windows.Forms.TextBox tbItemSearchValue;
        private System.Windows.Forms.ComboBox cbItemCondition;
        private System.Windows.Forms.CheckedListBox clbItemTypes;
        private System.Windows.Forms.DataGridView dgvColors;
        private FilterModeSelector fmsItemCount;
        private System.Windows.Forms.TextBox tbItemCount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbItemTypeControls;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox gbItemColorControls;
        private System.Windows.Forms.GroupBox gbItemSearchControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbItemCountControls;
        private System.Windows.Forms.GroupBox gbItemConditionControls;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnHideFilters;
    }
}
