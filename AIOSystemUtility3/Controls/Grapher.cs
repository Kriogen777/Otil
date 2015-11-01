using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class Grapher : UserControl
    {
        double[,] points = null;
        int sets = 1;
        double max = 100;
        string[] keys = null;
        bool dynamicMax = false;

        public Grapher()
            : this(60, 2, 100, false)
        {
        }

        public Grapher(int xPoints = 60, int sets = 2, int max = 100, bool dynamicMax = false)
        {
            InitializeComponent();
            xPoints = xPoints == 0 ? 60 : xPoints;
            sets = sets == 0 ? 1 : sets;
            points = new double[sets, xPoints];
            keys = new string[sets];
            this.sets = sets;
            this.max = max;
            this.dynamicMax = dynamicMax;
        }

        public void SetDynamicMax(bool dynamicMax)
        {
            this.dynamicMax = dynamicMax;
        }

        public void SetKeyItem(int setNumber, string value)
        {
            if (setNumber < sets && setNumber >= 0)
            {
                keys[setNumber] = value;
            }
        }

        public void UpdateGraph(int setNumber = 0, double yValue = 0)
        {
            if (setNumber + 1 <= sets)
            {
                for (int i = 0; i < points.Length / sets - 1; i++)
                {
                    points[setNumber, i] = points[setNumber, i + 1];
                }
                points[setNumber, points.Length / sets - 1] = yValue;
                if (dynamicMax)
                {
                    max = 0;
                    foreach (double i in points)
                    {
                        if (i > max) max = i;
                    }
                    if (max == 0) max++;
                }
                this.Invalidate();
            }
        }

        private void Grapher_Paint(object sender, PaintEventArgs e)
        {
            // Graphics Settings
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Pens and Brushes
            Pen graph1Pen = new Pen(Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3], 1);
            Pen graph2Pen = new Pen(Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4], 1);
            Pen gridPen = new Pen(Color.FromArgb(100, Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3]), 1);
            SolidBrush poly1Brush = new SolidBrush(Color.FromArgb(50, Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3]));
            SolidBrush poly2Brush = new SolidBrush(Color.FromArgb(50, Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4]));

            // Horizontal Lines
            for (int y = 1; y < 10; y++)
            {
                g.DrawLine(gridPen, 0, (int)(y * this.Height / 10), this.Width, (int)(y * this.Height / 10));
            }

            for (int x = 0; x < sets; x++)
            {
                for (int y = 0; y < (points.Length / sets) - 1; y++)
                {
                    // Vertical Lines
                    if (y % 10 == 0)
                        g.DrawLine(gridPen, y * this.Width / (points.Length / sets), 0, y * this.Width / (points.Length / sets), this.Height);
                    // Points
                    float x1 = y * this.Width / ((points.Length / sets) - 1);
                    float y1 = (float)Math.Round((this.Height - ((this.Height * points[x, y]) / max)),5); // was 100
                    float x2 = (y + 1) * this.Width / ((points.Length / sets) - 1);
                    float y2 = (float)Math.Round((this.Height - ((this.Height * points[x, y + 1]) / max)), 5); // was 100

                    if (float.IsNegativeInfinity(y1) || float.IsNaN(y1)) y1 = 0;
                    if (float.IsNegativeInfinity(y2) || float.IsNaN(y2)) y2 = 0;
                    if (float.IsPositiveInfinity(y1)) y1 = this.Height;
                    if (float.IsPositiveInfinity(y2)) y2 = this.Height;

                    // Under Fill
                    PointF[] poly = new PointF[] { new PointF(x1, y1), new PointF(x2, y2), new PointF(x2, this.Height), new PointF(x1, this.Height) };
                    g.FillPolygon(x % 2 == 0 ? poly1Brush : poly2Brush, poly);
                    // Lines
                    g.DrawLine(x % 2 == 0 ? graph1Pen : graph2Pen, x1, y1, x2, y2);
                }
            }

            // Set up to Write
            poly1Brush.Color = Color.FromArgb(255, Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][3]);
            poly2Brush.Color = Color.FromArgb(255, Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4]);
            Font segoe = new Font("Segoe UI Light", 14);
            g.DrawString(max.ToString("0.##"), segoe, poly1Brush, 5, 5);

            // Keys
            float top = 5;
            float left = this.Width;
            for (int i = 0; i < keys.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(keys[i]))
                {
                    SizeF size = g.MeasureString(keys[i], segoe);
                    left = this.Width - 5 - size.Width < left ? this.Width - 5 - size.Width : left;
                }
            }
            for (int i = 0; i < keys.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(keys[i]))
                {
                    SizeF size = g.MeasureString(keys[i], segoe);
                    g.DrawString(keys[i], segoe, i % 2 == 0 ? poly1Brush : poly2Brush, left, top);
                    g.FillRectangle(i % 2 == 0 ? poly1Brush : poly2Brush, left - size.Height / 2, top + size.Height / 4, size.Height / 2, size.Height / 2);
                    top += size.Height + 5;
                }
            }

            // Outline
            g.DrawRectangle(graph1Pen, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void Grapher_Resize(object sender, System.EventArgs e)
        {
            this.Refresh();
        }
    }
}
