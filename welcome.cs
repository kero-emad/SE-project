using Test1.users;
namespace Test1
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            context c = new context();
            login l=new login();
            l.Show();
            this.Hide();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}