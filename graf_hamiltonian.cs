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
using System.Threading;
namespace Proiect_Grafuri
{
    public partial class graf_hamiltonian : Form
    {
        public Button[] v = new Button[10];
        public int n = 0;
        public int[,] a11 = new int[10, 10];
        string linie;
        int nr = 0, i, j, p1, p2, p3, p4, x, y, L;

        private void graf_hamiltonian_Load(object sender, EventArgs e)
        {

        }

        Pen p = new Pen(Color.Black, 2);
        public graf_hamiltonian()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader fin = new StreamReader("hamilt.txt");
            while (!fin.EndOfStream)
            {

                linie = fin.ReadLine();


                richTextBox1.AppendText(linie + '\n');

            }
            richTextBox1.Font = new Font(FontFamily.GenericSerif, 12, FontStyle.Italic);
            fin.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void graf_hamiltonian_MouseClick(object sender, MouseEventArgs e)
        {
            n++;
            v[n] = new Button();
            v[n].Location = new Point(e.X, e.Y);
            v[n].Height = 20;
            v[n].Width = 20;
            v[n].Text = n.ToString();
            v[n].Tag = Convert.ToString(n);
            v[n].Click += new EventHandler(v_Click);
            this.Controls.Add(v[n]);
        }
        public void v_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            int nrb = Convert.ToInt32(((Button)sender).Tag);



            nr++;
            if (nr % 2 == 0)
            {
                x = nrb;


                p1 = ((Button)sender).Location.X;
                p2 = ((Button)sender).Location.Y;
                PointF punct1 = new PointF(p1 + 5, p2 + 5);
                PointF punct2 = new PointF(p3 + 5, p4 + 5);
                g.DrawLine(p, punct1, punct2);
                a11[x, y] = 1;
                a11[y, x] = 1;


            }
            else
            {
                y = nrb;
                p3 = ((Button)sender).Location.X;
                p4 = ((Button)sender).Location.Y;


            }
        }
        }
}
