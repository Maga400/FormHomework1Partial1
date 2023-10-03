using FormHomework3.Properties;

namespace FormHomework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.Baku_picture;
        }

        private void LondonButton_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.London_picture1;
        }
    }
}