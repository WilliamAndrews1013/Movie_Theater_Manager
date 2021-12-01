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
    public partial class ClientPortal : Form
    {
        DBManager dbManager = new DBManager();

        List<Showtime> showtimes;
        List<Movie> movieList;
        List<E_Ticket> e_Tickets;
        List<UserAccount> users;
        public ClientPortal()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            showtimes = dbManager.GetShowtimesFromDB();
            movieList = dbManager.GetMovieFromDB();
            e_Tickets = dbManager.GetE_TicketsFromDB();
            users = dbManager.GetUserFromDB();

            DisplayShowtimes();
            UpdateMovieGenres();
            AddImagesToImageList();

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "ID";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            showtimeListView.Columns.Add(columnHeader1);
            showtimeListView.View = View.Details;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Showtime Date";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            showtimeListView.Columns.Add(columnHeader2);
            

            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Price";
            columnHeader3.TextAlign = HorizontalAlignment.Left;
            showtimeListView.Columns.Add(columnHeader3);

            // Loops through each column header and resizes them to fit text
            foreach (ColumnHeader ch in this.showtimeListView.Columns)
            {
                ch.Width = -2;
            }

            Console.WriteLine(Login.Username);
        }

        private void DisplayShowtimes()
        {
            for (int i = 0; i < showtimes.Count; i++)
            {
                showtimeListView.Items.Add(showtimes[i].ID.ToString());
                showtimeListView.Items[i].SubItems.Add(showtimes[i].DateTime.ToString());
                showtimeListView.Items[i].SubItems.Add(showtimes[i].TicketPrice.ToString("f2"));
            }
        }

        private void UpdateMovieGenres()
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                movieList[i].Genre = dbManager.LoadMovieGenre(movieList[i].ID);
            }
        }

        private int SearchShowtimeByID(string selectedShowtime)
        {
            // Variable to hold index value
            int index = 0;

            if (showtimeListView.SelectedItems.Count > 0)
            {
                // Loops through movieList
                foreach (Showtime showtime in showtimes)
                {
                    // Checks if the selectedMovie is the same as movie.Title
                    if (showtime.ID.ToString() == selectedShowtime)
                    {
                        // Get the index of the selected movie
                        index = showtimes.FindIndex(a => a.ID.ToString() == selectedShowtime);
                    }
                }
            }

            // Return the value of index
            return index;
        }

        private int SearchUserByName(string selectedUser)
        {
            int index = 0;

            foreach (UserAccount user in users)
            {
                if (user.Username == selectedUser)
                {
                    index = users.FindIndex(a => a.Username == selectedUser);
                }
            }

            return index;
        }

        private void AddImagesToImageList()
        {
            for (int i = 0; i < movieList.Count; i++)
            {
                imageList1.Images.Add(Image.FromFile(movieList[i].ImageFilePath));
            }
        }

        private void ShowtimeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CLears genreListBox
            genreListBox.Items.Clear();

            if (showtimeListView.SelectedItems.Count > 0)
            {
                // Holds listView selection
                string selectedShowtime = showtimeListView.SelectedItems[0].Text; 
                
                // Gets the showtime index from its ID
                int index = SearchShowtimeByID(selectedShowtime);

                // Creats a new showtime object with data from the selected showtime
                Showtime currentShowtime = (Showtime)showtimes[index];

                // Gets the movie associated with the showtime
                int movie = movieList.FindIndex(a => a.ID == showtimes[index].MovieID);

                // Displays movie info to client
                titleDisplayLabel.Text = movieList[movie].Title;
                lengthDisplayLabel.Text = movieList[movie].Length;
                pictureBox1.Image = imageList1.Images[movie];
                for (int i = 0; i < movieList[movie].Genre.Count; i++)
                {
                    genreListBox.Items.Add(movieList[movie].Genre[i].Name);
                }
            }
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            if (showtimeListView.SelectedItems.Count > 0)
            {
                // Holds listView selection
                string selectedShowtime = showtimeListView.SelectedItems[0].Text;

                // Holds the logged in users username
                string selectedUser = Login.Username;

                // Gets the showtime index from its ID
                int index = SearchShowtimeByID(selectedShowtime);

                // Gets the logged in user
                int userIndex = SearchUserByName(selectedUser);

                // Creats a new showtime object with data from the selected showtime
                Showtime currentShowtime = (Showtime)showtimes[index];

                UserAccount currentUser = (UserAccount)users[userIndex];

                E_Ticket e_Ticket = new E_Ticket();

                e_Ticket.PurchaseDate = DateTime.Now;
                e_Ticket.ShowtimeID = currentShowtime.ID;
                e_Ticket.UserAccountID = currentUser.ID;

                dbManager.AddE_TicketToDB(e_Ticket);

                MessageBox.Show("Thank you for your purchase!");
            }
        }

        private void ViewETicketButton_Click(object sender, EventArgs e)
        {
            string selectedUser = Login.Username;

            int index = SearchUserByName(selectedUser);

            UserAccount user = (UserAccount)users[index];

            foreach (E_Ticket e_Ticket in e_Tickets)
            {
                if (user.ID == e_Ticket.UserAccountID)
                {
                    MessageBox.Show(e_Ticket.ID.ToString() + "\n" + e_Ticket.PurchaseDate.ToString() + "\n" + e_Ticket.ShowtimeID.ToString() + "\n" + e_Ticket.UserAccountID.ToString());
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();

            Login login = new Login();
            login.Show();
        }
    }
}
