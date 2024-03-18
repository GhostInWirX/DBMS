using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuInterface : Form
    {
        public MenuInterface()
        {
            InitializeComponent();
        }

        private void MenuInterface_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Credits f5 = new Credits();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admission f2 = new Admission();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update f3 = new Update();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete f4 = new Delete();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search f5 = new Search();
            f5.Show();
        }
    }
}
