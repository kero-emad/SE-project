using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test1.users;
namespace Test1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup s = new signup();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context db=new context();
            string username = user_box.Text;
            string password = pass_box.Text;
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                var confirm=db.customers.Where(c=>c.customer_username==username && c.customer_password==password).FirstOrDefault();
              if (confirm != null)
                {
                    go g=new go();
                    g.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong user name or password , Try Again");
                }
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please,Enter your name to log in");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please,Enter your password to log in");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
