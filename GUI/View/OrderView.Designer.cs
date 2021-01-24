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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(711, 290);
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
            this.clbItemTypes.Location = new System.Drawing.Point(3, 192);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(271, 128);
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
            this.dgvOrders.Size = new System.Drawing.Size(834, 341);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.Text = "dataGridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.clbItemTypes, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCondition, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbItemCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCountType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clbOrderStatuses, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbOrderSearchType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbOrderSearchValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemCount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemCondition, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemTypes, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fmsOrderSearch, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 341);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 323);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // cbItemCondition
            // 
            this.cbItemCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCondition.FormattingEnabled = true;
            this.cbItemCondition.Location = new System.Drawing.Point(3, 129);
            this.cbItemCondition.Name = "cbItemCondition";
            this.cbItemCondition.Size = new System.Drawing.Size(271, 23);
            this.cbItemCondition.TabIndex = 5;
            // 
            // tbItemCount
            // 
            this.tbItemCount.Location = new System.Drawing.Point(3, 66);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(48, 23);
            this.tbItemCount.TabIndex = 7;
            this.tbItemCount.Text = "0";
            // 
            // cbItemCountType
            // 
            this.cbItemCountType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCountType.FormattingEnabled = true;
            this.cbItemCountType.Location = new System.Drawing.Point(3, 37);
            this.cbItemCountType.Name = "cbItemCountType";
            this.cbItemCountType.Size = new System.Drawing.Size(271, 23);
            this.cbItemCountType.TabIndex = 8;
            // 
            // clbOrderStatuses
            // 
            this.clbOrderStatuses.CheckOnClick = true;
            this.clbOrderStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbOrderStatuses.FormattingEnabled = true;
            this.clbOrderStatuses.Location = new System.Drawing.Point(280, 192);
            this.clbOrderStatuses.Name = "clbOrderStatuses";
            this.clbOrderStatuses.Size = new System.Drawing.Size(272, 128);
            this.clbOrderStatuses.TabIndex = 9;
            // 
            // cbOrderSearchType
            // 
            this.cbOrderSearchType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOrderSearchType.FormattingEnabled = true;
            this.cbOrderSearchType.Location = new System.Drawing.Point(280, 37);
            this.cbOrderSearchType.Name = "cbOrderSearchType";
            this.cbOrderSearchType.Size = new System.Drawing.Size(272, 23);
            this.cbOrderSearchType.TabIndex = 10;
            // 
            // tbOrderSearchValue
            // 
            this.tbOrderSearchValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOrderSearchValue.Location = new System.Drawing.Point(280, 66);
            this.tbOrderSearchValue.Name = "tbOrderSearchValue";
            this.tbOrderSearchValue.Size = new System.Drawing.Size(272, 23);
            this.tbOrderSearchValue.TabIndex = 11;
            // 
            // fmsItemCount
            // 
            this.fmsItemCount.AutoSize = true;
            this.fmsItemCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsItemCount.Location = new System.Drawing.Point(3, 3);
            this.fmsItemCount.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemCount.Mode1Checked = true;
            this.fmsItemCount.Mode1Text = "Min";
            this.fmsItemCount.Mode2Checked = false;
            this.fmsItemCount.Mode2Text = "Max";
            this.fmsItemCount.Name = "fmsItemCount";
            this.fmsItemCount.Size = new System.Drawing.Size(271, 28);
            this.fmsItemCount.TabIndex = 12;
            // 
            // fmsItemCondition
            // 
            this.fmsItemCondition.AutoSize = true;
            this.fmsItemCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsItemCondition.Location = new System.Drawing.Point(3, 95);
            this.fmsItemCondition.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemCondition.Mode1Checked = true;
            this.fmsItemCondition.Mode1Text = "Any";
            this.fmsItemCondition.Mode2Checked = false;
            this.fmsItemCondition.Mode2Text = "All";
            this.fmsItemCondition.Name = "fmsItemCondition";
            this.fmsItemCondition.Size = new System.Drawing.Size(271, 28);
            this.fmsItemCondition.TabIndex = 13;
            // 
            // fmsItemTypes
            // 
            this.fmsItemTypes.AutoSize = true;
            this.fmsItemTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsItemTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsItemTypes.Location = new System.Drawing.Point(3, 158);
            this.fmsItemTypes.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsItemTypes.Mode1Checked = true;
            this.fmsItemTypes.Mode1Text = "Any";
            this.fmsItemTypes.Mode2Checked = false;
            this.fmsItemTypes.Mode2Text = "All";
            this.fmsItemTypes.Name = "fmsItemTypes";
            this.fmsItemTypes.Size = new System.Drawing.Size(271, 28);
            this.fmsItemTypes.TabIndex = 14;
            // 
            // fmsOrderSearch
            // 
            this.fmsOrderSearch.AutoSize = true;
            this.fmsOrderSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fmsOrderSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmsOrderSearch.Location = new System.Drawing.Point(280, 3);
            this.fmsOrderSearch.MinimumSize = new System.Drawing.Size(100, 25);
            this.fmsOrderSearch.Mode1Checked = false;
            this.fmsOrderSearch.Mode1Text = "Strict";
            this.fmsOrderSearch.Mode2Checked = true;
            this.fmsOrderSearch.Mode2Text = "Loose";
            this.fmsOrderSearch.Name = "fmsOrderSearch";
            this.fmsOrderSearch.Size = new System.Drawing.Size(272, 28);
            this.fmsOrderSearch.TabIndex = 15;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(834, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox clbItemTypes;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}
