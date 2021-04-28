using Presentation.View.Interface;
using System;
using System.Windows.Forms;

namespace GUI.View.Stage
{
    public partial class MainStageView : Form, IMainStageView
    {
        public MainStageView(ToolStripRenderer toolStripRenderer)
        {
            InitializeComponent();
            msMenu.Renderer = toolStripRenderer;
            statusStrip1.Renderer = toolStripRenderer;
            WindowState = FormWindowState.Maximized;
        }

        public Action OnStageOpened { set => Shown += (sender, e) => value(); }
        public Action OnStageClosed { set => FormClosed += (sender, e) => value(); }
        public Action OnLogoutClick { set => miLogout.Click += (sender, e) => value(); }
        public Action OnLoginClick { set => miLogin.Click += (sender, e) => value(); }
        public Action OnRegisterClick { set => miRegister.Click += (sender, e) => value(); }
        public Action OnChangeDataModeClick { set => miChangeDataMode.Click += (sender, e) => value(); }
        public Action OnUpdateDatabaseClick { set => miUpdateDatabase.Click += (sender, e) => value(); }
        public Action OnClearDatabaseClick { set => miClearDatabase.Click += (sender, e) => value(); }
        public bool LogoutEnabled { set => miLogout.Enabled = value; }
        public bool LoginEnabled { set => miLogin.Enabled = value; }
        public bool RegisterEnabled { set => miRegister.Enabled = value; }
        public bool DatabaseControlsEnabled { set => miDatabase.Enabled = value; }
        public string Username
        {
            set
            {
                tbUsername.Text = $"Username: {value}";
                tbUsername.Size = TextRenderer.MeasureText(tbUsername.Text, tbUsername.Font);
            }
        }
        public string DataMode
        {
            set
            {
                tbDataMode.Text = $"Data Mode: {value}";
                tbDataMode.Size = TextRenderer.MeasureText(tbDataMode.Text, tbDataMode.Font);
            }
        }
        public string Status { set => lblTaskLabel.Text = value; }
        public int ProgressBarLength { set => pbTaskProgress.Maximum = value; }

        public int ProgressBarProgress
        {
            get => pbTaskProgress.Value;
            set => pbTaskProgress.Value = value;
        }


        public void OpenStage() => Show();

        public void CloseStage()
        {
            Close();
            Application.Exit();
        }


        public void AddView(IView view) => pnlViewStage.Controls.Add(view as Control);

        public void RemoveView(IView view) => pnlViewStage.Controls.Remove(view as Control);
    }
}
