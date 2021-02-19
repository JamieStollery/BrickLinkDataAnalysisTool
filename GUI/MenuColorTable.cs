using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class MenuColorTable : ProfessionalColorTable
    {
        private readonly Color _base = Color.FromArgb(18, 28, 37);
        private readonly Color _mouseOver = Color.FromArgb(28, 151, 234);
        private readonly Color _selected = Color.FromArgb(0, 122, 204); 

        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuBorder => Color.Transparent;
        public override Color MenuStripGradientBegin => _base;
        public override Color MenuStripGradientEnd => _base;
        public override Color StatusStripGradientBegin => _base;
        public override Color StatusStripGradientEnd => _base;
        public override Color ToolStripDropDownBackground => _base;
        public override Color ImageMarginGradientBegin => _base;
        public override Color ImageMarginGradientMiddle => _base;
        public override Color ImageMarginGradientEnd => _base;
        public override Color MenuItemSelectedGradientBegin => _mouseOver;
        public override Color MenuItemSelectedGradientEnd => _mouseOver;
        public override Color MenuItemPressedGradientBegin => _selected;
        public override Color MenuItemPressedGradientEnd => _selected;
    }
}
