using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_UI
{
    public partial class PieChart : UserControl
    {
        private float[] values;
        private Color[] colors;

        // Properties for the data and colors
        public float[] Values
        {
            get => values;
            set
            {
                values = value;
                Invalidate(); // Redraw the control when data changes
            }
        }

        public Color[] Colors
        {
            get => colors;
            set
            {
                colors = value;
                Invalidate(); // Redraw the control when colors change
            }
        }

        // Constructor
        public PieChart()
        {
            InitializeComponent();
            values = new float[0];
            colors = new Color[0];
            this.Resize += (sender, e) => Invalidate(); // Redraw on resize
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (values.Length == 0 || colors.Length == 0 || values.Length != colors.Length)
                return; // Exit if data is missing or mismatched

            float total = 0;
            foreach (float val in values)
                total += val;

            if (total <= 0)
                return; // Exit if total is 0 or invalid

            float startAngle = 0;
            float sweepAngle;

            // Get the bounding rectangle for the pie chart
            Rectangle pieRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Draw each slice of the pie
            for (int i = 0; i < values.Length; i++)
            {
                sweepAngle = (values[i] / total) * 360; // Calculate angle based on value

                //sweepAngle = (values[i] / total) * 180; //for a half size pie graph
                //sweepAngle *= -1;

                using (Brush brush = new SolidBrush(colors[i]))
                {
                    e.Graphics.FillPie(brush, pieRect, startAngle, sweepAngle);
                }
                startAngle += sweepAngle; // Move the start angle for the next slice
            }
            int shift = 75;
            Rectangle circle = new Rectangle(shift, shift, this.Width - shift * 2, this.Height - shift * 2);
            Pen pen = new Pen(Color.White, 65);
            e.Graphics.DrawEllipse(pen, circle);
            shift = 90;
            circle = new Rectangle(shift, shift, this.Width - shift * 2, this.Height - shift * 2);
            Brush fill = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(fill, circle);
        }
    }
}
