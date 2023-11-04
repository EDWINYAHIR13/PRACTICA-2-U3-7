namespace PRACTICA_2_U3_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangi, rangs, suma = 0;
            rangi = int.Parse(textBox1.Text);
            rangs = int.Parse(textBox2.Text);
            for (int i = rangi; i <= rangs; i++)
            {
                listBox1.Items.Add(i);
                suma = suma+i;
            }
            textBox3.Text=suma.ToString();
        }
    }
}