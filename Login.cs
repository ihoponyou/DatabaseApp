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

        private void TryLogin()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // validate input = no sql injection!
            bool bothAlphaNumeric = isAlphaNumeric(username) && isAlphaNumeric(password);
            bool bothNonEmpty = !(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password));
            if (!bothAlphaNumeric || !bothNonEmpty)
                return;

            try
            {
                var results = databaseManager.Query($"SELECT customer_id FROM customer " +
                $"WHERE customer_username = '{username}' AND customer_password = '{password}'");

                if (results == null)
                {
                    errorLabel.Text = "No user found with these credentials.";
                    return;
                }

                while (results.Read())
                {
                    CurrentUser = new User((int)results[0], username, new int[0]);
                }

                results.Close();
            }
            catch (Exception e)
            {
                errorLabel.Text = e.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            TryLogin();

            if (CurrentUser != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }
    }
}
