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
        public RegisterView()
        {
            InitializeComponent();
        }

        public Action OnRegisterButtonClick { set => btnRegister.Click += (sender, e) => value(); }
    }
}
