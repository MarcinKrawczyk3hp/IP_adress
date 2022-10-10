namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(maskedTextBox1.Text, out box_int);
            if (box_int <255 && maskedTextBox1.Text !="")
                {
                MessageBox.Show("Adres IP jest poprawny");

            }
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = maskedTextBox1.Text;
            string text2 =  maskedTextBox2.Text;
            label1.Text = "IP: " + maskedTextBox1.Text + " maska: " + maskedTextBox2.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}