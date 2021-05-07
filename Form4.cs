using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Grafuri
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
                f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 2);
            PointF punct1 = new PointF(17.0F, 381.0F);
            PointF punct2 = new PointF(119.0F, 327.0F);
            PointF punct3 = new PointF(258.0F, 312.0F);
            PointF punct4 = new PointF(258.0F, 434.0F);
            PointF punct5 = new PointF(71.0F, 449.0F);
            PointF punct6 = new PointF(162.0F, 449.0F);
            PointF punct7 = new PointF(217.0F, 489.0F);
            g.DrawLine(penita, punct1, punct2);
            g.DrawLine(penita, punct2, punct3);
            g.DrawLine(penita, punct3, punct4);
            g.DrawLine(penita, punct2, punct4);
            g.DrawLine(penita, punct5, punct6);
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct1 = new PointF(17.0F, 381.0F);
            PointF punct2 = new PointF(119.0F, 327.0F);
            g.DrawLine(penita, punct1, punct2);          
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct1 = new PointF(17.0F, 381.0F);
            PointF punct2 = new PointF(119.0F, 327.0F);
            g.DrawLine(penita, punct1, punct2);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct2 = new PointF(119.0F, 327.0F);
            PointF punct3 = new PointF(258.0F, 312.0F);
            g.DrawLine(penita, punct2, punct3);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct2 = new PointF(119.0F, 327.0F);
            PointF punct3 = new PointF(258.0F, 312.0F);
            g.DrawLine(penita, punct2, punct3);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct3 = new PointF(260.0F, 312.0F);
            PointF punct4 = new PointF(258.0F, 434.0F);
            g.DrawLine(penita, punct3, punct4);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct3 = new PointF(260.0F, 312.0F);
            PointF punct4 = new PointF(258.0F, 434.0F);
            g.DrawLine(penita, punct3, punct4);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct5 = new PointF(71.0F, 449.0F);
            PointF punct6 = new PointF(162.0F, 449.0F);
            g.DrawLine(penita, punct5, punct6);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct5 = new PointF(71.0F, 449.0F);
            PointF punct6 = new PointF(162.0F, 449.0F);
            g.DrawLine(penita, punct5, punct6);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct2 = new PointF(119.0F, 327.0F);
            PointF punct4 = new PointF(258.0F, 434.0F);
            g.DrawLine(penita, punct2, punct4);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Red, 2);
            PointF punct2 = new PointF(119.0F, 327.0F);
            PointF punct4 = new PointF(258.0F, 434.0F);
            g.DrawLine(penita, punct2, punct4);
        }
    }
}
