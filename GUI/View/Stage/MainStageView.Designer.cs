namespace GUI.View.Stage
{
    partial class MainStageView
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
            this.pnlViewStage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlViewStage
            // 
            this.pnlViewStage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlViewStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewStage.Location = new System.Drawing.Point(0, 0);
            this.pnlViewStage.Name = "pnlViewStage";
            this.pnlViewStage.Size = new System.Drawing.Size(800, 450);
            this.pnlViewStage.TabIndex = 0;
            // 
            // MainStageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewStage);
            this.Name = "MainStageView";
            this.Text = "MainStageView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewStage;
    }
}