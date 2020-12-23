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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.miAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tbUsername = new System.Windows.Forms.ToolStripTextBox();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewStage
            // 
            this.pnlViewStage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlViewStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewStage.Location = new System.Drawing.Point(0, 24);
            this.pnlViewStage.Name = "pnlViewStage";
            this.pnlViewStage.Size = new System.Drawing.Size(800, 426);
            this.pnlViewStage.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAccount,
            this.tbUsername});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 1;
            // 
            // miAccount
            // 
            this.miAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLogout,
            this.toolStripSeparator1,
            this.miLogin,
            this.miRegister});
            this.miAccount.Name = "miAccount";
            this.miAccount.Size = new System.Drawing.Size(64, 20);
            this.miAccount.Text = "Account";
            // 
            // miLogout
            // 
            this.miLogout.Name = "miLogout";
            this.miLogout.Size = new System.Drawing.Size(156, 22);
            this.miLogout.Text = "Logout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.Size = new System.Drawing.Size(156, 22);
            this.miLogin.Text = "Login";
            // 
            // miRegister
            // 
            this.miRegister.Name = "miRegister";
            this.miRegister.Size = new System.Drawing.Size(156, 22);
            this.miRegister.Text = "Create Account";
            // 
            // tbUsername
            // 
            this.tbUsername.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.Text = "Username";
            // 
            // MainStageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewStage);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "MainStageView";
            this.Text = "MainStageView";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewStage;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem miAccount;
        private System.Windows.Forms.ToolStripMenuItem miLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.ToolStripMenuItem miRegister;
        private System.Windows.Forms.ToolStripTextBox tbUsername;
    }
}