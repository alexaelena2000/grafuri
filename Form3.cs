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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
           
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Text = "izolat";
            textBox7.Text = "terminal";
            textBox8.Text = "adicente";
            textBox9.Text = "incidente";
            textBox10.Text = "gradul";
            textBox2.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox1_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox3_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox3_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox3_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox4_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox4_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox4_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox5_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox5_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox5_DragDrop);
            textBox2.DragEnter += new DragEventHandler(textBox6_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox6_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox6_DragDrop);

            textBox7.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox1_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox3_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox3_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox3_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox4_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox4_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox4_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox5_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox5_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox5_DragDrop);
            textBox7.DragEnter += new DragEventHandler(textBox6_DragEnter);
            textBox7.MouseDown += new MouseEventHandler(textBox6_MouseDown);
            textBox7.DragDrop += new DragEventHandler(textBox6_DragDrop);

            textBox8.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox1_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox3_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox3_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox3_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox4_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox4_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox4_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox5_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox5_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox5_DragDrop);
            textBox8.DragEnter += new DragEventHandler(textBox6_DragEnter);
            textBox8.MouseDown += new MouseEventHandler(textBox6_MouseDown);
            textBox8.DragDrop += new DragEventHandler(textBox6_DragDrop);

            textBox9.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox9.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            textBox9.DragDrop += new DragEventHandler(textBox1_DragDrop);
            textBox9.DragEnter += new DragEventHandler(textBox3_DragEnter);
            textBox9.MouseDown += new MouseEventHandler(textBox3_MouseDown);
            textBox9.DragDrop += new DragEventHandler(textBox3_DragDrop);
            textBox9.DragEnter += new DragEventHandler(textBox4_DragEnter);
            textBox9.MouseDown += new MouseEventHandler(textBox4_MouseDown);
            textBox9.DragDrop += new DragEventHandler(textBox4_DragDrop);
            textBox9.DragEnter += new DragEventHandler(textBox5_DragEnter);
            textBox9.MouseDown += new MouseEventHandler(textBox5_MouseDown);
            textBox9.DragDrop += new DragEventHandler(textBox5_DragDrop);
            textBox9.DragEnter += new DragEventHandler(textBox6_DragEnter);
            textBox9.MouseDown += new MouseEventHandler(textBox6_MouseDown);
            textBox9.DragDrop += new DragEventHandler(textBox6_DragDrop);

            textBox10.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox10.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            textBox10.DragDrop += new DragEventHandler(textBox1_DragDrop);
            textBox10.DragEnter += new DragEventHandler(textBox3_DragEnter);
            textBox10.MouseDown += new MouseEventHandler(textBox3_MouseDown);
            textBox10.DragDrop += new DragEventHandler(textBox3_DragDrop);
            textBox10.DragEnter += new DragEventHandler(textBox4_DragEnter);
            textBox10.MouseDown += new MouseEventHandler(textBox4_MouseDown);
            textBox10.DragDrop += new DragEventHandler(textBox4_DragDrop);
            textBox10.DragEnter += new DragEventHandler(textBox5_DragEnter);
            textBox10.MouseDown += new MouseEventHandler(textBox5_MouseDown);
            textBox10.DragDrop += new DragEventHandler(textBox5_DragDrop);
            textBox10.DragEnter += new DragEventHandler(textBox6_DragEnter);
            textBox10.MouseDown += new MouseEventHandler(textBox6_MouseDown);
            textBox10.DragDrop += new DragEventHandler(textBox6_DragDrop);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penita = new Pen(Color.Black, 1);
            PointF punct1 = new PointF(21.0F, 208.0F);
            PointF punct2 = new PointF(146.0F, 153.0F);
            PointF punct4 = new PointF(297.0F, 294.0F);
            PointF punct5 = new PointF(93.0F, 338.0F);
            g.DrawLine(penita, punct1, punct2);
            g.DrawLine(penita, punct2, punct4);
            g.DrawLine(penita, punct1, punct5);
            g.DrawLine(penita, punct2, punct5);
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox3_DragEnter(object sender, DragEventArgs e)
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

        private void textBox3_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox4_DragEnter(object sender, DragEventArgs e)
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

        private void textBox4_DragDrop(object sender, DragEventArgs e)
        {

            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox5_DragEnter(object sender, DragEventArgs e)
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

        private void textBox5_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void textBox6_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox6_DragEnter(object sender, DragEventArgs e)
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

        private void textBox6_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
                f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
