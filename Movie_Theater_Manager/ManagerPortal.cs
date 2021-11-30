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
    public partial class ManagerPortal : Form
    {
        DBManager dbManager = new DBManager();

        List<UserAccount> foundUserAccountList = new List<UserAccount>();
        List<Movie> foundMovieList = new List<Movie>();
        List<ScreeningRoom> foundScreeningRoomList = new List<ScreeningRoom>();
        List<Showtime> foundShowtimeList = new List<Showtime>();
        List<E_Ticket> foundE_TicketList = new List<E_Ticket>();
        List<Movie> ticketSoldByMovieList = new List<Movie>();
        List<Showtime> ticketSoldByShowtimeList = new List<Showtime>();

        public ManagerPortal()
        {
            InitializeComponent();

            // Sets up a connection to the DB
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            // Gets the data from the database
            foundUserAccountList = dbManager.GetUserFromDB();
            foundMovieList = dbManager.GetMovieFromDB();
            foundShowtimeList = dbManager.GetShowtimesFromDB();
            foundE_TicketList = dbManager.GetE_TicketsFromDB();
            foundScreeningRoomList = dbManager.GetScreeningRoomsFromDB();

            UpdateMovieGenres();

            // Create and display listView header
            ListViewHeader();

            // Display data
            DisplayClients();
            DisplayMovies();
            DisplayScreenignRoom();
            DisplayShowtimes();
            DisplayTicketSoldByMovie();
            DisplayShowtimeTickets();
        }

        private void ListViewHeader()
        {
            // Creates columnHeaders for listView
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
            columnHeader3.Text = "Movie Title";
            columnHeader3.TextAlign = HorizontalAlignment.Left;
            movieListView.Columns.Add(columnHeader3);
            movieListView.View = View.Details;

            ColumnHeader columnHeader4 = new ColumnHeader();
            columnHeader4.Text = "Screening Room ID";
            columnHeader4.TextAlign = HorizontalAlignment.Left;
            screeningRoomListView.Columns.Add(columnHeader4);
            screeningRoomListView.View = View.Details;

            ColumnHeader columnHeader5 = new ColumnHeader();
            columnHeader5.Text = "Name";
            columnHeader5.TextAlign = HorizontalAlignment.Left;
            clientListView.Columns.Add(columnHeader5);
            clientListView.View = View.Details;

            ColumnHeader columnHeader8 = new ColumnHeader();
            columnHeader8.Text = "Tickets Sold";
            columnHeader8.TextAlign = HorizontalAlignment.Left;
            ticketsSoldByShowtimeListView.Columns.Add(columnHeader8);
            ticketsSoldByShowtimeListView.View = View.Details;

            ColumnHeader columnHeader9 = new ColumnHeader();
            columnHeader9.Text = "Tickets Sold";
            columnHeader9.TextAlign = HorizontalAlignment.Left;
            ticketsSoldByMovieListView.Columns.Add(columnHeader9);
            ticketsSoldByMovieListView.View = View.Details;


            // Loops through each column header and resizes them to fit text
            foreach (ColumnHeader ch in this.showtimeListView.Columns)
            {
                ch.Width = -2;
            }

            foreach (ColumnHeader ch in this.movieListView.Columns)
            {
                ch.Width = -2;
            }

            foreach (ColumnHeader ch in this.screeningRoomListView.Columns)
            {
                ch.Width = -2;
            }

            foreach (ColumnHeader ch in this.clientListView.Columns)
            {
                ch.Width = -2;
            }

            foreach (ColumnHeader ch in this.ticketsSoldByShowtimeListView.Columns)
            {
                ch.Width = -2;
            }

            foreach (ColumnHeader ch in this.ticketsSoldByMovieListView.Columns)
            {
                ch.Width = -2;
            }
        }

        private void UpdateMovieGenres()
        {
            for (int i = 0; i < foundMovieList.Count; i++)
            {
                foundMovieList[i].Genre = dbManager.LoadMovieGenre(foundMovieList[i].ID);
            }
        }

        private void DisplayMovies()
        {
            for (int i = 0; i < foundMovieList.Count; i++)
            {
                movieListView.Items.Add(foundMovieList[i].Title);
            }
        }

        private void DisplayScreenignRoom()
        {
            for (int i = 0; i < foundScreeningRoomList.Count; i++)
            {
                screeningRoomListView.Items.Add(foundScreeningRoomList[i].Code);
            }
        }

        private void DisplayShowtimes()
        {
            for (int i = 0; i < foundShowtimeList.Count; i++)
            {
                showtimeListView.Items.Add(foundShowtimeList[i].ID.ToString());
                showtimeListView.Items[i].SubItems.Add(foundShowtimeList[i].DateTime.ToString());
            }
        }

        private void DisplayClients()
        {
            foreach (UserAccount user in foundUserAccountList)
            {
                if (user.UserAccountTypeID == 1)
                {
                    clientListView.Items.Add(user.Name);
                }
            }
        }

        private void DisplayTicketSoldByMovie()
        {
            // Loops through lists
            foreach (Showtime showtime in foundShowtimeList)
            {
                foreach (E_Ticket e_Ticket in foundE_TicketList)
                {
                    foreach (Movie movie in foundMovieList)
                    {
                        // Checks if showtime IDs are the same
                        if (showtime.ID == e_Ticket.ShowtimeID)
                        {
                            // Checks if movie IDs are the same
                            if (showtime.MovieID == movie.ID)
                            {
                                ticketSoldByMovieList.Add(movie);
                            }
                        }
                    }
                }
            }

            var movies = from x in ticketSoldByMovieList
                         group x by x into g
                         let count = g.Count()
                         orderby count descending
                         select new { Value = g.Key.Title, Count = count };

            foreach (var x in movies)
            {
                ticketsSoldByMovieListView.Items.Add(x.Value + x.Count);
            }
        }

        private void DisplayShowtimeTickets()
        {
            // Loops through List
            foreach (Showtime showtime in foundShowtimeList)
            {
                foreach (E_Ticket e_Ticket in foundE_TicketList)
                {
                    // Checks if the ShowtimeID is the same as the ETicket 
                    if (showtime.ID == e_Ticket.ShowtimeID)
                    {
                        ticketSoldByShowtimeList.Add(showtime);
                    }
                }
            }


            var movies = from x in ticketSoldByShowtimeList
                         group x by x into g
                         let count = g.Count()
                         orderby count descending
                         select new { Value = g.Key.DateTime, Count = count };
            foreach (var x in movies)
            {
                ticketsSoldByShowtimeListView.Items.Add(x.Value.ToString() + x.Count);
            }
        }

        private int SearchMovieByName(string selectedMovie)
        {
            // Variable to hold index value
            int index = 0;

            if (movieListView.SelectedItems.Count > 0)
            {
                // Loops through movieList
                foreach (Movie movie in foundMovieList)
                {
                    // Checks if the selectedMovie is the same as movie.Title
                    if (movie.Title == selectedMovie)
                    {
                        // Get the index of the selected movie
                        index = foundMovieList.FindIndex(a => a.Title == selectedMovie);
                    }
                }
            }

            // Return the value of index
            return index;
        }

        private int SearchScreeningRoomByID(string selectedRoom)
        {
            int index = 0;

            // Loops through foundScreeningRoomList
            foreach (ScreeningRoom room in foundScreeningRoomList)
            {
                // Checks if the selectedRoom is the same as room.Code
                if (room.Code == selectedRoom)
                {
                    // Get the index of the selected room
                    index = foundScreeningRoomList.FindIndex(a => a.Code == selectedRoom);
                }
            }

            return index;
        }

        private int SearchShowtimesByID(string selectedShowtime)
        {
            int index = 0;

            // Loops through foundShowtimeList 
            foreach (Showtime showtime in foundShowtimeList)
            {
                // Checks if the selectedShowtime is the same as showtime.ID
                if (showtime.ID.ToString() == selectedShowtime)
                {
                    // Get the index of selectedShowtime
                    index = foundShowtimeList.FindIndex(a => a.ID.ToString() == selectedShowtime);
                }
            }

            return index;
        }

        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movieListView.SelectedItems.Count > 0)
            {
                genreListBox.Items.Clear();

                string selectedMovie = movieListView.SelectedItems[0].Text;

                int index = SearchMovieByName(selectedMovie);

                Movie currentMovie = (Movie)foundMovieList[index];

                movieIDTextBox.Text = currentMovie.ID.ToString();
                titleTextBox.Text = currentMovie.Title;
                yearTextBox.Text = currentMovie.Year.ToString();
                lengthTextBox.Text = currentMovie.Length;
                audienceRatingTextBox.Text = currentMovie.AudienceRating.ToString();
                imageFilePathTextBox.Text = currentMovie.ImageFilePath;

                for (int i = 0; i < currentMovie.Genre.Count; i++)
                {
                    genreListBox.Items.Add(currentMovie.Genre[i].Name);
                }
            }
        }

        private void ScreeningRoomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (screeningRoomListView.SelectedItems.Count > 0)
            {
                string selectedRoom = screeningRoomListView.SelectedItems[0].Text;

                int index = SearchScreeningRoomByID(selectedRoom);

                ScreeningRoom screeningRoom = (ScreeningRoom)foundScreeningRoomList[index];

                screeningRoomCodeTextBox.Text = screeningRoom.Code;
                capacityTextBox.Text = screeningRoom.Capacity.ToString();
                descriptionTextBox.Text = screeningRoom.Description;
            }
        }

        private void ShowtimeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showtimeListView.SelectedItems.Count > 0)
            {
                string selectedShowtime = showtimeListView.SelectedItems[0].Text;

                int index = SearchShowtimesByID(selectedShowtime);

                Showtime currentShowtime = (Showtime)foundShowtimeList[index];

                showtimeIDTextBox.Text = currentShowtime.ID.ToString();
                dateTimeTextBox.Text = currentShowtime.DateTime.ToString();
                showtimeMovieIDTextBox.Text = currentShowtime.MovieID.ToString();
                showtimeScreenRoomCodeIDTextBox.Text = currentShowtime.ScreeningRoomID;
                ticketPriceTextBox.Text = currentShowtime.TicketPrice.ToString("c");
            }
        }

        /// <summary>
        /// Displays the AddMovie form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddMovie movie = new AddMovie();

            movie.Show();
        }

        /// <summary>
        /// Deletes a selected movie from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            if (movieListView.SelectedItems.Count > 0)
            {
                // Holds selectedMovie
                string selectedMovie = movieListView.SelectedItems[0].Text;

                // Holds selected movies index in list
                int index = SearchMovieByName(selectedMovie);

                // Create object filled data with selectedMovie data
                Movie currentMovie = (Movie)foundMovieList[index];

                // Call DeleteMovie method from DBManager class
                dbManager.DeleteMovie(currentMovie);

                // Clear movieList and movieListView
                foundMovieList.Clear();
                movieListView.Items.Clear();

                // Refresh ListView
                dbManager.GetMovieFromDB();
                DisplayMovies();
                UpdateMovieGenres();

                // Clear TextBox
                movieIDTextBox.Text = "";
                titleTextBox.Text = "";
                yearTextBox.Text = "";
                lengthTextBox.Text = "";
                audienceRatingTextBox.Text = "";
                imageFilePathTextBox.Text = "";
            }
        }

        /// <summary>
        /// Edits movie data and saves it to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            if (movieListView.SelectedItems.Count > 0)
            {
                string selectedMovie = movieListView.SelectedItems[0].Text;

                int index = SearchMovieByName(selectedMovie);

                Movie currentMovie = (Movie)foundMovieList[index];

                if (selectedMovie == currentMovie.Title)
                {
                    currentMovie.Title = titleTextBox.Text;
                    currentMovie.Year = int.Parse(yearTextBox.Text);
                    currentMovie.Length = lengthTextBox.Text;
                    currentMovie.AudienceRating = double.Parse(audienceRatingTextBox.Text);
                    currentMovie.ImageFilePath = imageFilePathTextBox.Text;

                    // Calls EditMovie method from DBManager class
                    dbManager.EditMovie(currentMovie);

                    // Clears and refreshes foundMovieList and movieListView
                    foundMovieList.Clear();
                    movieListView.Items.Clear();
                    foundMovieList = dbManager.GetMovieFromDB();
                    DisplayMovies();
                    UpdateMovieGenres();
                }
            }
        }

        private void AddScreeningRoomButton_Click(object sender, EventArgs e)
        {
            // Creates a new ScreeningRoom object and adds data to it
            ScreeningRoom newScreeningRoom = new ScreeningRoom();

            newScreeningRoom.Code = screeningRoomCodeTextBox.Text;
            newScreeningRoom.Capacity = int.Parse(capacityTextBox.Text);
            newScreeningRoom.Description = descriptionTextBox.Text;

            // Calls the AddScreenRoomToDB method from DBManager class
            dbManager.AddScreenRoomToDB(newScreeningRoom);

            // Clear foundScreeningRoomList and screeningRoomListView and refresh the data
            foundScreeningRoomList.Clear();
            screeningRoomListView.Items.Clear();
            foundScreeningRoomList = dbManager.GetScreeningRoomsFromDB();
            DisplayScreenignRoom();

            // Clear TextBox
            screeningRoomCodeTextBox.Text = "";
            capacityTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void EditScreeningRoomButton_Click(object sender, EventArgs e)
        {
            if (screeningRoomListView.SelectedItems.Count > 0)
            {
                string selectedScreeningRoom = screeningRoomListView.SelectedItems[0].Text;

                int index = SearchScreeningRoomByID(selectedScreeningRoom);

                ScreeningRoom currentScreeningRoom = (ScreeningRoom)foundScreeningRoomList[index];

                if (selectedScreeningRoom == currentScreeningRoom.Code)
                {
                    currentScreeningRoom.Capacity = int.Parse(capacityTextBox.Text);
                    currentScreeningRoom.Description = descriptionTextBox.Text;

                    dbManager.EditScreeningRoom(currentScreeningRoom);

                    foundScreeningRoomList.Clear();
                    screeningRoomListView.Items.Clear();
                    foundScreeningRoomList = dbManager.GetScreeningRoomsFromDB();
                    DisplayScreenignRoom();

                    // Clear TextBox
                    screeningRoomCodeTextBox.Text = "";
                    capacityTextBox.Text = "";
                    descriptionTextBox.Text = "";
                }
            }
        }

        private void DeleteScreeningRoomButton_Click(object sender, EventArgs e)
        {
            if (screeningRoomListView.SelectedItems.Count > 0)
            {
                string selectedScreeningRoom = screeningRoomListView.SelectedItems[0].Text;

                int index = SearchScreeningRoomByID(selectedScreeningRoom);

                ScreeningRoom currentScreeningRoom = (ScreeningRoom)foundScreeningRoomList[index];

                dbManager.DeleteScreeningRoomFromDB(currentScreeningRoom);

                // Clear foundScreeningRoomList and screeningRoomListView and refreshes the list and listView
                foundScreeningRoomList.Clear();
                screeningRoomListView.Items.Clear();
                foundScreeningRoomList = dbManager.GetScreeningRoomsFromDB();
                DisplayScreenignRoom();

                // Clear TextBox
                screeningRoomCodeTextBox.Text = "";
                capacityTextBox.Text = "";
                descriptionTextBox.Text = "";
            }
        }

        private void ShowtimeAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddShowtime showtime = new AddShowtime();
            showtime.Show();
        }

        private void ShowtimeEditButton_Click(object sender, EventArgs e)
        {
            if (showtimeListView.SelectedItems.Count > 0)
            {
                string selectedShowtime = showtimeListView.SelectedItems[0].Text;

                int index = SearchShowtimesByID(selectedShowtime);

                Showtime currentShowtime = (Showtime)foundShowtimeList[index];

                if (selectedShowtime == currentShowtime.ID.ToString())
                {
                    currentShowtime.DateTime = DateTime.Parse(dateTimeTextBox.Text);
                    currentShowtime.MovieID = int.Parse(showtimeMovieIDTextBox.Text);
                    currentShowtime.ScreeningRoomID = showtimeScreenRoomCodeIDTextBox.Text;
                    currentShowtime.TicketPrice = double.Parse(ticketPriceTextBox.Text);

                    dbManager.EditShowtime(currentShowtime);

                    foundShowtimeList.Clear();
                    showtimeListView.Items.Clear();

                    showtimeIDTextBox.Text = "";
                    dateTimeTextBox.Text = "";
                    showtimeMovieIDTextBox.Text = "";
                    showtimeScreenRoomCodeIDTextBox.Text = "";
                    ticketPriceTextBox.Text = "";
                }
            }
        }

        private void ShowtimeDeleteButton_Click(object sender, EventArgs e)
        {
            if (showtimeListView.SelectedItems.Count > 0)
            {
                string selectedShowtime = showtimeListView.SelectedItems[0].Text;

                int index = SearchShowtimesByID(selectedShowtime);

                Showtime currentShowtime = (Showtime)foundShowtimeList[index];

                dbManager.DeleteShowtimeFromDB(currentShowtime);

                foundShowtimeList.Clear();
                showtimeListView.Items.Clear();

                showtimeIDTextBox.Text = "";
                dateTimeTextBox.Text = "";
                showtimeMovieIDTextBox.Text = "";
                showtimeScreenRoomCodeIDTextBox.Text = "";
                ticketPriceTextBox.Text = "";
            }
        }
    }
}
