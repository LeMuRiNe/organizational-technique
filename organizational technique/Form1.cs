namespace organizational_technique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinterForm printerForm = new PrinterForm();
            printerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CartridgeForm cartridgeForm = new CartridgeForm();
            cartridgeForm.ShowDialog();
        }
    }
}
