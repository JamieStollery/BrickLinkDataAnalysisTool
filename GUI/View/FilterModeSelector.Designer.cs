namespace GUI.View
{
    partial class FilterModeSelector
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
            this.rbAny = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbAny
            // 
            this.rbAny.AutoSize = true;
            this.rbAny.Checked = true;
            this.rbAny.Location = new System.Drawing.Point(0, 0);
            this.rbAny.Name = "rbAny";
            this.rbAny.Size = new System.Drawing.Size(46, 19);
            this.rbAny.TabIndex = 0;
            this.rbAny.TabStop = true;
            this.rbAny.Text = "Any";
            this.rbAny.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(52, 0);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 19);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // FilterModeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbAny);
            this.MaximumSize = new System.Drawing.Size(90, 20);
            this.MinimumSize = new System.Drawing.Size(90, 20);
            this.Name = "FilterModeSelector";
            this.Size = new System.Drawing.Size(90, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAny;
        private System.Windows.Forms.RadioButton rbAll;
    }
}
