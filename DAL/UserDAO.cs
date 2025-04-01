using System;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Text.Json;

using System.Security.Cryptography;
using Model.Enums;

namespace DAL
{
    public class UserDAO : BaseDao
    {
        public User READUser(string firstname)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("first_name", firstname);
            BsonDocument document = collection.Find(filter).First();
            return new User(document);
        }

        public User READUserByUsername(string username)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);
            BsonDocument document = collection.Find(filter).FirstOrDefault();
            if (document == null)
            {
                return null;
            }
            return new User(document);
        }

        public User GetUserById(ObjectId id)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            BsonDocument document = collection.Find(filter).First();
            return new User(document);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            foreach (BsonDocument document in collection.Find(_ => true).ToListAsync().Result)
            {
                users.Add(new User(document));
            }
            return users;
        }

        public User ValidateUserCredentials(string username, string hashedPassword)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("username", username),
                Builders<BsonDocument>.Filter.Eq("password", hashedPassword)
            );

            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                return null; // Invalid credentials
            }
            return new User(document); // Return the User object if credentials are valid
        }


        // HashPassword method (this should already exist in your service layer)
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void CreateUser(User user)
        {
            user.Password = HashPassword(user.Password);

            var userDocument = new BsonDocument
            {
                { "_id", ObjectId.GenerateNewId() },
                { "last_name", user.Last_Name },
                { "first_name", user.First_Name },
                { "username", user.Username },
                { "password", user.Password },
                { "role", (int)user.Role },  // Store role as an integer
                { "email", user.Email }
            };

            IMongoCollection<BsonDocument> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<BsonDocument>("User");
            collection.InsertOne(userDocument);
        }

        /*public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }*/
        public void UpdateUserPassword(string username, string hashedPassword)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Define the update (set the new password)
            var update = Builders<BsonDocument>.Update.Set("password", hashedPassword);

            // Apply the update
            collection.UpdateOne(filter, update);
        }
        // Store the reset token and its expiration date
        public void StoreResetToken(string username, string token)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Set the token and expiration (24 hours from now)
            var update = Builders<BsonDocument>.Update
                .Set("reset_token", token)
                .Set("token_expiration", DateTime.UtcNow.AddHours(24));

            // Apply the update to store in the database
            collection.UpdateOne(filter, update);
        }
        public void DeleteUser(ObjectId id)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }

        public void UpdateUser(User user)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", user.Id);
            var update = Builders<BsonDocument>.Update
                .Set("first_name", user.First_Name)
                .Set("last_name", user.Last_Name)
                .Set("email", user.Email)
                .Set("role", user.Role);

            collection.UpdateOne(filter, update);
        }

        // Get the username by token
        public User GetUsernameByToken(string token)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("reset_token", token);
            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                return new User(document);  // Return the full user object
            }

            return null; // Token not found or invalid
        }


        // Verify if the token is valid and not expired
        public bool VerifyResetToken(string username, string token)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);
            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document != null && document.Contains("reset_token"))
            {
                string storedToken = document["reset_token"].AsString;
                Console.WriteLine($"Stored Token: {storedToken}");
                Console.WriteLine($"Entered Token: {token}");

                if (storedToken == token)
                {
                    DateTime expiration = document["token_expiration"].ToUniversalTime();
                    Console.WriteLine($"Token Expiration: {expiration}");
                    Console.WriteLine($"Current Time (UTC): {DateTime.UtcNow}");

                    if (DateTime.UtcNow <= expiration)
                    {
                        return true; // Token is valid and not expired
                    }
                }
            }

            return false; // Token is invalid or expired
        }


        // Method to clear the reset token and expiration after successful password reset
        public void ClearResetToken(string username)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Define the update (clear the token and expiration)
            var update = Builders<BsonDocument>.Update
                .Set("reset_token", "")
                .Set("token_expiration", BsonNull.Value);

            // Apply the update
            collection.UpdateOne(filter, update);
        }

        public List<User> GetAllServiceUsers()
        {
            List<User> users = new List<User>();
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("role", 1);
            List<BsonDocument> documents = collection.Find(filter).ToList();
            foreach (BsonDocument document in documents)
            { //Get all users
                users.Add(new User(document));
            }
            return users;
        }
    }

}
