using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6._3._3._2_2_
{
    public partial class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {

            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = pe.Graphics;
            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            if (this.Value > 0)
            {
                // groene balk printen
                Rectangle clip = new Rectangle(rect.X, rect.Y,
                (int)Math.Round(((float)this.Value / this.Maximum) * rect.Width),
                rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }
            using (Font f = new Font(FontFamily.GenericSansSerif, 14))
            {
                // tekst printen in balk
                SizeF size = g.MeasureString(string.Format("{0}", this.Value), f);
                Point location = new Point((int)((rect.Width / 2) - (size.Width /
                2)), (int)((rect.Height / 2) - (size.Height / 2) + 2));
                g.DrawString(string.Format("{0}%", this.Value), f, Brushes.Black,
                location);
            }
            base.OnPaint(pe);
        }
    }
}
