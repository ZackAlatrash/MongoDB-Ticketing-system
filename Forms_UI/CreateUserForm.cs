using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Enums;
using MongoDB.Bson;
using Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Forms_UI
{
    public partial class CreateUserForm : Form
    {
        private UserService userService;

        private MainForm mainForm;  // Store reference to MainForm

        public CreateUserForm(MainForm mainForm)  // Updated constructor to accept MainForm
        {
            InitializeComponent();
            userService = new UserService();  // Initialize the UserService
            this.mainForm = mainForm;  // Assign MainForm reference
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTypeofUser.Items.AddRange(Enum.GetNames(typeof(Roles)));
        }

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = firstNameTextBox.Text;
                string lastname = lastNameTextBox.Text;
                string username = $"{firstname}{lastname}";  // Create username by concatenating first and last names
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;

                if (comboBoxTypeofUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user role.");
                    return;
                }
                if (password != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password does not match");
                }

                // Parse the role from the combo box selection
                Roles role = (Roles)Enum.Parse(typeof(Roles), comboBoxTypeofUser.SelectedItem.ToString());

                User newUser = new User(ObjectId.GenerateNewId(), firstname, lastname, username, password, email, role);

                userService.CreateUser(newUser);
                mainForm.RefreshUserList();


                MessageBox.Show("User created successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
