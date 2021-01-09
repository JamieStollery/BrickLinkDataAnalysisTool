using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Windows.Forms;

namespace GUI.View.Stage
{
    public partial class MainStageView : Form, IMainStageView
    {
        public MainStageView()
        {
            InitializeComponent();
        }

        public Action OnStageOpened { set => Shown += (sender, e) => value(); }
        public Action OnStageClosed { set => FormClosed += (sender, e) => value(); }
        public Action OnLogoutClick { set => miLogout.Click += (sender, e) => value(); }
        public Action OnLoginClick { set => miLogin.Click += (sender, e) => value(); }
        public Action OnRegisterClick { set => miRegister.Click += (sender, e) => value(); }
        public bool LogoutEnabled { set => miLogout.Enabled = value; }
        public bool LoginEnabled { set => miLogin.Enabled = value; }
        public bool RegisterEnabled { set => miRegister.Enabled = value; }
        public string Username { set => tbUsername.Text = value; }

        public void OpenStage() => Show();

        public void CloseStage() => Close();

        public void AddView(IView view) => pnlViewStage.Controls.Add(view as Control);

        public void RemoveView(IView view) => pnlViewStage.Controls.Remove(view as Control);
    }
}
