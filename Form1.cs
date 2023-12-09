namespace MagcalasCullen_CSCI366_GroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            library1.Hide();
            store1.Show();
            //store1.BringToFront();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            store1.Hide();
            library1.Show();
            //library1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            store1.Show();
            library1.Hide();
        }
    }
}