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
            btnHideFilters.Click += (sender, e) =>
            {
                if (splitContainer1.Panel2Collapsed)
                {
                    splitContainer1.Panel2Collapsed = false;
                    btnHideFilters.Text = "v";
                } else
                {
                    splitContainer1.Panel2Collapsed = true;
                    btnHideFilters.Text = "^";
                }
            };

            // This commits the dgv changes and fires the CellValueChanged event on CellContentClick
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.cellvaluechanged?view=net-5.0
            dgvColors.CellContentClick += (sender, e) => dgvColors.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        public IEnumerable<string> ItemTypes
        {
            get => clbItemTypes.CheckedItems.Cast<string>();
            set => clbItemTypes.Items.AddRange(value.ToArray());
        }

        public string ItemCondition => cbItemCondition.SelectedItem?.ToString();

        public string ItemSearchType => cbItemSearchType.SelectedItem?.ToString();

        public string ItemSearchValue => tbItemSearchValue.Text;

        public string ItemSearchFilterMode => fmsItemSearch.SelectedMode;

        public string ItemCountFilterMode => fmsItemCount.SelectedMode;

        public int ItemCount => int.TryParse(tbItemCount.Text, out var count) ? count : 0;

        public Action OnFilterChanged
        {
            set
            {
                fmsItemSearch.OnModeChanged = value;
                fmsItemCount.OnModeChanged = value;
                tbItemSearchValue.TextChanged += (sender, e) => value();
                cbItemSearchType.SelectedValueChanged += (sender, e) => value();
                cbItemCondition.SelectedValueChanged += (sender, e) => value();
                clbItemTypes.SelectedValueChanged += (sender, e) => value();
                dgvColors.CellValueChanged += (sender, e) => value();
                tbItemCount.TextChanged += (sender, e) => value();
            }
        }

        public Action OnViewOpened { set => Load += (sender, e) => value(); }

        public Action OnBackButtonClick { set => btnBack.Click += (sender, e) => value(); }

        public IEnumerable<string> ItemSearchTypes
        {
            set
            {
                cbItemSearchType.Items.AddRange(value.ToArray());
                cbItemSearchType.SelectedIndex = 0;
            }
        }

        public IEnumerable<object> Items { set => dgvItems.DataSource = value; }

        public IEnumerable<string> ItemConditions
        {
            set
            {
                cbItemCondition.Items.AddRange(value.ToArray());
                cbItemCondition.SelectedIndex = 0;
            }
        }

        public IEnumerable<object> Colors
        {
            set
            {
                dgvColors.DataSource = value;
                foreach(DataGridViewColumn column in dgvColors.Columns)
                {
                    column.ReadOnly = column.Name != nameof(ColorVm.Checked);
                }
                dgvColors.Columns[dgvColors.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void RePaintItem(string number, int inventoryId)
        {
            var rowIndex = dgvItems.Rows.Cast<DataGridViewRow>().Single(row => 
                row.Cells[nameof(ItemVm.Number)].Value.ToString() == number &&
                int.Parse(row.Cells[nameof(ItemVm.InventoryId)].Value.ToString()) == inventoryId).Index;
            dgvItems.InvalidateRow(rowIndex);
        }
    }
}
