namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] temperetureUnits = { "Celcius", "Kelvin", "Fahrenayt" };
            comboBox1.Items.AddRange(temperetureUnits);
            comboBox2.Items.AddRange(temperetureUnits);
        }
    }
}