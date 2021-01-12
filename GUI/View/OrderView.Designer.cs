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
            this.fmsItemTypes = new GUI.View.FilterModeSelector();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fmsItemCondition = new GUI.View.FilterModeSelector();
            this.cbItemCondition = new System.Windows.Forms.ComboBox();
            this.tbItemCount = new System.Windows.Forms.TextBox();
            this.fmsItemCount = new GUI.View.FilterModeSelector();
            this.cbItemCountType = new System.Windows.Forms.ComboBox();
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
            this.clbItemTypes.Location = new System.Drawing.Point(3, 168);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(271, 152);
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
            // fmsItemTypes
            // 
            this.fmsItemTypes.Location = new System.Drawing.Point(3, 142);
            this.fmsItemTypes.MaximumSize = new System.Drawing.Size(100, 20);
            this.fmsItemTypes.MinimumSize = new System.Drawing.Size(100, 20);
            this.fmsItemTypes.Name = "fmsItemTypes";
            this.fmsItemTypes.Size = new System.Drawing.Size(100, 20);
            this.fmsItemTypes.TabIndex = 3;
            this.fmsItemTypes.UseAnyAll = true;
            this.fmsItemTypes.UseMinMax = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.clbItemTypes, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemTypes, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemCondition, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCondition, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbItemCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemCount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCountType, 0, 1);
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
            // fmsItemCondition
            // 
            this.fmsItemCondition.Location = new System.Drawing.Point(3, 87);
            this.fmsItemCondition.MaximumSize = new System.Drawing.Size(100, 20);
            this.fmsItemCondition.MinimumSize = new System.Drawing.Size(100, 20);
            this.fmsItemCondition.Name = "fmsItemCondition";
            this.fmsItemCondition.Size = new System.Drawing.Size(100, 20);
            this.fmsItemCondition.TabIndex = 4;
            this.fmsItemCondition.UseAnyAll = true;
            this.fmsItemCondition.UseMinMax = false;
            // 
            // cbItemCondition
            // 
            this.cbItemCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCondition.FormattingEnabled = true;
            this.cbItemCondition.Location = new System.Drawing.Point(3, 113);
            this.cbItemCondition.Name = "cbItemCondition";
            this.cbItemCondition.Size = new System.Drawing.Size(271, 23);
            this.cbItemCondition.TabIndex = 5;
            // 
            // tbItemCount
            // 
            this.tbItemCount.Location = new System.Drawing.Point(3, 58);
            this.tbItemCount.Name = "tbItemCount";
            this.tbItemCount.Size = new System.Drawing.Size(48, 23);
            this.tbItemCount.TabIndex = 7;
            this.tbItemCount.Text = "0";
            // 
            // fmsItemCount
            // 
            this.fmsItemCount.Location = new System.Drawing.Point(3, 3);
            this.fmsItemCount.MaximumSize = new System.Drawing.Size(100, 20);
            this.fmsItemCount.MinimumSize = new System.Drawing.Size(100, 20);
            this.fmsItemCount.Name = "fmsItemCount";
            this.fmsItemCount.Size = new System.Drawing.Size(100, 20);
            this.fmsItemCount.TabIndex = 6;
            this.fmsItemCount.UseAnyAll = false;
            this.fmsItemCount.UseMinMax = true;
            // 
            // cbItemCountType
            // 
            this.cbItemCountType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCountType.FormattingEnabled = true;
            this.cbItemCountType.Location = new System.Drawing.Point(3, 29);
            this.cbItemCountType.Name = "cbItemCountType";
            this.cbItemCountType.Size = new System.Drawing.Size(271, 23);
            this.cbItemCountType.TabIndex = 8;
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
        private FilterModeSelector fmsItemTypes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FilterModeSelector fmsItemCondition;
        private System.Windows.Forms.ComboBox cbItemCondition;
        private System.Windows.Forms.TextBox tbItemCount;
        private FilterModeSelector fmsItemCount;
        private System.Windows.Forms.ComboBox cbItemCountType;
    }
}
