using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Windows.Forms;

namespace GUI.View.Stage
{
    public partial class ChildStageView : Form, IStageView
    {
        public ChildStageView()
        {
            InitializeComponent();
        }

        public Action OnOpened { set => Shown += (sender, e) => value(); }

        public void OpenStage() => ShowDialog();

        public void CloseStage() => Close();

        public void AddView(IView view) => Controls.Add(view as Control);

        public void RemoveView(IView view) => Controls.Remove(view as Control);
    }
}
