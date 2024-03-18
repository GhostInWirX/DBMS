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
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void Admission_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            


                string Connectionstring = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=kept;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connectionstring);

            con.Open();
            int ChildID = int.Parse(textBox1.Text);
            string ChildName = textBox2.Text;
            int ChildAge= int.Parse(textBox3.Text);
            string identity = textBox4.Text;
            string remarks = textBox5.Text;
            string Query = "Insert into dbo.Children(ChildID,ChildName,ChildAge,IdentitMark,Remarks)Values('"+ChildID+"', '"+ChildName+ "', '" + ChildAge+ "', '"+identity+"', '"+remarks+"')";
            //*For Parents *//

            double parentid = double.Parse(textBox6.Text);
            string fathername = textBox7.Text;
            string address = textBox8.Text;
            string Occupation = textBox9.Text;
            string query2 = "insert into dbo.parent(ParentCNIC,Child,FatherName,Address,Occupation)Values('" + parentid + "','" + ChildID + "','" + fathername + "','" + address + "','" + Occupation + "')";
            //*Insert Into Inserti The Data Given By The Clerk Or Dead*//
            int InstiId = int.Parse(textBox13.Text);
            string Block = textBox12.Text;
            string Course = textBox11.Text;
            string rank = textBox10.Text;
            string query3= "insert into insti(Child,Insti_id,bloc,Course,ran)values('"+ChildID+ "','" + InstiId + "','" + Block + "','" + Course + "','" + rank + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(query2, con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(query3, con);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Has Been Added");
        }
    }
}
