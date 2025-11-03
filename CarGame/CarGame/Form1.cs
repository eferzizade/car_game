namespace CarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int speed = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            speed = 10;
            timer1.Start();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            speed = 0;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxCar.Top -= speed;

            // Yuxarı limit
            if (pictureBoxCar.Top < 0)
                pictureBoxCar.Top = 0;

            // Aşağı limit
            if (pictureBoxCar.Bottom > this.ClientSize.Height)
                pictureBoxCar.Top = this.ClientSize.Height - pictureBoxCar.Height;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pictureBoxCar.Left -= 210;

            // Sol limit
            if (pictureBoxCar.Left < 0)
                pictureBoxCar.Left = 0;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pictureBoxCar.Left += 210;

            // Sağ limit
            if (pictureBoxCar.Right > this.ClientSize.Width)
                pictureBoxCar.Left = this.ClientSize.Width - pictureBoxCar.Width;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            pictureBoxCar.Top += 10;

            // Aşağı limit
            if (pictureBoxCar.Bottom > this.ClientSize.Height)
                pictureBoxCar.Top = this.ClientSize.Height - pictureBoxCar.Height;
        }
    }
}
