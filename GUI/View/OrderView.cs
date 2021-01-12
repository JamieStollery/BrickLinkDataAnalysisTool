using Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class OrderView : UserControl, IOrderView
    {
        public OrderView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        
        // get/set
        public IEnumerable<string> ItemTypes
        {
            get => clbItemTypes.CheckedItems.Cast<string>();
            set => clbItemTypes.Items.AddRange(value.ToArray());
        }

        // get
        public string ItemCondition => cbItemCondition.SelectedItem?.ToString();

        public string ItemCountType => cbItemCountType.SelectedItem?.ToString();

        public int ItemCount => int.TryParse(tbItemCount.Text, out var count) ? count : 0;

        public string ItemTypeFilterMode => fmsItemTypes.SelectedMode;

        public string ItemConditionFilterMode => fmsItemCondition.SelectedMode;

        public string ItemCountTypeFilterMode => fmsItemCount.SelectedMode;

        // set
        public Action OnSearchButtonClick { set => btnSearch.Click += (sender, e) => value(); }

        public Action OnFilterChanged
        {
            set
            {
                fmsItemTypes.OnModeChanged = value;
                fmsItemCondition.OnModeChanged = value;
                fmsItemCount.OnModeChanged = value;
                clbItemTypes.SelectedValueChanged += (sender, e) => value();
                cbItemCondition.SelectedValueChanged += (sender, e) => value();
                cbItemCountType.SelectedValueChanged += (sender, e) => value();
                tbItemCount.TextChanged += (sender, e) => value();
            }
        }

        public Action<int> OnOrderDoubleClick { set => dgvOrders.CellDoubleClick += (sender, e) => value(int.Parse(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString())); }

        public IEnumerable<object> Orders { set => dgvOrders.DataSource = value; }

        public IEnumerable<string> ItemConditions
        {
            set
            {
                cbItemCondition.Items.AddRange(value.ToArray());
                cbItemCondition.SelectedIndex = 0;
            }
        }

        public IEnumerable<string> ItemCountTypes
        {
            set
            {
                cbItemCountType.Items.AddRange(value.ToArray());
                cbItemCountType.SelectedIndex = 0;
            }
        }
    }
}
