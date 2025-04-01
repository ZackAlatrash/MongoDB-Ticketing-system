using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Service
{
    public class UserService
    {
        private UserDAO userdb;
        private MailingService mailing;

        public UserService()

        {
            userdb = new UserDAO();
            mailing = new MailingService();
        }

        public User READUser(string name)
        {
            return userdb.READUser(name);
        }

        public User GetUserByUsername(string username)
        {
            return userdb.READUserByUsername(username);
        }
        public bool VerifyResetToken(string username, string token)
        {
            // Check the token in the database using UserDAO's method
            return userdb.VerifyResetToken(username, token);
        }

        public User GetUserById(ObjectId id)
        {
            return userdb.GetUserById(id);
        }

        public List<User> GetAllUsers()
        {
            return userdb.GetAllUsers();
        }


        public User ValidateUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return userdb.ValidateUserCredentials(username, hashedPassword);
        }

        // Send the password reset email
        public void SendPasswordResetEmail(string username, string recoveryEmail)
        {
            // Generate a secure random token
            string token = GenerateSecureToken();

            // Store the token in the database associated with the user
            userdb.StoreResetToken(username, token);

            // Create the reset link using the token
            string resetLink = $"https://yourapp.com/reset-password?token={token}";

            // Send the reset link via email
            mailing.SendPasswordResetEmail(recoveryEmail, resetLink, token);
        }

        // Verify the token and reset the password if valid
        public bool ResetPasswordByToken(string token, string newPassword)
        {
            // Look up the user by the token
            User user = userdb.GetUsernameByToken(token);

            if (user != null && user.Token_Expiration > DateTime.UtcNow) // Check if the token is valid and not expired
            {
                // Hash the password before saving it (for security)
                string hashedPassword = HashPassword(newPassword);

                // Update the user's password in the database
                userdb.UpdateUserPassword(user.Username, hashedPassword);

                // Invalidate the token after use
                userdb.ClearResetToken(user.Username);

                return true;
            }
            return false; // Invalid or expired token
        }

        // generating a simplified secure random token (16 bytes)
        private string GenerateSecureToken()
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder token = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                for (int i = 0; i < 16; i++)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    token.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }
            }
            return token.ToString();
        }
        // Method to clear the token after successful password reset
        public void ClearResetTokenByToken(string token)
        {
            // Clear the token from the user in the database
            userdb.ClearResetToken(token);
        }

        // Password hashing
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
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
            userdb.CreateUser(user);
        }
        public void DeleteUser(ObjectId id)
        {
            userdb.DeleteUser(id);
        }

        public void UpdateUser(User user)
        {
            userdb.UpdateUser(user);
        }
        public List<User> GetAllServiceUsers()
        {
            return userdb.GetAllServiceUsers();

        }
    }
}
