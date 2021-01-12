using System;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class FilterModeSelector : UserControl
    {
        public FilterModeSelector()
        {
            InitializeComponent();
            rb1.CheckedChanged += (sender, e) => 
            {
                if (!rb1.Checked) return;
                rb2.Checked = false;
                OnModeChanged();
            };
            rb2.CheckedChanged += (sender, e) =>
            {
                if (!rb2.Checked) return;
                rb1.Checked = false;
                OnModeChanged();
            };
        }

        public Action OnModeChanged { private get; set; }

        public string SelectedMode => rb2.Checked ? rb2.Text : rb1.Text;

        private bool _useMinMax;
        public bool UseMinMax
        {
            get => _useMinMax;
            set 
            {
                if(value)
                {
                    rb1.Text = "Min";
                    rb2.Text = "Max";
                    UseAnyAll = !value;
                }
                _useMinMax = value;
            }
        }

        private bool _useAnyAll;
        public bool UseAnyAll
        {
            get => _useAnyAll;
            set 
            {
                if(value)
                {
                    rb1.Text = "Any";
                    rb2.Text = "All";
                    UseMinMax = !value;
                }
                _useAnyAll = value;
            }
        }
    }
}
