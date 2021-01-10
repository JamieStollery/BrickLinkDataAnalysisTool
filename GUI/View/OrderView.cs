using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Presentation.View.Interface;
using System.Linq;

namespace GUI.View
{
    public partial class OrderView : UserControl, IOrderView
    {
        public OrderView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public Action OnSearchButtonClick { set => btnSearch.Click += (sender, e) => value(); }
        public Action OnFilterChanged
        {
            set
            {
                fmsItemTypes.OnModeChanged = value;
                fmsItemCondition.OnModeChanged = value;
                clbItemTypes.SelectedValueChanged += (sender, e) => value();
                cbItemCondition.SelectedValueChanged += (sender, e) => value();
            }
        }
        public Action<int> OnOrderDoubleClick { set => dgvOrders.CellDoubleClick += (sender, e) => value(int.Parse(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString())); }

        public IEnumerable<string> ItemTypes
        {
            get => clbItemTypes.CheckedItems.Cast<string>();
            set
            {
                clbItemTypes.Items.AddRange(value.ToArray());
                clbItemTypes.MinimumSize = new Size(0, (clbItemTypes.Items.Count + 1) * clbItemTypes.GetItemHeight(0));
            }
        }

        public IEnumerable<object> Orders { set => dgvOrders.DataSource = value; }

        public string ItemTypeFilterMode => fmsItemTypes.SelectedMode;

        public string ItemConditionFilterMode => fmsItemCondition.SelectedMode;

        public string ItemCondition => cbItemCondition.SelectedItem?.ToString();

        public IEnumerable<string> ItemConditions
        {
            set
            {
                cbItemCondition.Items.AddRange(value.ToArray());
                cbItemCondition.SelectedIndex = 0;
            }
        }
    }
}
