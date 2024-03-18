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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=kept;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();
            string query = "Select * from Children,Parent,Insti ";


            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
