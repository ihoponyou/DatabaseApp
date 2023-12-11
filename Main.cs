using DatabaseApp;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Text.RegularExpressions;

namespace MagcalasCullen_CSCI366_GroupProject
{
    public partial class Main : Form
    {
        public DatabaseApp.User? CurrentUser { get; private set; }
        internal DatabaseManager dbm;
        private UserControl? activePage;

        public Main()
        {
            dbm = new DatabaseManager();
            InitializeComponent();
            Text = "Online Game Store";
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            activePage = store1;
            library1.Hide();

            store1.RefreshPage();
            store1.Show();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Please log in to access your Library.", "Cannot access Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            activePage = library1;
            store1.Hide();

            library1.RefreshPage();
            library1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            activePage = store1;
            logoutButton.Hide();
            library1.Hide();

            store1.RefreshPage();
            store1.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using Login loginForm = new Login();

            if (loginForm.ShowDialog() != DialogResult.OK)
                return;

            // will always be non-null because the dialogresult is OK
            CurrentUser = loginForm.CurrentUser;
            Text = $"Online Game Store ({CurrentUser.Username})";

            loginButton.Hide();
            logoutButton.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
                return;

            CurrentUser = null;
            Text = $"Online Game Store";

            loginButton.Show();
            logoutButton.Hide();
            library1.Hide();

            activePage = store1;
            store1.Show();
        }
    }
}