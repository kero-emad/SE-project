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
    public partial class go : Form
    {
        context db = new context();
        public go()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {
            var showorders=db.orders.ToList();
            dataGridView1.DataSource=showorders;
           // dataGridView1.DataSource=showorders.ToList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit" ,UseColumnTextForButtonValue=true});
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int order = Convert.ToInt32(row.Cells["order_id"].Value);
                orders select = db.orders.Where(a =>a.order_Id == order).FirstOrDefault();


                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    if (select !=null)
                    {
                        Edit edit = new Edit(select);
                        edit.Show();
                    }
                    
                }
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    MessageBox.Show("Deleted");
                }
                 
            }
        }

        private void go_Load(object sender, EventArgs e)
        {

        }
    }
}
