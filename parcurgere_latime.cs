using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace Proiect_Grafuri
{
    public partial class parcurgere_latime : Form
    {
        public Button[] v = new Button[10];
        public int n = 0;
        string linie;
        int[,] a11 = new int[11, 11];
        int nr = 0, i, j, p1, p2, p3, p4, x, y, L;
        Pen p = new Pen(Color.Black, 1);
        Pen pen = new Pen(Color.Red, 1);
        int[] viz = new int[100];
        int[] coada = new int[100];
        public parcurgere_latime()
        {
            InitializeComponent();
        }

        private void parcurgere_latime_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader fin = new StreamReader("BIPARTIT.txt");
            while (!fin.EndOfStream)
            {

                linie = fin.ReadLine();


                richTextBox1.AppendText(linie + '\n');

            }
            richTextBox1.Font = new Font(FontFamily.GenericSerif, 12, FontStyle.Italic);
            fin.Close();
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
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int p1 = 1, u = 1;
            int pl = int.Parse(textBox1.Text);
            for (i = 1; i <= n; i++)
                viz[i] = 0;
            viz[pl] = 1;
            coada[1] = pl;
            while (p1 <= u)
            {
                for (i = 1; i <= n; i++)
                    if (viz[i] == 0 && a11[coada[p1], i] == 1)
                    {

                        u++;
                        coada[u] = i;
                        viz[u] = 1;
                    }
                p1++;
            }

            for (i = 1; i <= u - 1; i++)
            {
                Thread.Sleep(500);
                PointF pt22 = new PointF(140 + (80.0F) + 30 * i, (380.0F));
                SolidBrush b22 = new SolidBrush(Color.Black);
                Font f22 = new Font("Arial", 18, FontStyle.Italic);
                g.DrawString(coada[i].ToString(), f22, b22, pt22);
                g.DrawLine(pen, v[coada[i]].Location.X + 5, v[coada[i]].Location.Y + 5, v[coada[i + 1]].Location.X + 5, v[coada[i + 1]].Location.Y + 5);
            }
        }

        private void parcurgere_latime_MouseClick(object sender, MouseEventArgs e)
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
    }
}
