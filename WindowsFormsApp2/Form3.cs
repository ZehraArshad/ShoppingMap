using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<Point> points = new List<Point>();
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points.Clear();
            pictureBox1.Invalidate();
            show_Length();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count > 1) e.Graphics.DrawLines(Pens.Blue, points.ToArray());

        }
        void show_Length()
        {
            label1.Text = (points.Count) + " point(s), centimeters ";

            if (!(points.Count > 1)) return;

            double len = 0;
            for (int i = 1; i < points.Count; i++)
            {
                len += Math.Sqrt((points[i - 1].X - points[i].X) * (points[i - 1].X - points[i].X)
                            + (points[i - 1].Y - points[i].Y) * (points[i - 1].Y - points[i].Y));
            }
            label1.Text = (points.Count - 1) + " segments, " + (int)len + " centimerters";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (points.Any()) points.Remove(points.Last());
            pictureBox1.Invalidate();
            show_Length();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            points.Add(e.Location);
            pictureBox1.Invalidate();
            show_Length();
        }
    }
}