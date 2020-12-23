using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Presentation.View.Interface;

namespace GUI.View
{
    public partial class LoginView : UserControl, ILoginView
    {
        private Label _lblError;

        public LoginView()
        {
            InitializeComponent();
            _lblError = new Label() { Dock = DockStyle.Fill, ForeColor = Color.Red };
        }

        public Action OnLoginButtonClick { set => btnLogin.Click += (sender, e) => value(); }
        public Action OnRegisterButtonClick { set => btnRegister.Click += (sender, e) => value(); }
        public string Username => tbUsername.Text;
        public string Password => tbPassword.Text;
        public string Error
        {
            set
            {
                _lblError.Text = value;
                tableLayoutPanel1.Controls.Add(_lblError, 0, 5);
                tableLayoutPanel1.AutoSize = true;
            }
        }
    }
}
