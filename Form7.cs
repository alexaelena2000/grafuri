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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Show();
            button7.Show();
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 2);
            PointF punct1 = new PointF(29.0F, 250.0F);
            PointF punct2 = new PointF(246.0F, 250.0F);
            g.DrawLine(penita, punct1, punct2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button8.Show();
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 2);
            PointF punct1 = new PointF(29.0F, 250.0F);
            PointF punct2 = new PointF(246.0F, 250.0F);
            PointF punct3 = new PointF(135.0F, 155.0F);
            PointF punct4 = new PointF(129.0F, 136.0F);
            g.DrawLine(penita, punct1, punct2);
            g.DrawLine(penita, punct1, punct3);
            g.DrawLine(penita, punct4, punct2);

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button9.Show();
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 2);
            PointF punct3 = new PointF(145.0F, 136.0F);
            PointF punct4 = new PointF(145.0F, 330.0F);
            PointF punct2 = new PointF(246.0F, 250.0F);
            PointF punct1 = new PointF(29.0F, 250.0F);
            g.DrawLine(penita, punct3, punct4);
            g.DrawLine(penita, punct4, punct2);
            g.DrawLine(penita, punct4, punct1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Show();
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 2);
            PointF punct5 = new PointF(246.0F, 330.0F);
            PointF punct3 = new PointF(129.0F, 136.0F);
            PointF punct1 = new PointF(29.0F, 250.0F);
            PointF punct2 = new PointF(246.0F, 250.0F);
            PointF punct4 = new PointF(145.0F, 330.0F);
            g.DrawLine(penita, punct3, punct5);
            g.DrawLine(penita, punct1, punct5);
            g.DrawLine(penita, punct2, punct5);
            g.DrawLine(penita, punct4, punct5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }
    }
}
