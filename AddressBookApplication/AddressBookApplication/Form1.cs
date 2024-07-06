namespace AddressBookApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phoneNumber = textBox3.Text;

            string data = $"---------------------------------\nName: {name} \nEmail: {email} \nPhone Number: {phoneNumber} \n---------------------------------";

            File.WriteAllText("addressbook.txt", data);
            MessageBox.Show("Information saved as addressbook.txt! \n In the project directory, locate /bin/Debug/net8.0-windows");
        }
    }
}
