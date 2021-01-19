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
            this.miDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangeDataMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miUpdateDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.miClearDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tbUsername = new System.Windows.Forms.ToolStripTextBox();
            this.tbSeperator = new System.Windows.Forms.ToolStripTextBox();
            this.tbDataMode = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbTaskProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblTaskLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewStage
            // 
            this.pnlViewStage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlViewStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewStage.Location = new System.Drawing.Point(0, 27);
            this.pnlViewStage.Name = "pnlViewStage";
            this.pnlViewStage.Size = new System.Drawing.Size(800, 401);
            this.pnlViewStage.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAccount,
            this.miDatabase,
            this.tbUsername,
            this.tbSeperator,
            this.tbDataMode});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 27);
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
            this.miAccount.Size = new System.Drawing.Size(64, 23);
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
            // miDatabase
            // 
            this.miDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChangeDataMode,
            this.toolStripSeparator2,
            this.miUpdateDatabase,
            this.miClearDatabase});
            this.miDatabase.Name = "miDatabase";
            this.miDatabase.Size = new System.Drawing.Size(67, 23);
            this.miDatabase.Text = "Database";
            // 
            // miChangeDataMode
            // 
            this.miChangeDataMode.Name = "miChangeDataMode";
            this.miChangeDataMode.Size = new System.Drawing.Size(176, 22);
            this.miChangeDataMode.Text = "Change Data Mode";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // miUpdateDatabase
            // 
            this.miUpdateDatabase.Name = "miUpdateDatabase";
            this.miUpdateDatabase.Size = new System.Drawing.Size(176, 22);
            this.miUpdateDatabase.Text = "Update Database";
            // 
            // miClearDatabase
            // 
            this.miClearDatabase.Name = "miClearDatabase";
            this.miClearDatabase.Size = new System.Drawing.Size(176, 22);
            this.miClearDatabase.Text = "Clear Database";
            // 
            // tbUsername
            // 
            this.tbUsername.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(100, 23);
            this.tbUsername.Text = "Username:";
            // 
            // tbSeperator
            // 
            this.tbSeperator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbSeperator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSeperator.Name = "tbSeperator";
            this.tbSeperator.ReadOnly = true;
            this.tbSeperator.Size = new System.Drawing.Size(10, 23);
            this.tbSeperator.Text = "|";
            // 
            // tbDataMode
            // 
            this.tbDataMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbDataMode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDataMode.Name = "tbDataMode";
            this.tbDataMode.ReadOnly = true;
            this.tbDataMode.Size = new System.Drawing.Size(100, 23);
            this.tbDataMode.Text = "Data Mode:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbTaskProgress,
            this.lblTaskLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "ssStatus";
            // 
            // pbTaskProgress
            // 
            this.pbTaskProgress.Name = "pbTaskProgress";
            this.pbTaskProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lblTaskLabel
            // 
            this.lblTaskLabel.Name = "lblTaskLabel";
            this.lblTaskLabel.Size = new System.Drawing.Size(118, 17);
            this.lblTaskLabel.Text = "toolStripStatusLabel1";
            // 
            // MainStageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewStage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "MainStageView";
            this.Text = "MainStageView";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem miDatabase;
        private System.Windows.Forms.ToolStripMenuItem miChangeDataMode;
        private System.Windows.Forms.ToolStripTextBox tbDataMode;
        private System.Windows.Forms.ToolStripTextBox tbSeperator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miUpdateDatabase;
        private System.Windows.Forms.ToolStripMenuItem miClearDatabase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbTaskProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblTaskLabel;
    }
}