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
    public partial class AddShowtime : Form
    {
        DBManager dbManager = new DBManager();
        List<ScreeningRoom> foundScreeningRoom = new List<ScreeningRoom>();

        public AddShowtime()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            foundScreeningRoom = dbManager.GetScreeningRoomsFromDB();

            DisplayScreeningRoom();
        }

        private void DisplayScreeningRoom()
        {
            for (int i = 0; i < foundScreeningRoom.Count; i++)
            {
                codeComboBox.Items.Add(foundScreeningRoom[i].Code);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Showtime showtime = new Showtime();

            showtime.DateTime = DateTime.Parse(dateTextBox.Text);
            showtime.MovieID = int.Parse(IDTextBox.Text);
            showtime.ScreeningRoomID = codeComboBox.Text;
            showtime.TicketPrice = double.Parse(priceTextBox.Text);

            dbManager.AddShowtimeToDB(showtime);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

            ManagerPortal portal = new ManagerPortal();
            portal.Show();
        }
    }
}
