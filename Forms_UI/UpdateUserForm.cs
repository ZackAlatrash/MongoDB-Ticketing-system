using Model.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_UI
{
    public partial class UpdateUserForm : Form
    {
        private UserService userService;
        private User SelectedUser;
        private MainForm mainForm;
        public UpdateUserForm(User SelectedUser, MainForm mainForm)
        {
            InitializeComponent();
            userService = new UserService();
            this.SelectedUser = SelectedUser;
            this.mainForm = mainForm;
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            comboBoxTypeofUser.Items.AddRange(Enum.GetNames(typeof(Roles)));
            
            firstNameTextBox.Text = SelectedUser.First_Name;
            lastNameTextBox.Text = SelectedUser.Last_Name;
            comboBoxTypeofUser.Text = SelectedUser.Role.ToString();
            emailTextBox.Text = SelectedUser.Email;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string password = SelectedUser.Password;
                string firstname = firstNameTextBox.Text;
                string lastname = lastNameTextBox.Text;
                string username = $"{firstname}{lastname}";
                string email = emailTextBox.Text;
                Roles role = (Roles)Enum.Parse(typeof(Roles), comboBoxTypeofUser.SelectedItem.ToString());

                if (comboBoxTypeofUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user role.");
                    return;
                }

                User updatedUser = new User(SelectedUser.Id, firstname, lastname, username, password, email, role);



                userService.UpdateUser(updatedUser);

                MessageBox.Show("User updated successfully!");
                mainForm.RefreshUserList();
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        
    }
}
