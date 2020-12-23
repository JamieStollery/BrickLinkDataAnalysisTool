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
    public partial class RegisterView : UserControl, IRegisterView
    {
        private Label _lblError;

        public RegisterView()
        {
            InitializeComponent();
            _lblError = new Label() { Dock = DockStyle.Fill, ForeColor = Color.Red };
        }

        public Action OnRegisterButtonClick { set => btnRegister.Click += (sender, e) => value(); }
 
        public string Username => tbUsername.Text;
        public string Password => tbPassword.Text;
        public string ConsumerKey => tbConsumerKey.Text;
        public string ConsumerSecret => tbConsumerSecret.Text;
        public string TokenValue => tbTokenValue.Text;
        public string TokenSecret => tbTokenSecret.Text;
        public string Error
        {
            set
            {
                _lblError.Text = value;
                tableLayoutPanel1.Controls.Add(_lblError, 0, 13);
                tableLayoutPanel1.AutoSize = true;
            }
        }
    }
}
