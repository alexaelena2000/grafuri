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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.Text = "interior";
            textBox2.Text = "Γ+(x)";
            textBox3.Text = "succesori";
            textBox4.Text = "bucla";
            textBox5.Text = "(X,x)";
            textBox6.Text = "d-(x)";
            textBox7.Text = "predecesor";
            textBox8.Text = "incidente";

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
            textBox1.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox1.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox1.DragDrop += new DragEventHandler(textBox16_DragDrop);

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
            textBox2.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox16_DragDrop);

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
            textBox3.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox3.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox3.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox3.DragDrop += new DragEventHandler(textBox16_DragDrop);

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
            textBox4.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox4.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox4.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox4.DragDrop += new DragEventHandler(textBox16_DragDrop);

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
            textBox5.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox5.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox5.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox5.DragDrop += new DragEventHandler(textBox16_DragDrop);

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
            textBox6.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox6.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox6.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox6.DragDrop += new DragEventHandler(textBox16_DragDrop);

            textBox7.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox12_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox16_DragDrop);

            textBox8.DragEnter += new DragEventHandler(textBox9_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox9_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox9_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox10_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox10_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox10_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox11_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox11_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox11_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox12_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox12_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox12_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox13_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox13_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox13_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox14_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox14_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox14_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox15_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox15_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox15_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox16_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox16_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox16_DragDrop);
        }

        private void textBox9_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox9_DragEnter(object sender, DragEventArgs e)
        {
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox9_DragDrop(object sender, DragEventArgs e)
        {
            textBox9.Text = e.Data.GetData(DataFormats.Text).ToString();

        }
        
        private void textBox10_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox10_DragEnter(object sender, DragEventArgs e)
        {
                e.Effect = DragDropEffects.Copy;
         }

        private void textBox10_DragDrop(object sender, DragEventArgs e)
        {
            textBox10.Text = e.Data.GetData(DataFormats.Text).ToString();
        }



        private void textBox11_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox11_DragEnter(object sender, DragEventArgs e)
        {
            
                e.Effect = DragDropEffects.Copy;
       
        }

        private void textBox11_DragDrop(object sender, DragEventArgs e)
        {
            textBox11.Text = e.Data.GetData(DataFormats.Text).ToString();
        }




        private void textBox12_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox12_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
            
        }

        private void textBox12_DragDrop(object sender, DragEventArgs e)
        {
            textBox12.Text = e.Data.GetData(DataFormats.Text).ToString();
        }



        private void textBox13_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox13_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
           
        }

        private void textBox13_DragDrop(object sender, DragEventArgs e)
        {
            textBox13.Text = e.Data.GetData(DataFormats.Text).ToString();
        }



        private void textBox14_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox14_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
           
        }

        private void textBox14_DragDrop(object sender, DragEventArgs e)
        {
            textBox14.Text = e.Data.GetData(DataFormats.Text).ToString();
        }



        private void textBox15_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox15_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
         
        }

        private void textBox15_DragDrop(object sender, DragEventArgs e)
        {
            textBox15.Text = e.Data.GetData(DataFormats.Text).ToString();
        }


        private void textBox16_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox16_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
          
        }

        private void textBox16_DragDrop(object sender, DragEventArgs e)
        {
            textBox16.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
                f.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
