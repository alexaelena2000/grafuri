using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_Grafuri
{
    public partial class primaforma : Form
    {
        public static string a1, a2;
        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexandra\Desktop\Proiect Grafuri(1)\Proiect Grafuri\Proiect Grafuri\Database1.mdf;Integrated Security=True");
        public primaforma()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            string insert = @"insert into utilizatori (utilizator, parola, email) values (@utilizator,@parola,@email)";
            SqlCommand cmd = new SqlCommand(insert, c);
            if (textBox4.Text == textBox5.Text)
            {
                cmd.Parameters.AddWithValue("utilizator", textBox3.Text);
                cmd.Parameters.AddWithValue("parola", textBox4.Text);
                cmd.Parameters.AddWithValue("email", textBox5.Text);
            }
            else MessageBox.Show("Parolele nu coincid");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {

            }
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            
            c.Close();
        }

   

        private void primaforma_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (String.Compare(textBox7.Text, "admin") == 0 && String.Compare(textBox8.Text, "admin") == 0)
            {
                admin f = new admin();
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            string select = "select utilizator, parola from utilizatori";
            SqlCommand cmd = new SqlCommand(select, c);
            SqlDataReader r = cmd.ExecuteReader();
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            bool ok = false;
            while (r.Read())
            {

                if (String.Compare(s1, r[0].ToString().Trim()) == 0 && String.Compare(s2, r[1].ToString().Trim()) == 0)
                {
                    ok = true;
                    a1 = r[0].ToString().Trim();
                    a2 = r[1].ToString().Trim();

                }
            }
            if (ok == true)
            {
                Form1 f = new Form1();
                f.Show();      
                       
            }
            else
                MessageBox.Show("Mai Încearcă");
            c.Close();
        }
    }
}
