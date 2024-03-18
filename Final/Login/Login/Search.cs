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

namespace Login
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=kept;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();

            string name =textBox1.Text;
            string query = "select * from Children ,Parent , Insti Where ChildName Like '%"+name+"%'";


            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }
    }
}
