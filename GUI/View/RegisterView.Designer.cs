namespace GUI.View
{
    partial class RegisterView
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTokenSecret = new System.Windows.Forms.TextBox();
            this.lblTokenSecret = new System.Windows.Forms.Label();
            this.tbTokenValue = new System.Windows.Forms.TextBox();
            this.lblTokenValue = new System.Windows.Forms.Label();
            this.tbConsumerSecret = new System.Windows.Forms.TextBox();
            this.lblConsumerSecret = new System.Windows.Forms.Label();
            this.tbConsumerKey = new System.Windows.Forms.TextBox();
            this.lblConsumerKey = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Location = new System.Drawing.Point(3, 267);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(244, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbTokenSecret, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblTokenSecret, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbTokenValue, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblTokenValue, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbConsumerSecret, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblConsumerSecret, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbConsumerKey, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblConsumerKey, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 300);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbTokenSecret
            // 
            this.tbTokenSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTokenSecret.Location = new System.Drawing.Point(3, 238);
            this.tbTokenSecret.Name = "tbTokenSecret";
            this.tbTokenSecret.Size = new System.Drawing.Size(244, 23);
            this.tbTokenSecret.TabIndex = 3;
            // 
            // lblTokenSecret
            // 
            this.lblTokenSecret.AutoSize = true;
            this.lblTokenSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTokenSecret.Location = new System.Drawing.Point(3, 220);
            this.lblTokenSecret.Name = "lblTokenSecret";
            this.lblTokenSecret.Size = new System.Drawing.Size(244, 15);
            this.lblTokenSecret.TabIndex = 2;
            this.lblTokenSecret.Text = "Token Secret:";
            // 
            // tbTokenValue
            // 
            this.tbTokenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTokenValue.Location = new System.Drawing.Point(3, 194);
            this.tbTokenValue.Name = "tbTokenValue";
            this.tbTokenValue.Size = new System.Drawing.Size(244, 23);
            this.tbTokenValue.TabIndex = 3;
            // 
            // lblTokenValue
            // 
            this.lblTokenValue.AutoSize = true;
            this.lblTokenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTokenValue.Location = new System.Drawing.Point(3, 176);
            this.lblTokenValue.Name = "lblTokenValue";
            this.lblTokenValue.Size = new System.Drawing.Size(244, 15);
            this.lblTokenValue.TabIndex = 2;
            this.lblTokenValue.Text = "Token Value:";
            // 
            // tbConsumerSecret
            // 
            this.tbConsumerSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConsumerSecret.Location = new System.Drawing.Point(3, 150);
            this.tbConsumerSecret.Name = "tbConsumerSecret";
            this.tbConsumerSecret.Size = new System.Drawing.Size(244, 23);
            this.tbConsumerSecret.TabIndex = 3;
            // 
            // lblConsumerSecret
            // 
            this.lblConsumerSecret.AutoSize = true;
            this.lblConsumerSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConsumerSecret.Location = new System.Drawing.Point(3, 132);
            this.lblConsumerSecret.Name = "lblConsumerSecret";
            this.lblConsumerSecret.Size = new System.Drawing.Size(244, 15);
            this.lblConsumerSecret.TabIndex = 2;
            this.lblConsumerSecret.Text = "Consumer Secret:";
            // 
            // tbConsumerKey
            // 
            this.tbConsumerKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConsumerKey.Location = new System.Drawing.Point(3, 106);
            this.tbConsumerKey.Name = "tbConsumerKey";
            this.tbConsumerKey.Size = new System.Drawing.Size(244, 23);
            this.tbConsumerKey.TabIndex = 3;
            // 
            // lblConsumerKey
            // 
            this.lblConsumerKey.AutoSize = true;
            this.lblConsumerKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConsumerKey.Location = new System.Drawing.Point(3, 88);
            this.lblConsumerKey.Name = "lblConsumerKey";
            this.lblConsumerKey.Size = new System.Drawing.Size(244, 15);
            this.lblConsumerKey.TabIndex = 2;
            this.lblConsumerKey.Text = "Consumer Key:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Location = new System.Drawing.Point(3, 62);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(244, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(3, 44);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(244, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(244, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsername.Location = new System.Drawing.Point(3, 18);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(244, 23);
            this.tbUsername.TabIndex = 3;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "RegisterView";
            this.Size = new System.Drawing.Size(250, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbTokenSecret;
        private System.Windows.Forms.Label lblTokenSecret;
        private System.Windows.Forms.TextBox tbTokenValue;
        private System.Windows.Forms.Label lblTokenValue;
        private System.Windows.Forms.TextBox tbConsumerSecret;
        private System.Windows.Forms.Label lblConsumerSecret;
        private System.Windows.Forms.TextBox tbConsumerKey;
        private System.Windows.Forms.Label lblConsumerKey;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
    }
}
