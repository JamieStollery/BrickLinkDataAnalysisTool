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
    public partial class ItemView : UserControl, IItemView
    {
        public ItemView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public ItemView(IReadOnlyList<object> items) : this()
        {
            dgvItems.DataSource = items;
        }

        public Action OnBackButtonClick { set => btnBack.Click += (sender, e) => value(); }
    }
}
