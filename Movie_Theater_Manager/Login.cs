using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Theater_Manager
{
    public partial class Login : Form
    { 
        DBManager dbManager = new DBManager();

        List<UserAccount> userAccounts;

        public Login()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            // Gets the userAccounts from the database
            userAccounts = dbManager.GetUserFromDB();

            
        }

        public static string Username = "";

        /// <summary>
        /// When called, loops through the userAccounts list and make sure the inputed account login info is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Variables to hold user login
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            int userType = 1;

            // Loops through userAccounts list
            foreach (UserAccount user in userAccounts)
            {
                // Checks if userType is the same as in the database
                if (user.UserAccountTypeID == userType)
                {
                    // Checks if the username and password are in the database
                    if ((user.Username == username) && (user.Password == password))
                    {
                        Username = username;

                        // Hides the form
                        this.Hide();

                        // Creates new object and displays a new form
                        ClientPortal portal = new ClientPortal();
                        portal.Show();
                    }
                    else
                    {
                        // Displays error message
                        errorMessageLabel.Visible = true;
                    }
                }
                else
                {
                    // Displays error message
                    errorMessageLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// When called, displays the create account form for users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Hides the form
            this.Hide();

            // Creates a new object and dispalays a new form
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        /// <summary>
        /// When called, displays the manager login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerButton_Click(object sender, EventArgs e)
        {
            // Hides form
            this.Hide();

            // Creates a new object and displays a new form
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
