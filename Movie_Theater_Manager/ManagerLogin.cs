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
    public partial class ManagerLogin : Form
    {
        DBManager dbManager = new DBManager();

        List<UserAccount> userAccounts;

        public ManagerLogin()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            // Gets the userAccounts from the database
            userAccounts = dbManager.GetUserFromDB();
        }

        /// <summary>
        /// When called, searches through the userAccounts list and makes sure that the entered login info is for a manager 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginManagerButton_Click(object sender, EventArgs e)
        {
            // Variables to hold user login
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            int userType = 2;

            // Loops through userAccounts list
            foreach (UserAccount user in userAccounts)
            {
                // Checks if userType is the same as in the database
                if (user.UserAccountTypeID == userType)
                {
                    // Checks if the username and password are in the database
                    if ((user.Username == username) && (user.Password == password))
                    {
                        // Hides the form
                        this.Hide();

                        // Creates new object and displays a new form
                        ManagerPortal portal = new ManagerPortal();
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
        /// When called, closes the form and display the regular login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseManagerButton_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();

            // Display login form
            Login login = new Login();
            login.Show();
        }
    }
}
