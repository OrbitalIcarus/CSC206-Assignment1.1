namespace _1._1_GUI_Front_End
{
    public partial class Form1 : Form
    {
        private int secondsElapsed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            lblTimer.Text = secondsElapsed.ToString("D6");
        }
    }
}
