using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test1.users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Test1
{
    
    public partial class signup : Form
    {
        //string selectedimagepath = "";
        //string projectimagepath = Environment.CurrentDirectory + "\\images";
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            context cd = new context();
            customers c1 = new customers()
            {
                customer_name = name_box.Text,
                customer_username = username_box.Text,
                customer_gender = (_Gender)gender_box.SelectedIndex,
                customer_birth = birth_box.Value,
                customer_email = email_box.Text,
                customer_password = password_box.Text,
                customer_img="No Image"
            };

            var ch_user = cd.customers.FirstOrDefault(x => x.customer_username == username_box.Text);
            var ch_email = cd.customers.FirstOrDefault(x => x.customer_email == email_box.Text);
            if (ch_user == null && ch_email == null && !string.IsNullOrWhiteSpace(c1.customer_name) && !string.IsNullOrWhiteSpace(c1.customer_username)&& !string.IsNullOrWhiteSpace(c1.customer_email) && !string.IsNullOrWhiteSpace(c1.customer_password)&& c1.customer_password.Length>=4&&c1.customer_password.Length<=8)
            {
                cd.customers.Add(c1);
                cd.SaveChanges();
         //       if (!string.IsNullOrWhiteSpace(selectedimagepath))
           //     {
             //       string newprojimgpath = projectimagepath + "\\" + c1.customer_username + "_.jpg";
               //     File.Copy(selectedimagepath, newprojimgpath);
                 //   c1.customer_img = newprojimgpath;
                   // cd.SaveChanges();
                //}
                MessageBox.Show("Successfully added");
                login log = new login();
                log.Show();
                this.Hide();
            }
            else if (c1.customer_password.Length<4 || c1.customer_password.Length > 8)
            {
                MessageBox.Show("please Enter password between 4 to 8 charachters only");
            }
            else if (string.IsNullOrWhiteSpace(c1.customer_name))
            {
                MessageBox.Show("please enter your name");
            }
            else if (string.IsNullOrWhiteSpace(c1.customer_username))
            {
                MessageBox.Show("please enter your user name");
            }
            else if (string.IsNullOrWhiteSpace(c1.customer_email))
            {
                MessageBox.Show("please enter your Email");
            }
            else if (ch_user != null)
            {
                MessageBox.Show("user name already exists please try another name");
            }
            else if (ch_email != null)

            {
                MessageBox.Show("Email already exists please login");
            }



        }

        private void img_Click(object sender, EventArgs e)
        {

        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
          //  if (dialog.ShowDialog() == DialogResult.OK)
            //{
              //  MessageBox.Show(dialog.FileName);
               // img.ImageLocation=dialog.FileName;
                //selectedimagepath = dialog.FileName;
            }
        }
    }



