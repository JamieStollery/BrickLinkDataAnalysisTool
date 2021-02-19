namespace GUI.View
{
    partial class OrderView
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.clbItemTypes = new System.Windows.Forms.CheckedListBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.cbItemCondition = new System.Windows.Forms.ComboBox();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.cbItemCountType = new System.Windows.Forms.ComboBox();
            this.clbOrderStatuses = new System.Windows.Forms.CheckedListBox();
            this.cbOrderSearchType = new System.Windows.Forms.ComboBox();
            this.tbOrderSearchValue = new System.Windows.Forms.TextBox();
            this.fmsItemCount = new GUI.View.FilterModeSelector();
            this.fmsItemCondition = new GUI.View.FilterModeSelector();
            this.fmsItemTypes = new GUI.View.FilterModeSelector();
            this.fmsOrderSearch = new GUI.View.FilterModeSelector();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHideFilters = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbOrderSearchControls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbItemCountControls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbItemConditionControls = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbOrderStatusControls = new System.Windows.Forms.GroupBox();
            this.gbItemTypeControls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbOrderSearchControls.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbItemCountControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbItemConditionControls.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbOrderStatusControls.SuspendLayout();
            this.gbItemTypeControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(711, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // clbItemTypes
            // 
            this.clbItemTypes.CheckOnClick = true;
            this.clbItemTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbItemTypes.FormattingEnabled = true;
            this.clbItemTypes.Location = new System.Drawing.Point(3, 48);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(142, 229);
            this.clbItemTypes.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(834, 354);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.Text = "dataGridView1";
            // 
            // cbItemCondition
            // 
            this.cbItemCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCondition.FormattingEnabled = true;
            this.cbItemCondition.Location = new System.Drawing.Point(3, 48);
            this.cbItemCondition.Name = "cbItemCondition";
            this.cbItemCondition.Size = new System.Drawing.Size(298, 24);
            this.cbItemCondition.TabIndex = 5;
            // 
            // tbItemCount
            // 
            this.tbItemCount.Location = new System.Drawing.Point(247, 3);
            this.tbItemCount.MinimumSize = new System.Drawing.Size(48, 4);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(48, 23);
            this.tbItemCount.TabIndex = 7;
            this.tbItemCount.Text = "0";
            // 
            // cbItemCountType
            // 
            this.cbItemCountType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCountType.FormattingEnabled = true;
            this.cbItemCountType.Location = new System.Drawing.Point(3, 3);
            this.cbItemCountType.Name = "cbItemCountType";
            this.cbItemCountType.Size = new System.Drawing.Size(238, 24);
            this.cbItemCountType.TabIndex = 8;
            // 
            // clbOrderStatuses
            // 
            this.clbOrderStatuses.CheckOnClick = true;
            this.clbOrderStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbOrderStatuses.FormattingEnabled = true;
            this.clbOrderStatuses.Location = new System.Drawing.Point(3, 19);
            this.clbOrderStatuses.Name = "clbOrderStatuses";
            this.clbOrderStatuses.Size = new System.Drawing.Size(126, 258);
            this.clbOrderStatuses.TabIndex = 9;
            // 
            // cbOrderSearchType
            // 
            this.cbOrderSearchType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOrderSearchType.FormattingEnabled = true;
            this.cbOrderSearchType.Location = new System.Drawing.Point(3, 3);
            this.cbOrderSearchType.Name = "cbOrderSearchType";
            this.cbOrderSearchType.Size = new System.Drawing.Size(238, 24);
            this.cbOrderSearchType.TabIndex = 10;
            // 
            // tbOrderSearchValue
            // 
            this.tbOrderSearchValue.Location = new System.Drawing.Point(247, 3);
            this.tbOrderSearchValue.MinimumSize = new System.Drawing.Size(48, 4);
            this.tbOrderSearchValue.Name = "tbOrderSearchValue";
            this.tbOrderSearchValue.Size = new System.Drawing.Size(48, 23);
            this.tbOrderSearchValue.TabIndex = 11;
            // 
            // fmsItemCount
            // 
            this.fmsItemCount.AutoSize = true;
            this.fmsItemCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.fmsItemCount.Location = new System.Drawing.Point(3, 19);
            this.fmsItemCount.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemCount.Mode1Checked = true;
            this.fmsItemCount.Mode1Text = "Min";
            this.fmsItemCount.Mode2Checked = false;
            this.fmsItemCount.Mode2Text = "Max";
            this.fmsItemCount.Name = "fmsItemCount";
            this.fmsItemCount.Size = new System.Drawing.Size(298, 29);
            this.fmsItemCount.TabIndex = 12;
            // 
            // fmsItemCondition
            // 
            this.fmsItemCondition.AutoSize = true;
            this.fmsItemCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.fmsItemCondition.Location = new System.Drawing.Point(3, 19);
            this.fmsItemCondition.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemCondition.Mode1Checked = true;
            this.fmsItemCondition.Mode1Text = "Any";
            this.fmsItemCondition.Mode2Checked = false;
            this.fmsItemCondition.Mode2Text = "All";
            this.fmsItemCondition.Name = "fmsItemCondition";
            this.fmsItemCondition.Size = new System.Drawing.Size(298, 29);
            this.fmsItemCondition.TabIndex = 13;
            // 
            // fmsItemTypes
            // 
            this.fmsItemTypes.AutoSize = true;
            this.fmsItemTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.fmsItemTypes.Location = new System.Drawing.Point(3, 19);
            this.fmsItemTypes.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemTypes.Mode1Checked = true;
            this.fmsItemTypes.Mode1Text = "Any";
            this.fmsItemTypes.Mode2Checked = false;
            this.fmsItemTypes.Mode2Text = "All";
            this.fmsItemTypes.Name = "fmsItemTypes";
            this.fmsItemTypes.Size = new System.Drawing.Size(142, 29);
            this.fmsItemTypes.TabIndex = 14;
            // 
            // fmsOrderSearch
            // 
            this.fmsOrderSearch.AutoSize = true;
            this.fmsOrderSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsOrderSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.fmsOrderSearch.Location = new System.Drawing.Point(3, 19);
            this.fmsOrderSearch.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsOrderSearch.Mode1Checked = false;
            this.fmsOrderSearch.Mode1Text = "Strict";
            this.fmsOrderSearch.Mode2Checked = true;
            this.fmsOrderSearch.Mode2Text = "Loose";
            this.fmsOrderSearch.Name = "fmsOrderSearch";
            this.fmsOrderSearch.Size = new System.Drawing.Size(298, 29);
            this.fmsOrderSearch.TabIndex = 15;
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrders);
            this.splitContainer1.Panel1.Controls.Add(this.btnHideFilters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Size = new System.Drawing.Size(834, 664);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // btnHideFilters
            // 
            this.btnHideFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHideFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideFilters.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHideFilters.ForeColor = System.Drawing.Color.Silver;
            this.btnHideFilters.Location = new System.Drawing.Point(0, 354);
            this.btnHideFilters.Name = "btnHideFilters";
            this.btnHideFilters.Size = new System.Drawing.Size(834, 26);
            this.btnHideFilters.TabIndex = 16;
            this.btnHideFilters.Text = "v";
            this.btnHideFilters.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gbOrderSearchControls);
            this.flowLayoutPanel1.Controls.Add(this.gbItemCountControls);
            this.flowLayoutPanel1.Controls.Add(this.gbItemConditionControls);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(293, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 280);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // gbOrderSearchControls
            // 
            this.gbOrderSearchControls.Controls.Add(this.tableLayoutPanel3);
            this.gbOrderSearchControls.Controls.Add(this.fmsOrderSearch);
            this.gbOrderSearchControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbOrderSearchControls.ForeColor = System.Drawing.Color.Silver;
            this.gbOrderSearchControls.Location = new System.Drawing.Point(3, 3);
            this.gbOrderSearchControls.Name = "gbOrderSearchControls";
            this.gbOrderSearchControls.Size = new System.Drawing.Size(304, 87);
            this.gbOrderSearchControls.TabIndex = 5;
            this.gbOrderSearchControls.TabStop = false;
            this.gbOrderSearchControls.Text = "Order Search";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tbOrderSearchValue, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbOrderSearchType, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(298, 34);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // gbItemCountControls
            // 
            this.gbItemCountControls.Controls.Add(this.tableLayoutPanel1);
            this.gbItemCountControls.Controls.Add(this.fmsItemCount);
            this.gbItemCountControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemCountControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemCountControls.Location = new System.Drawing.Point(3, 96);
            this.gbItemCountControls.Name = "gbItemCountControls";
            this.gbItemCountControls.Size = new System.Drawing.Size(304, 87);
            this.gbItemCountControls.TabIndex = 4;
            this.gbItemCountControls.TabStop = false;
            this.gbItemCountControls.Text = "Item Count";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tbItemCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCountType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gbItemConditionControls
            // 
            this.gbItemConditionControls.Controls.Add(this.cbItemCondition);
            this.gbItemConditionControls.Controls.Add(this.fmsItemCondition);
            this.gbItemConditionControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemConditionControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemConditionControls.Location = new System.Drawing.Point(3, 189);
            this.gbItemConditionControls.Name = "gbItemConditionControls";
            this.gbItemConditionControls.Size = new System.Drawing.Size(304, 91);
            this.gbItemConditionControls.TabIndex = 6;
            this.gbItemConditionControls.TabStop = false;
            this.gbItemConditionControls.Text = "Item Condition";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gbOrderStatusControls);
            this.flowLayoutPanel2.Controls.Add(this.gbItemTypeControls);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(293, 280);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // gbOrderStatusControls
            // 
            this.gbOrderStatusControls.Controls.Add(this.clbOrderStatuses);
            this.gbOrderStatusControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbOrderStatusControls.ForeColor = System.Drawing.Color.Silver;
            this.gbOrderStatusControls.Location = new System.Drawing.Point(3, 3);
            this.gbOrderStatusControls.Name = "gbOrderStatusControls";
            this.gbOrderStatusControls.Size = new System.Drawing.Size(132, 280);
            this.gbOrderStatusControls.TabIndex = 2;
            this.gbOrderStatusControls.TabStop = false;
            this.gbOrderStatusControls.Text = "Order Status";
            // 
            // gbItemTypeControls
            // 
            this.gbItemTypeControls.Controls.Add(this.clbItemTypes);
            this.gbItemTypeControls.Controls.Add(this.fmsItemTypes);
            this.gbItemTypeControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbItemTypeControls.ForeColor = System.Drawing.Color.Silver;
            this.gbItemTypeControls.Location = new System.Drawing.Point(141, 3);
            this.gbItemTypeControls.Name = "gbItemTypeControls";
            this.gbItemTypeControls.Size = new System.Drawing.Size(148, 280);
            this.gbItemTypeControls.TabIndex = 3;
            this.gbItemTypeControls.TabStop = false;
            this.gbItemTypeControls.Text = "Item Type";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(834, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbOrderSearchControls.ResumeLayout(false);
            this.gbOrderSearchControls.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbItemCountControls.ResumeLayout(false);
            this.gbItemCountControls.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbItemConditionControls.ResumeLayout(false);
            this.gbItemConditionControls.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gbOrderStatusControls.ResumeLayout(false);
            this.gbItemTypeControls.ResumeLayout(false);
            this.gbItemTypeControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox clbItemTypes;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ComboBox cbItemCondition;
        private System.Windows.Forms.TextBox tbItemCount;
        private System.Windows.Forms.ComboBox cbItemCountType;
        private System.Windows.Forms.CheckedListBox clbOrderStatuses;
        private System.Windows.Forms.ComboBox cbOrderSearchType;
        private System.Windows.Forms.TextBox tbOrderSearchValue;
        private FilterModeSelector fmsItemCount;
        private FilterModeSelector fmsItemCondition;
        private FilterModeSelector fmsItemTypes;
        private FilterModeSelector fmsOrderSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnHideFilters;
        private System.Windows.Forms.GroupBox gbItemTypeControls;
        private System.Windows.Forms.GroupBox gbOrderStatusControls;
        private System.Windows.Forms.GroupBox gbItemConditionControls;
        private System.Windows.Forms.GroupBox gbOrderSearchControls;
        private System.Windows.Forms.GroupBox gbItemCountControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
