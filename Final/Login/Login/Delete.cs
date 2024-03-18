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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=kept;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();

            int ID = int.Parse(textBox1.Text);

            string Query = "DELETE FROM Children WHERE ChildID =" + ID ;
            string query2 = "DELETE FROM Parent WHERE Child =" + ID;
            string query3 = "DELETE FROM Insti WHERE Child =" + ID;

            SqlCommand cmd = new SqlCommand(Query,con);
            SqlCommand cmd1 = new SqlCommand(query2,con);
            SqlCommand cmd2= new SqlCommand(query3,con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Has Been Expelled From Institution");

        }
    }
}
