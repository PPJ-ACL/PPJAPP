using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D; //Se exporta Libreria Drawing Y Drawing 2D 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class DegradePanel : Panel
    {
        public Color ColorTop { get; set; } 
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);

        }
    }
}
