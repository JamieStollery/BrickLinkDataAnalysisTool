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
    public partial class MenuView : UserControl, IMenuView
    {
        public MenuView()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        public Action OnLogoutClick { set => miLogout.Click += (sender, e) => value(); }
        public Action OnLoginClick { set => miLogin.Click += (sender, e) => value(); }
        public Action OnRegisterClick { set => miRegister.Click += (sender, e) => value(); }
        public bool LogoutEnabled { set => miLogout.Enabled = value; }
        public bool LoginEnabled { set => miLogin.Enabled = value; }
        public bool RegisterEnabled { set => miRegister.Enabled = value; }
    }
}
