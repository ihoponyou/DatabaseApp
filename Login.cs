using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class Login : Form
    {
        private DatabaseManager databaseManager;

        public User? CurrentUser
        {
            get;
            private set;
        }

        public Login()
        {
            databaseManager = new DatabaseManager();
            InitializeComponent();
        }

        private bool isAlphaNumeric(string str)
        {
            Regex re = new Regex("^[a-zA-Z0-9]*$");
            return re.IsMatch(str);
        }

        private void LoginWithCredentials(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();

            // validate input = no sql injection!
            bool bothAlphaNumeric = isAlphaNumeric(username) && isAlphaNumeric(password);
            if (!bothAlphaNumeric)
                throw new Exception("Username and password must be alphanumeric");

            bool eitherEmpty = string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password);
            if (eitherEmpty)
                throw new Exception("Username and password fields cannot be blank");

            // hardcoded admin login
            if (username.Equals("admin") && password.Equals("Password"))
            {
                CurrentUser = new User(-1, username, new Dictionary<int, Game>());
                return;
            }

            var results = databaseManager.Query($"SELECT customer_id FROM customer " +
            $"WHERE customer_username = '{username}' AND customer_password = '{password}'");

            if (results == null)
                throw new Exception("Something went wrong");
            if (!results.HasRows)
                throw new Exception("No user found with these credentials");

            while (results.Read())
            {
                CurrentUser = new User((int)results[0], username, new Dictionary<int, Game>());
                CurrentUser.OwnedGames = User.GetOwnedGames(databaseManager, CurrentUser.UserID);
            }

            results.Close();
        }

        // this is the cancel button, idk why the name hasn't updated
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Hide();
                errorLabel.Text = string.Empty;

                LoginWithCredentials(usernameTextBox.Text, passwordTextBox.Text);

                if (CurrentUser != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                errorLabel.Show();
                errorLabel.Text = ex.Message;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }
    }
}
