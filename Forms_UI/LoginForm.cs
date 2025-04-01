using Service;
using Model;
using System.Net.Mail;
namespace Forms_UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;
        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
            PasswordBox.PasswordChar = '*';
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            User validUser = userService.ValidateUser(username, password);

            if (validUser != null)
            {
                MessageBox.Show("Login successful!");

                // Proceed to the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void ForgotPassLbl_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask for the username
                string username = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter your username:",
                    "Forgot Password - Step 1",
                    ""
                );

                // Check if the username is provided
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a valid username.");
                    return;
                }

                // Verify that the username exists in the database
                User user = userService.GetUserByUsername(username);
                if (user == null)
                {
                    MessageBox.Show("Username does not exist in the database. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If the username exists, ask for the recovery email
                string recoveryEmail = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter a recovery email address where we will send the password reset link:",
                    "Forgot Password - Step 2",
                    ""
                );

                // Check if the recovery email is provided
                if (string.IsNullOrEmpty(recoveryEmail))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Send the reset email to the recovery email address
                userService.SendPasswordResetEmail(username, recoveryEmail);
                MessageBox.Show("A password reset link has been sent to the provided recovery email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ask for the token immediately after the email is sent
                string token = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter the token you received in your email:",
                    "Enter Reset Token - Step 3",
                    ""
                );

                // Verify the token
                if (!userService.VerifyResetToken(username, token))
                {
                    MessageBox.Show("Invalid token. Please check your email for the correct token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If the token is valid, open the ResetPasswordForm
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm(token);
                resetPasswordForm.ShowDialog(); // Open the form to reset the password

            }
            catch (FormatException ex)
            {
                // Handle cases where email format is invalid
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (SmtpException ex)
            {
                // Handle SMTP-related errors
                MessageBox.Show("Failed to send the email. Please check your internet connection or email settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"SMTP Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show("An error occurred while trying to send the password reset email. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }


    }
}
