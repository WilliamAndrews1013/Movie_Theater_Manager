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
            dbManager.AddUserAccountToDB();

            MessageBox.Show("Account Created Succesfully!");

            this.Close();

            Login login = new Login();
            login.Show();
        }
    }
}
