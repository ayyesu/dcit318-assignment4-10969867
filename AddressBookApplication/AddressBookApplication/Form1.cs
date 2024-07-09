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

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.FileName = "addressbook";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, data);
                MessageBox.Show("Information saved successfully!");
            }
            else
            {
                MessageBox.Show("Save operation cancelled.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
