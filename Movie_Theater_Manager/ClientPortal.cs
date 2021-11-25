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
        public ClientPortal()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            showtimes = dbManager.GetShowtimesFromDB();
            movieList = dbManager.GetMovieFromDB();

            DisplayShowtimes();
            UpdateMovieGenres();

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
                for (int i = 0; i < movieList[movie].Genre.Count; i++)
                {
                    genreListBox.Items.Add(movieList[movie].Genre[i].Name);
                }
            }
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewETicketButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
