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
                OnModeChanged?.Invoke();
            };
            rb2.CheckedChanged += (sender, e) =>
            {
                if (!rb2.Checked) return;
                rb1.Checked = false;
                OnModeChanged?.Invoke();
            };
        }

        public Action OnModeChanged { private get; set; }

        public string SelectedMode => rb2.Checked ? rb2.Text : rb1.Text;

        public string Mode1Text
        {
            get => rb1.Text;
            set => rb1.Text = value;
        }

        public string Mode2Text
        {
            get => rb2.Text;
            set => rb2.Text = value;
        }
        
        public bool Mode1Checked
        {
            get => rb1.Checked;
            set => rb1.Checked = value;
        }
        public bool Mode2Checked
        {
            get => rb2.Checked;
            set => rb2.Checked = value;
        }

    }
}
