using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Movie_Theater_Manager
{
    public class DBManager
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        MySqlConnection dbConnection;
        public void SetDBConnection(string serverAddress, string serverPort, string username, string password, string dbName)
        {
            string connectionString = "server=" + serverAddress + "; port=" + serverPort + "; user=" + username + "; password=" + password + "; database=" + dbName + ";";

            log.Info(connectionString);

            dbConnection = new MySqlConnection(connectionString);
        }

        public void checkDBServerVersion()
        {
            try
            {
                //Before sending queries to the database, the connection must be opened
                dbConnection.Open();

                log.Info("DB Connection OK!!!");

                //This is a string representing the SQL query to execute in the db
                string sqlQuery = "SELECT version()";

                //This is the actual SQL command containing the query to be executed
                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                //This variable stores the result of the SQL query sent to the db
                string dbServerVersion = dbCommand.ExecuteScalar().ToString();

                //After executing the query(ies) in the db, the connection must be closed
                dbConnection.Close();

                log.Info("DB Server version: " + dbServerVersion);
            }
            catch (MySqlException ex)
            {
                // if the db connection is still open, it must be closed, otherwise, further attemps to open the connection again will fail
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);
                log.Info(ex.Message);
            }

        }

        public List<UserAccount> GetUserFromDB()
        {
            UserAccount userAccount;
            List<UserAccount> foundUserAccount = new List<UserAccount>();

            try
            {
                // Opens connection to database
                dbConnection.Open();

                // Holds the sqlQuery to be executed
                string sqlQuery = "SELECT * FROM user_account";

                // SqlCommand containing sql query to execute
                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                // Variable stores the data gotten from the db 
                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    // Create a new userAccount and get it's data
                    userAccount = new UserAccount();

                    userAccount.ID = dataReader.GetInt32(0);
                    userAccount.Name = dataReader.GetString(1);
                    userAccount.Username = dataReader.GetString(2);
                    userAccount.Password = dataReader.GetString(3);
                    userAccount.Email = dataReader.GetString(4);
                    userAccount.UserAccountTypeID = dataReader.GetInt32(5);
                    userAccount.SignUpDateTime = dataReader.GetDateTime(6);

                    log.Info(userAccount.ToString());

                    foundUserAccount.Add(userAccount);
                }

                // Close the connection after executing the query(ies)
                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                // If the connection is still open, close it
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }

            return foundUserAccount;
        }

        public void AddUserAccountToDB(UserAccount account)
        {
            CreateAccount createAccount = new CreateAccount();
            

            try
            {
                // Opens connection to database
                dbConnection.Open();

                // Holds the sqlQuery to be executed
                string sqlQuery = "SELECT * FROM user_account";

                // SqlCommand containing sql query to execute
                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                // Variable stores the data gotten from the db 
                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                int[] userID = { };

                while ((dataReader.Read()))
                {
                    // Puts userID in an array
                    int[] ids = { dataReader.GetInt32(0) };

                    // Sets ids data in userID
                    userID = ids;
                }

                dataReader.Close();

                // Sets biggestNumber to the max number in the userID array
                int biggestNumber = userID.Max();

                // Adds 1 to the biggest ID to set the new user's ID
                biggestNumber++;

                // Get current DateTime
                DateTime thisDay = DateTime.Today;

                // Sets a date format to thisDay
                string dateFormat = thisDay.ToString("yyyy/MM/dd");

                account.ID = biggestNumber;
                account.UserAccountTypeID = 1;

                // Holds sqlQUery that needs to be executed
                sqlQuery = "INSERT INTO user_account VALUES (@UserID, @Name, @Username, @Password, @Email_Address, @Ua_Type_ID, @Signup_Date_Time);";

                dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@UserID", account.ID);
                dbCommand.Parameters.AddWithValue("@Name", account.Name);
                dbCommand.Parameters.AddWithValue("@Username", account.Username);
                dbCommand.Parameters.AddWithValue("@Password", account.Password);
                dbCommand.Parameters.AddWithValue("@Email_Address", account.Email);
                dbCommand.Parameters.AddWithValue("@Ua_Type_ID", account.UserAccountTypeID);
                dbCommand.Parameters.AddWithValue("@Signup_Date_Time", dateFormat);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }
        }

        public List<Movie> GetMovieFromDB()
        {
            Movie currentMovie;
            List<Movie> foundMovieList = new List<Movie>();

            try
            {
                // Open connection to db
                dbConnection.Open();

                // Holds the sqlQuery command that needs to be executed
                string sqlQuery = "SELECT * FROM movie";

                // SQL command containing sql query to execute
                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                // Variable that stores data gotten from the db
                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    // Creates a new movie and stores its data
                    currentMovie = new Movie();

                    currentMovie.ID = dataReader.GetInt32(0);
                    currentMovie.Title = dataReader.GetString(1);
                    currentMovie.Year = dataReader.GetInt32(2);
                    currentMovie.Length = dataReader.GetString(3);
                    currentMovie.AudienceRating = dataReader.GetDouble(4);
                    currentMovie.ImageFilePath = dataReader.GetString(5);

                    

                    log.Info(currentMovie);

                    foundMovieList.Add(currentMovie);
                }

                // Close the db connection after execution
                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    // If the connection is still open, close it
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }

            return foundMovieList;
        }

        public List<Genre> LoadMovieGenre(int movieID)
        {
            Genre currentGenre;
            List<Genre> foundGenre = new List<Genre>();

            try
            {
                dbConnection.Open();

                string sqlQuery = "SELECT Genre_ID FROM jt_genre_movie WHERE Movie_ID = '" + movieID + "';";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    currentGenre = new Genre();

                    currentGenre.Code = dataReader.GetString(0);

                    foundGenre.Add(currentGenre);
                }

                // Close dataReader
                dataReader.Close();

                for (int i = 0; i < foundGenre.Count; i++)
                {
                    sqlQuery = "SELECT * from genre WHERE GenreID = '" + foundGenre[i].Code + "';";

                    dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                    dataReader = dbCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        foundGenre[i].Name = dataReader.GetString(1);

                        if (dataReader.GetString(2) != null)
                        {
                            foundGenre[i].Description = dataReader.GetString(2);
                        }
                    }

                    log.Info(foundGenre[i].ToString());

                    dataReader.Close();
                }

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }

            return foundGenre;
        }

        public List<Showtime> GetShowtimesFromDB()
        {
            Showtime currentShowtime;

            List<Showtime> foundShowtime = new List<Showtime>();

            try
            {
                dbConnection.Open();

                string sqlQuery = "SELECT * FROM showtime;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    currentShowtime = new Showtime();

                    currentShowtime.ID = dataReader.GetInt32(0);
                    currentShowtime.DateTime = dataReader.GetDateTime(1);
                    currentShowtime.MovieID = dataReader.GetInt32(2);
                    currentShowtime.ScreeningRoomID = dataReader.GetString(3);
                    currentShowtime.TicketPrice = dataReader.GetDouble(4);

                    foundShowtime.Add(currentShowtime);
                }

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);
                log.Error(ex.Message);
            }

            return foundShowtime;
        }

        public List<ScreeningRoom> GetScreeningRoomsFromDB()
        {
            ScreeningRoom screeningRoom;
            List<ScreeningRoom> foundScreenignRoom = new List<ScreeningRoom>();

            try
            {
                dbConnection.Open();

                string sqlQuery = "SELECT * FROM screening_room;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    screeningRoom = new ScreeningRoom();

                    screeningRoom.Code = dataReader.GetString(0);
                    screeningRoom.Capacity = dataReader.GetInt32(1);
                    screeningRoom.Description = dataReader.GetString(2);

                    foundScreenignRoom.Add(screeningRoom);
                }

                dbConnection.Close();
            }
            catch(MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);

                log.Error(ex.Message);
            }

            return foundScreenignRoom;
        }

        public List<E_Ticket> GetE_TicketsFromDB()
        {
            E_Ticket e_Ticket;

            List<E_Ticket> foundE_Ticket = new List<E_Ticket>();

            try
            {
                dbConnection.Open();

                string sqlQuery = "SELECT * FROM e_ticket;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    e_Ticket = new E_Ticket();

                    e_Ticket.ID = dataReader.GetInt32(0);
                    e_Ticket.PurchaseDate = dataReader.GetDateTime(1);
                    e_Ticket.ShowtimeID = dataReader.GetInt32(2);
                    e_Ticket.UserAccountID = dataReader.GetInt32(3);

                    foundE_Ticket.Add(e_Ticket);
                }

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                Console.WriteLine(ex.Message);

                log.Error(ex.Message);
            }

            return foundE_Ticket;
        }

        public void AddMovieToDB(Movie movie, Genre genre)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "SELECT * FROM movie;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataReader = dbCommand.ExecuteReader();


                int[] ids = { };

                while (dataReader.Read())
                {
                    int[] idNumbers = { dataReader.GetInt32(0) };

                    ids = idNumbers;
                }

                dataReader.Close();

                int biggestID = ids.Max();

                biggestID++;

                movie.ID = biggestID;

                sqlQuery = "INSERT INTO movie VALUES (@MovieID, @Title, @Year, @Length, @Audience_Rating, @Image_File_Path);";

                dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@MovieID", movie.ID);
                dbCommand.Parameters.AddWithValue("@Title", movie.Title);
                dbCommand.Parameters.AddWithValue("@Year", movie.Year);
                dbCommand.Parameters.AddWithValue("@Length", movie.Length);
                dbCommand.Parameters.AddWithValue("@Audience_Rating", movie.AudienceRating);
                dbCommand.Parameters.AddWithValue("@Image_File_Path", movie.ImageFilePath);

                dbCommand.ExecuteNonQuery();

                sqlQuery = "INSERT INTO jt_genre_movie VALUES (@Genre_ID, @Movie_ID);";

                dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@Genre_ID", genre.Code);
                dbCommand.Parameters.AddWithValue("@Movie_ID", movie.ID);

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    // Close the connection
                    dbConnection.Close();
                }

                log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteMovie(Movie movie)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "DELETE FROM movie WHERE MovieID = @MovieID;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@MovieID", movie.ID);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);
            }
        }

        public void EditMovie(Movie movie)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "UPDATE movie SET Title = @Title, Year = @Year, Length = @Length, Audience_Rating = @Audience_Rating, Image_File_Path = @Image_File_Path WHERE MovieID = @MovieID";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@MovieID", movie.ID);
                dbCommand.Parameters.AddWithValue("@Title", movie.Title);
                dbCommand.Parameters.AddWithValue("@Year", movie.Year);
                dbCommand.Parameters.AddWithValue("@Length", movie.Length);
                dbCommand.Parameters.AddWithValue("@Audience_Rating", movie.AudienceRating);
                dbCommand.Parameters.AddWithValue("@Image_File_Path", movie.ImageFilePath);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);

                Console.WriteLine(ex.Message);
            }
        }

        public List<Genre> GetGenresFromDB()
        {
            Genre genre;
            List<Genre> foundGenreList = new List<Genre>();

            try
            {
                dbConnection.Open();

                // Holds sql query to execute
                string sqlQuery = "SELECT * FROM genre;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataRaeder = dbCommand.ExecuteReader();

                while (dataRaeder.Read())
                {
                    // Get genre data from db
                    genre = new Genre();

                    genre.Code = dataRaeder.GetString(0);
                    genre.Name = dataRaeder.GetString(1);
                    genre.Description = dataRaeder.GetString(2);

                    foundGenreList.Add(genre);
                }

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                // Checks dbCOnnection state
                if (dbConnection.State.ToString() == "Open")
                {
                    // If still open, close it
                    dbConnection.Close();
                }

                // Logs error message
                log.Error(ex.Message);
            }

            return foundGenreList;
        }

        public void AddScreenRoomToDB(ScreeningRoom screeningRoom)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "INSERT INTO screening_room VALUES (@Code, @Capacity, @Description);";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@Code", screeningRoom.Code);
                dbCommand.Parameters.AddWithValue("@Capacity", screeningRoom.Capacity);
                dbCommand.Parameters.AddWithValue("@Description", screeningRoom.Description);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void EditScreeningRoom(ScreeningRoom screeningRoom)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "UPDATE screening_room SET Code = @Code, Capacity = @Capacity, Description = @Description;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@Code", screeningRoom.Code);
                dbCommand.Parameters.AddWithValue("@Capacity", screeningRoom.Capacity);
                dbCommand.Parameters.AddWithValue("@Description", screeningRoom.Description);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteScreeningRoomFromDB(ScreeningRoom screeningRoom)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "DELETE FROM screening_room WHERE Code = @Code;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@Code", screeningRoom.Code);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void AddShowtimeToDB(Showtime showtime)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "SELECT * FROM showtime;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                MySqlDataReader dataReader = dbCommand.ExecuteReader();


                int[] ids = { };

                while (dataReader.Read())
                {
                    int[] idNumbers = { dataReader.GetInt32(0) };

                    ids = idNumbers;
                }

                dataReader.Close();

                int biggestID = ids.Max();

                biggestID++;

                showtime.ID = biggestID;
                string dateFormat = showtime.DateTime.ToString("yyyy/MM/dd H:mm:ss");

                sqlQuery = "INSERT INTO showtime VALUES (@ShowtimeID, @Date_Time, @Movie_ID, @S_room_code, @Ticket_Price);";

                dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@ShowtimeID", showtime.ID);
                dbCommand.Parameters.AddWithValue("@Date_Time", dateFormat);
                dbCommand.Parameters.AddWithValue("@Movie_ID", showtime.MovieID);
                dbCommand.Parameters.AddWithValue("@S_room_code", showtime.ScreeningRoomID);
                dbCommand.Parameters.AddWithValue("@Ticket_Price", showtime.TicketPrice);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);

                Console.WriteLine(ex.Message);
            }
        }

        public void EditShowtime(Showtime showtime)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "UPDATE showtime SET ShowtimeID = @ShowtimeID, Date_Time = @Date_Time, Movie_ID = @Movie_ID, S_room_code = @S_room_code, Ticket_Price = @Ticket_Price;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                string dateFormat = showtime.DateTime.ToString("yyyy/MM/dd H:mm:ss");

                dbCommand.Parameters.AddWithValue("@ShowtimeID", showtime.ID);
                dbCommand.Parameters.AddWithValue("@Date_Time", dateFormat);
                dbCommand.Parameters.AddWithValue("@Movie_ID", showtime.MovieID);
                dbCommand.Parameters.AddWithValue("@S_room_code", showtime.ScreeningRoomID);
                dbCommand.Parameters.AddWithValue("@Ticket_Price", showtime.TicketPrice);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch(MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteShowtimeFromDB(Showtime showtime)
        {
            try
            {
                dbConnection.Open();

                string sqlQuery = "DELETE showtime WHERE ShowtimeID = @ShowtimeID;";

                MySqlCommand dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                dbCommand.Parameters.AddWithValue("@ShowtimeID", showtime.ID);
                dbCommand.Prepare();

                dbCommand.ExecuteNonQuery();

                dbConnection.Close();
            }
            catch (MySqlException ex)
            {
                if (dbConnection.State.ToString() == "Open")
                {
                    dbConnection.Close();
                }

                log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
