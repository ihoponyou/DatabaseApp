using DatabaseApp;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Text.RegularExpressions;

namespace MagcalasCullen_CSCI366_GroupProject
{
    public partial class Form1 : Form
    {
        public int CurrentUserID { get; private set; }

        public Form1()
        {
            CurrentUserID = -1;
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

        private bool isAlphaNumeric(string str)
        {
            Regex re = new Regex("^[a-zA-Z0-9]*$");
            return re.IsMatch(str);
        }

        private void Login()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // validate input = no sql injection!
            if (!(isAlphaNumeric(username) || isAlphaNumeric(password)))
                return;

            NpgsqlDataReader? results = DatabaseManager.Instance.Query(
                $"SELECT customer_id FROM customer" +
                $"WHERE customer_username = {username} AND customer_password = {password}");

            if (results == null)
                return;

            while (results.Read())
            {
                this.Text = results[0].ToString();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}