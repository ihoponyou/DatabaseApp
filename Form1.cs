using DatabaseApp;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Text.RegularExpressions;

namespace MagcalasCullen_CSCI366_GroupProject
{
    public partial class Form1 : Form
    {
        public DatabaseApp.User? CurrentUser { get; private set; }
        private DatabaseManager dbm;
        private UserControl? activePage;

        public Form1()
        {
            dbm = new DatabaseManager();
            InitializeComponent();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            activePage = store1;
            library1.Hide();

            store1.Show();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                return;
            }

            activePage = library1;
            store1.Hide();
            library1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logoutButton.Hide();
            library1.Hide();

            activePage = store1;
            store1.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using Login loginForm = new Login();

            if (loginForm.ShowDialog() != DialogResult.OK)
                return;

            CurrentUser = loginForm.CurrentUser;

            loginButton.Hide();
            logoutButton.Show();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
                return;

            CurrentUser = null;
            loginButton.Show();
            logoutButton.Hide();
        }
    }
}