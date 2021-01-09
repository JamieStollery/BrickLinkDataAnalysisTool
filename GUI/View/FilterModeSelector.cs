using System;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class FilterModeSelector : UserControl
    {
        public FilterModeSelector()
        {
            InitializeComponent();
            rbAny.CheckedChanged += (sender, e) => 
            {
                if (!rbAny.Checked) return;
                rbAll.Checked = false;
                OnModeChanged();
            };
            rbAll.CheckedChanged += (sender, e) =>
            {
                if (!rbAll.Checked) return;
                rbAny.Checked = false;
                OnModeChanged();
            };
        }

        public Action OnModeChanged { private get; set; }

        public string SelectedMode => rbAll.Checked ? rbAll.Text : rbAny.Text;
    }
}
