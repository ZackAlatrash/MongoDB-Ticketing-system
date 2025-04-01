using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Forms_UI
{
    public partial class ResetPasswordForm : Form
    {
        private UserService userService;
        private string token;  // The token is passed to this form

        public ResetPasswordForm(string token)
        {
            InitializeComponent();
            userService = new UserService();
            this.token = token;  // Store the token for verification
            PassTxtBox.PasswordChar = '*';
            ConfPassTxtBox.PasswordChar = '*';
        }

        private void ChangePasBtn_Click(object sender, EventArgs e)
        {
            string newPassword = PassTxtBox.Text;
            string confirmPassword = ConfPassTxtBox.Text;

            // Check if the passwords match
            if (newPassword == confirmPassword)
            {
                // If they match, update the password in the database based on the token
                bool success = userService.ResetPasswordByToken(token, newPassword);

                if (success)
                {
                    MessageBox.Show("Password reset successfully!");

                    userService.ClearResetTokenByToken(token);  // Invalidate the token after use

                    this.Close();  // Close only the reset password form

                    // Optionally, focus on the existing login form
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is LoginForm)
                        {
                            form.BringToFront(); // Bring the existing login form to the front
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to reset the password. Invalid or expired token.");
                }
            }
            else
            {
                // Show an error if the passwords don't match
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
