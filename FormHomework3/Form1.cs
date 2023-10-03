using FormHomework3.Properties;

namespace FormHomework3
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.Baku_picture;
            Label timeLabel = new Label();
            timeLabel.Location = new Point(203, 200);

            timeLabel.Text = DateTime.Now.ToLongTimeString();

            Controls.Add(timeLabel);
        }

        private void LondonButton_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.London_picture1;
            Label timeLabel = new Label();
            timeLabel.Location = new Point(473, 200);

            int hour = DateTime.Now.Hour - 2;
            int minute = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;

            string fullTime = hour.ToString() + ":" + minute.ToString() + ":" + seconds.ToString();
            timeLabel.Text = fullTime;

            Controls.Add(timeLabel);
            
        }

    }
}