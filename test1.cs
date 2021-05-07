using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_Grafuri
{
    public partial class test1 : Form
    {
        int s1, s2, s3, s;
        public test1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void test1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            s1 = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            s1 = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            s1 = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            s2 = 3;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            s2 = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            s2 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = 1 + s1 + s2 + s3;
            MessageBox.Show(s.ToString());
            string path = "XMLFile1.xml";
            XmlDocument doc = new XmlDocument();
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("nu a fos gasit fisierul");
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlComment comment = doc.CreateComment("This is an XML Generated File");
                doc.AppendChild(declaration);
                doc.AppendChild(comment);
            }
            else
            {
                doc.Load(path); MessageBox.Show("fisier deschis");
            }
            XmlElement root = doc.DocumentElement;
            XmlElement Subroot = doc.CreateElement("elev");
            XmlElement nume = doc.CreateElement("nume");
            XmlElement prenume = doc.CreateElement("prenume");
            XmlElement clasa = doc.CreateElement("clasa");
            XmlElement profil = doc.CreateElement("nota");

            nume.InnerText = textBox1.Text;
            prenume.InnerText = textBox2.Text;
            clasa.InnerText = textBox3.Text;
            profil.InnerText = s.ToString();
            Subroot.AppendChild(nume);
            Subroot.AppendChild(prenume);
            Subroot.AppendChild(clasa);
            Subroot.AppendChild(profil);

            root.AppendChild(Subroot);
            doc.AppendChild(root);
            doc.Save(path);
            MessageBox.Show("inserare reusita");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            s3 = 0;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            s3 = 3;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            s3 = 0;
        }
    }
}
