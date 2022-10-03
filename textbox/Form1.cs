namespace textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string dataUrodzenia = dateTimePicker1.Text;
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Nie podano wszystkich danych.");
            }
            else if(textBox1.TextLength != 0 && textBox2.TextLength != 0)
            {
                MessageBox.Show("Podano imiê: " + imie + ", nazwisko " + nazwisko + ", data urodzenia: " + dataUrodzenia);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}