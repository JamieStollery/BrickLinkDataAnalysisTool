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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStageView));
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
            this.pnlViewStage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.pnlViewStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewStage.Location = new System.Drawing.Point(0, 24);
            this.pnlViewStage.Name = "pnlViewStage";
            this.pnlViewStage.Size = new System.Drawing.Size(800, 404);
            this.pnlViewStage.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAccount,
            this.miDatabase,
            this.tbUsername,
            this.tbSeperator,
            this.tbDataMode});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            this.miAccount.ForeColor = System.Drawing.Color.Silver;
            this.miAccount.Name = "miAccount";
            this.miAccount.Size = new System.Drawing.Size(73, 20);
            this.miAccount.Text = "Account";
            // 
            // miLogout
            // 
            this.miLogout.ForeColor = System.Drawing.Color.Silver;
            this.miLogout.Name = "miLogout";
            this.miLogout.Size = new System.Drawing.Size(176, 22);
            this.miLogout.Text = "Logout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // miLogin
            // 
            this.miLogin.ForeColor = System.Drawing.Color.Silver;
            this.miLogin.Name = "miLogin";
            this.miLogin.Size = new System.Drawing.Size(176, 22);
            this.miLogin.Text = "Login";
            // 
            // miRegister
            // 
            this.miRegister.ForeColor = System.Drawing.Color.Silver;
            this.miRegister.Name = "miRegister";
            this.miRegister.Size = new System.Drawing.Size(176, 22);
            this.miRegister.Text = "Create Account";
            // 
            // miDatabase
            // 
            this.miDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChangeDataMode,
            this.toolStripSeparator2,
            this.miUpdateDatabase,
            this.miClearDatabase});
            this.miDatabase.ForeColor = System.Drawing.Color.Silver;
            this.miDatabase.Name = "miDatabase";
            this.miDatabase.Size = new System.Drawing.Size(82, 20);
            this.miDatabase.Text = "Database";
            // 
            // miChangeDataMode
            // 
            this.miChangeDataMode.ForeColor = System.Drawing.Color.Silver;
            this.miChangeDataMode.Name = "miChangeDataMode";
            this.miChangeDataMode.Size = new System.Drawing.Size(202, 22);
            this.miChangeDataMode.Text = "Change Data Mode";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Silver;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // miUpdateDatabase
            // 
            this.miUpdateDatabase.ForeColor = System.Drawing.Color.Silver;
            this.miUpdateDatabase.Name = "miUpdateDatabase";
            this.miUpdateDatabase.Size = new System.Drawing.Size(202, 22);
            this.miUpdateDatabase.Text = "Update Database";
            // 
            // miClearDatabase
            // 
            this.miClearDatabase.ForeColor = System.Drawing.Color.Silver;
            this.miClearDatabase.Name = "miClearDatabase";
            this.miClearDatabase.Size = new System.Drawing.Size(202, 22);
            this.miClearDatabase.Text = "Clear Database";
            // 
            // tbUsername
            // 
            this.tbUsername.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.Text = "Username:";
            // 
            // tbSeperator
            // 
            this.tbSeperator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.tbSeperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSeperator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSeperator.ForeColor = System.Drawing.Color.Silver;
            this.tbSeperator.Name = "tbSeperator";
            this.tbSeperator.ReadOnly = true;
            this.tbSeperator.Size = new System.Drawing.Size(10, 20);
            this.tbSeperator.Text = "|";
            // 
            // tbDataMode
            // 
            this.tbDataMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbDataMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.tbDataMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDataMode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDataMode.ForeColor = System.Drawing.Color.Silver;
            this.tbDataMode.Name = "tbDataMode";
            this.tbDataMode.ReadOnly = true;
            this.tbDataMode.Size = new System.Drawing.Size(100, 20);
            this.tbDataMode.Text = "Data Mode:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbTaskProgress,
            this.lblTaskLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // pbTaskProgress
            // 
            this.pbTaskProgress.Name = "pbTaskProgress";
            this.pbTaskProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lblTaskLabel
            // 
            this.lblTaskLabel.ForeColor = System.Drawing.Color.Silver;
            this.lblTaskLabel.Name = "lblTaskLabel";
            this.lblTaskLabel.Size = new System.Drawing.Size(141, 17);
            this.lblTaskLabel.Text = "toolStripStatusLabel1";
            // 
            // MainStageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlViewStage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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