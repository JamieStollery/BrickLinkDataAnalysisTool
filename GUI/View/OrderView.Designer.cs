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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(524, 132);
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
            this.clbItemTypes.Location = new System.Drawing.Point(3, 29);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(209, 133);
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
            this.dgvOrders.Size = new System.Drawing.Size(647, 298);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.Text = "dataGridView1";
            // 
            // fmsItemTypes
            // 
            this.fmsItemTypes.Location = new System.Drawing.Point(3, 3);
            this.fmsItemTypes.MaximumSize = new System.Drawing.Size(90, 20);
            this.fmsItemTypes.MinimumSize = new System.Drawing.Size(90, 20);
            this.fmsItemTypes.Name = "fmsItemTypes";
            this.fmsItemTypes.Size = new System.Drawing.Size(90, 20);
            this.fmsItemTypes.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.clbItemTypes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemTypes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fmsItemCondition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbItemCondition, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 165);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // fmsItemCondition
            // 
            this.fmsItemCondition.Location = new System.Drawing.Point(218, 3);
            this.fmsItemCondition.MaximumSize = new System.Drawing.Size(90, 20);
            this.fmsItemCondition.MinimumSize = new System.Drawing.Size(90, 20);
            this.fmsItemCondition.Name = "fmsItemCondition";
            this.fmsItemCondition.Size = new System.Drawing.Size(90, 20);
            this.fmsItemCondition.TabIndex = 4;
            // 
            // cbItemCondition
            // 
            this.cbItemCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbItemCondition.FormattingEnabled = true;
            this.cbItemCondition.Location = new System.Drawing.Point(218, 29);
            this.cbItemCondition.Name = "cbItemCondition";
            this.cbItemCondition.Size = new System.Drawing.Size(209, 23);
            this.cbItemCondition.TabIndex = 5;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(647, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}
