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
using System.Xml;

namespace Proiect_Grafuri
{
    public partial class admin : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihai 1\Desktop\Proiect Grafuri\Proiect Grafuri\Database1.mdf;Integrated Security=True");
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            try
            {
                XmlReader xmlFile;
                xmlFile = XmlReader.Create("XMLFile1.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "select * from utilizatori";
            c.Open();

            SqlDataAdapter adp = new SqlDataAdapter(select, c);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            string delete = "delete from utilizatori";
            SqlCommand cmd = new SqlCommand(delete, c);
            SqlDataReader r = cmd.ExecuteReader();
         
            c.Close();
        }
    }
}
