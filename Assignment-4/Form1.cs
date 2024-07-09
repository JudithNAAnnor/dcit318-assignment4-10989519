namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textName.Text;
            password = textPassword.Text;
            MessageBox.Show($"\n {username} is your username \n {password} is your password");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
