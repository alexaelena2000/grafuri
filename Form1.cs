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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adiacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void reprezentareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void grafuriNeorientateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void grafPartialSiSubgrafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void tipuriDeGrafuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void adiacentaIncidentaGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void grafPartialSiSubgrafToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
        }

        private void listeleVecinilorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.Show();
        }

        private void lantDrumCircuitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void matriceaDrumurilorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void matriceaDeAdiacentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
           
        }

        private void lantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LANT f = new Proiect_Grafuri.LANT();
            f.Show();
        }

        private void parcurgereAdancimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parcurgere_adancime f = new parcurgere_adancime();
            f.Show();
        
        }

        private void parcurgereLatimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parcurgere_latime f = new parcurgere_latime();
            f.Show();
        }

        private void grafuriHamiltonieneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test1 t = new test1();
            t.Show();
        }

        private void podurileDinKonigsbergToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poduri f = new poduri();
            f.Show();
        }

        private void capraSiVarzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capra_varza f = new capra_varza();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
