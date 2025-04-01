using Model;
using Model.Enums;
using MongoDB.Bson;
using Service;
using Service;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();

            // Prompt user for input to create a new user
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Role (employee/servicedeskemployee):");
            string roleInput = Console.ReadLine();
            Enum.TryParse(roleInput, true, out Roles role); // Parsing string input into Roles enum

            // Create a new user object using the new constructor
            User newUser = new User(ObjectId.GenerateNewId(), firstName, lastName, username, password, email, role);

            // Save the new user to the database
            userService.CreateUser(newUser);

            Console.WriteLine("User created successfully!");

        }
        
    }
}
