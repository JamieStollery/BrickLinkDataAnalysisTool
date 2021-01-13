using System.Drawing;

namespace Presentation.View.Model
{
    public class ItemVm
    {
        public Image Image { get; set; }
        public string Number { get; set; }
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public int Quantity { get; set; }
        public string Condition { get; set; }
        public string Completeness { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string FinalUnitPrice { get; set; }
    }
}
