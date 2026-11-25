using Casino;
using Casino.TwentyOne;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;
using System.Data;
using CasinoUseLibrary;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask player for their name and balance
            Console.WriteLine("Welcome to the Casino! Tell us your name");
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp);
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            
            Console.WriteLine("How much money did you bring today?");
            //keep asking until the input is a whole number
            int bank;

            while (!int.TryParse(Console.ReadLine(), out bank))
            {
                Console.WriteLine("Please enter a whole number.");
            }

            if (bank < 0)
            {
                FraudException fraud = new FraudException("Negative starting balance entered.");
                UpdateDbWithException(fraud);
                Console.WriteLine("This is fraud! Security! Let's kick them out!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            //if they want to play initialize the game
            if (answer == "yes" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                //conditions to keep playing
                while (player.isActivelyPlaying && player.Balance > 0)                               
                {
                    try
                    {
                        game.Play();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Sth you entered is not correct.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.WriteLine("This is fraud! Security! Let's kick them out!");
                        Console.ReadLine();
                        return;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your system admin.");
                        UpdateDbWithException(ex);
                    }
                }

                //after the loop remove them from play
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }

            Console.WriteLine("Feel free to look around. Bye now.");
            Console.Read();

        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }

            return Exceptions;  
        }
    }
}