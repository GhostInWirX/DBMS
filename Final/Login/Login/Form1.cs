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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Kindergarden;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            string Query="insert into dbo.logi(Username, Passwordi)Values('"+Username+ "', '"+Password+"')"; 
            SqlCommand cmd = new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Has Been Registered Successfully!!!");
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

            string Connectionstring = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=Kindergarden;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();
            string Query = "Select * From dbo.logi  where Username='" + textBox1.Text + "'AND Passwordi='" + textBox2.Text + "'"; 

            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                this.Hide();
               MenuInterface f2 = new MenuInterface();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error");
            }
        }
    }
}
