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
    public partial class Form6 : Form
    {
        string linie;
        public Form6()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader fin = new StreamReader("subgraf.txt");
            while (!fin.EndOfStream)
            {

                linie = fin.ReadLine();


                richTextBox1.AppendText(linie + '\n');

            }
            fin.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            StreamReader fin = new StreamReader("graf_partial.txt");
            while (!fin.EndOfStream)
            {

                linie = fin.ReadLine();


                richTextBox2.AppendText(linie + '\n');

            }
            fin.Close();
        }
    }
}
