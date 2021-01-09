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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(537, 228);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 68);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // clbItemTypes
            // 
            this.clbItemTypes.CheckOnClick = true;
            this.clbItemTypes.FormattingEnabled = true;
            this.clbItemTypes.Location = new System.Drawing.Point(0, 254);
            this.clbItemTypes.Name = "clbItemTypes";
            this.clbItemTypes.Size = new System.Drawing.Size(133, 166);
            this.clbItemTypes.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(647, 222);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.Text = "dataGridView1";
            // 
            // fmsItemTypes
            // 
            this.fmsItemTypes.Location = new System.Drawing.Point(0, 228);
            this.fmsItemTypes.MaximumSize = new System.Drawing.Size(90, 20);
            this.fmsItemTypes.MinimumSize = new System.Drawing.Size(90, 20);
            this.fmsItemTypes.Name = "fmsItemTypes";
            this.fmsItemTypes.Size = new System.Drawing.Size(90, 20);
            this.fmsItemTypes.TabIndex = 3;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.fmsItemTypes);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.clbItemTypes);
            this.Controls.Add(this.btnSearch);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(647, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox clbItemTypes;
        private System.Windows.Forms.DataGridView dgvOrders;
        private FilterModeSelector fmsItemTypes;
    }
}
