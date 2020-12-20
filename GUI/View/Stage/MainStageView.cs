using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Windows.Forms;

namespace GUI.View.Stage
{
    public partial class MainStageView : Form, IStageView
    {
        public MainStageView()
        {
            InitializeComponent();
        }

        public Action OnOpened { set => Shown += (sender, e) => value(); }

        public void OpenStage() => Show();

        public void CloseStage() => Close();

        public void AddView(IView view) => (view is IMenuView ? Controls : pnlViewStage.Controls).Add(view as Control);

        public void RemoveView(IView view) => Controls.Remove(view as Control);
    }
}
