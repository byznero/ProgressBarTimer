namespace soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            MessageBox.Show("Ýþlem baþlatýldý! Lütfen bekleyin.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Ýþlem durduruldu! Lütfen bekleyin.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 267;
            progressBar1.Minimum = 0;
            timer1.Interval = 3000;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Ýþlem tamamlandý!");
            }
        }
    }
}
