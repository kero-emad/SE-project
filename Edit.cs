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
    public partial class Edit : Form
    {
        
        private orders order;
        context db = new context();
        public Edit(orders order)
        {

            InitializeComponent();
            this.order = order;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
       
                det.Text = this.order.order_details;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.order.order_details = det.Text;
            db.orders.Update(this.order);
            db.SaveChanges();
            MessageBox.Show("Updated Successfully");
        }
    }
}
