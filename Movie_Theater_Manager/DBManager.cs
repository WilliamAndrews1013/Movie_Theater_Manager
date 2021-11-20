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

        public void AddUserAccountToDB()
        {
            CreateAccount createAccount = new CreateAccount();
            UserAccount newUser;

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

                //dbConnection.Close();

                // Sets biggestNumber to the max number in the userID array
                int biggestNumber = userID.Max();

                // Adds 1 to the biggest ID to set the new user's ID
                biggestNumber++;

                // Get current DateTime
                DateTime thisDay = DateTime.Today;

                // Sets a date format to thisDay
                string dateFormat = thisDay.ToString("yyyy/MM/dd");

                if (string.IsNullOrEmpty(createAccount.nameTextBox.Text) || string.IsNullOrEmpty(createAccount.usernameTextBox.Text) || string.IsNullOrEmpty(createAccount.emailTextBox.Text) || string.IsNullOrEmpty(createAccount.passwordTextBox.Text))
                {
                    // Display error message
                    createAccount.errorMessageLabel.Visible = true;
                    createAccount.errorlabel1.Visible = true;
                    createAccount.errorlabel2.Visible = true;
                    createAccount.errorlabel3.Visible = true;
                    createAccount.errorlabel4.Visible = true;
                }
                else
                {
                    // Creates new UserAccount object and adds data to it
                    newUser = new UserAccount();

                    newUser.ID = biggestNumber;
                    newUser.Name = createAccount.nameTextBox.Text;
                    newUser.Username = createAccount.usernameTextBox.Text;
                    newUser.Password = createAccount.passwordTextBox.Text;
                    newUser.Email = createAccount.emailTextBox.Text;
                    newUser.UserAccountTypeID = 1;
                    newUser.SignUpDateTime = thisDay;

                    // Holds sqlQUery that needs to be executed
                    sqlQuery = "INSERT INTO user_account VALUES (@UserID, @Name, @Username, @Password, @Email_Address, @Ua_Type_ID, @Signup_Date_Time);";

                    dbCommand = new MySqlCommand(sqlQuery, dbConnection);

                    dbCommand.Parameters.AddWithValue("@UserID", newUser.ID);
                    dbCommand.Parameters.AddWithValue("@Name", newUser.Name);
                    dbCommand.Parameters.AddWithValue("@Username", newUser.Username);
                    dbCommand.Parameters.AddWithValue("@Password", newUser.Password);
                    dbCommand.Parameters.AddWithValue("@Email_Address", newUser.Email);
                    dbCommand.Parameters.AddWithValue("@Ua_Type_ID", newUser.UserAccountTypeID);
                    dbCommand.Parameters.AddWithValue("@Signup_Date_Time", dateFormat);

                    dbCommand.ExecuteNonQuery();
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
    }
}
