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
    public partial class AddMovie : Form
    {
        DBManager dbManager = new DBManager();
        List<Genre> foundGenreList = new List<Genre>();

        public AddMovie()
        {
            InitializeComponent();

            // Sets a connection to the database
            dbManager.SetDBConnection("127.0.0.1", "3306", "user1", "1013", "movietheater");

            foundGenreList = dbManager.GetGenresFromDB();
        }

        private int SearchGenreByName(string selectedGenre)
        {
            // Variable to hold index value
            int index = 0;

            // Loops through movieList
            foreach (Genre genre in foundGenreList)
            {
                // Checks if the selectedMovie is the same as movie.Title
                if (genre.Name == selectedGenre)
                {
                    // Get the index of the selected movie
                    index = foundGenreList.FindIndex(a => a.Name == selectedGenre);
                }
            }

            // Return the value of index
            return index;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie();

            newMovie.Title = titleTextBox.Text;
            newMovie.Year = int.Parse(yearTextBox.Text);
            newMovie.Length = lengthTextBox.Text;
            newMovie.AudienceRating = double.Parse(ratingTextBox.Text);
            newMovie.ImageFilePath = imageFilePathTextBox.Text;
            string movieGenre = genreTextBox.Text;

            int index = SearchGenreByName(movieGenre);

            Genre currentGenre = (Genre)foundGenreList[index];

            newMovie.Genre.Add(currentGenre);

            dbManager.AddMovieToDB(newMovie, currentGenre);

            MessageBox.Show("Movie Added Succesfully!");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

            ManagerPortal portal = new ManagerPortal();
            portal.Show();

        }
    }
}
