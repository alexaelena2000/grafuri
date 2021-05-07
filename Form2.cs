using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Proiect_Grafuri
{
    public partial class Form2 : Form
    {
        string linie;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 2);
            PointF punct1 = new PointF(32.0F, 196.0F);
            PointF punct2 = new PointF(141.0F, 169.0F);
            PointF punct3 = new PointF(229.0F, 222.0F);
            PointF punct4 = new PointF(115.0F, 289.0F);
            g.DrawLine(penita, punct1, punct2);
            g.DrawLine(penita, punct3, punct2);
            g.DrawLine(penita, punct2, punct4);
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            

            richTextBox1.Clear();
            StreamReader fin = new StreamReader("f.txt");
            while (!fin.EndOfStream)
            {

                linie = fin.ReadLine();


                richTextBox1.AppendText(linie + '\n');

            }
            fin.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader fin = new StreamReader("f1.txt");
            while (!fin.EndOfStream)
            {

                linie = fin.ReadLine();


                richTextBox1.AppendText(linie + '\n');

            }
            fin.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
