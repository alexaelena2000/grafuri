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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 5);
            Pen penita1 = new Pen(Color.Red, 2);
            PointF punct1 = new PointF(70.0F, 478.0F);
            PointF punct2 = new PointF(193.0F, 304.0F);
            PointF punct3 = new PointF(315.0F, 383.0F);
            PointF punct4 = new PointF(244.0F, 490.0F);
            PointF punct5 = new PointF(75.0F, 359.0F);
            g.DrawLine(penita, 80, 475, 193, 318);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct2, punct3);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct3, punct4);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct1, punct4);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct1, punct5);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct2, punct5);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct2, punct4);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct5, punct3);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(penita, punct1, punct3);
            penita.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;


            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            String drawString = "1";
            g.DrawString(drawString, drawFont, drawBrush, punct1);
            String drawString1 = "2";
            g.DrawString(drawString1, drawFont, drawBrush, punct2);
            String drawString2 = "3";
            g.DrawString(drawString2, drawFont, drawBrush, punct3);
            String drawString3 = "4";
            g.DrawString(drawString3, drawFont, drawBrush, punct4);
            String drawString4 = "5";
            g.DrawString(drawString4, drawFont, drawBrush, punct5);
        }
    }
}
