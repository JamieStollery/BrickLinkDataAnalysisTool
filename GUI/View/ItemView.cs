using Presentation.View.Interface;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI.View
{
    public partial class ItemView : UserControl, IItemView
    {
        public ItemView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void RePaintItem(string number, int inventoryId)
        {
            var rowIndex = dgvItems.Rows.Cast<DataGridViewRow>().Single(row => 
                row.Cells[nameof(ItemVm.Number)].Value.ToString() == number &&
                int.Parse(row.Cells[nameof(ItemVm.InventoryId)].Value.ToString()) == inventoryId).Index;
            dgvItems.InvalidateRow(rowIndex);
        }

        public Action OnViewOpened { set => Load += (sender, e) => value(); }
        public Action OnBackButtonClick { set => btnBack.Click += (sender, e) => value(); }
        public IEnumerable<object> Items { set => dgvItems.DataSource = value; }
    }
}
