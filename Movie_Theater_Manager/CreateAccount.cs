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
    public partial class CreateAccount : Form
    {
        // Creates an instance of dbManager
        DBManager dbManager = new DBManager();

        public CreateAccount()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");
        }

        /// <summary>
        /// When called, writes data into the database and cretaes a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                // Display error message
                errorMessageLabel.Visible = true;
                errorlabel1.Visible = true;
                errorlabel2.Visible = true;
                errorlabel3.Visible = true;
                errorlabel4.Visible = true;
            }
            else
            {
                UserAccount account = new UserAccount();
                account.Name = nameTextBox.Text;
                account.Username = usernameTextBox.Text;
                account.Password = passwordTextBox.Text;
                account.Email = emailTextBox.Text;

                dbManager.AddUserAccountToDB(account);

                MessageBox.Show("Account Created Succesfully!");
            }

            this.Close();

            Login login = new Login();
            login.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Login login = new Login();
            login.Show();
        }
    }
}
