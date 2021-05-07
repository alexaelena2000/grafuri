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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            textBox1.DragEnter += new DragEventHandler(textBox7_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox7_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox7_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox8_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox8_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox8_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox12_DragDrop);

            textBox2.DragEnter += new DragEventHandler(textBox7_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox7_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox7_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox8_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox8_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox8_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox12_DragDrop);

            textBox3.DragEnter += new DragEventHandler(textBox7_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox7_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox7_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox8_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox8_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox8_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox12_DragDrop);

            textBox4.DragEnter += new DragEventHandler(textBox7_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox7_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox7_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox8_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox8_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox8_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox12_DragDrop);

            textBox5.DragEnter += new DragEventHandler(textBox7_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox7_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox7_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox8_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox8_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox8_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox12_DragDrop);

            textBox6.DragEnter += new DragEventHandler(textBox7_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox7_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox7_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox8_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox8_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox8_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox12_DragDrop);
        }
        private void textBox7_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox7_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox7_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }


        private void textBox8_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox8_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox8_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }
        
        private void textBox9_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox9_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox9_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }




        private void textBox10_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox10_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox10_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }



        private void textBox11_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox11_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox11_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }




        private void textBox12_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox12_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox12_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
        }
    }
}
