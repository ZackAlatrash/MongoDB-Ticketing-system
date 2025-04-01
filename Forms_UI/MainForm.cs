using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;
using Model.Enums;
using static MongoDB.Driver.WriteConcern;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using MongoDB.Bson;

namespace Forms_UI
{
    public partial class MainForm : Form
    {
        UserService userService;
        TicketService ticketService;
        public MainForm()
        {
            InitializeComponent();
            userService = new UserService();
            ticketService = new TicketService();
            PopulateSortCombobox();
        }

        private void tabPageDashboard_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            List<User> users = userService.GetAllUsers();
            PopulateUserView(users);
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.GetAllTickets();
            PopulateTicketView(tickets);

            PieChart chartUnresolved = new PieChart();
            PieChart chartDeadline = new PieChart();
            chartUnresolved.Size = new Size(250, 250);
            chartDeadline.Size = new Size(250, 250);
            chartUnresolved.Location = new Point(75, 75);
            chartDeadline.Location = new Point(75, 75);
            pnlUnresolvedIncidents.Controls.Add(chartUnresolved);
            pnlIncidentsPDeadline.Controls.Add(chartDeadline);
            chartDeadline.Colors = new Color[] { Color.Salmon, Color.LightGray };
            chartDeadline.Values = new float[] { 50, 40 };
            chartUnresolved.Colors = new Color[] { Color.Orange, Color.LightGray };
            chartUnresolved.Values = new float[] { 50, 40 };
        }

        private void txtFilterByEmailIncident_KeyPress(object sender, EventArgs e)
        {
            //Convert EventArgs to proper type
            KeyPressEventArgs args = (KeyPressEventArgs)e;
            //Check if the pressed key was the enter key
            if (args.KeyChar == (Char)Keys.Enter)
            {
                args.Handled = true;
                //If key was the enter key, search the tickets for those that fit
                TicketService ticketService = new TicketService();

                List<Ticket> tickets = ticketService.GetTicketsFromSearchQuery(txtFilterByEmailIncident.Text);
                PopulateTicketView(tickets);

            }
        }

        void PopulateSortCombobox()
        {
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("");

            foreach (Priority priority in Enum.GetValues(typeof(Priority)))
            {
                sortComboBox.Items.Add(priority);
            }

            if (sortComboBox.Items.Count > 0)
            {
                sortComboBox.SelectedIndex = 0;
            }

        }
        private void PopulateTicketView(List<Ticket> tickets)
        {
            ticketView.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                //Title, description, username, status, priority
                UserService userService = new UserService();
                /*ListViewItem li = new ListViewItem(new string[5] { ticket.Title, ticket.Description, userService.GetUserById(ticket.Reporter_id).ToString(), ticket.Status.ToString(), ((Priority)ticket.Priority).ToString() });*/

                ListViewItem li = new ListViewItem(new string[7] { ticket.Title, ticket.Description, userService.GetUserById(ticket.Reporter_id).ToString(),userService.GetUserById(ticket.Handler_id).ToString(), ticket.Status.ToString(), ((Priority)ticket.Priority).ToString(), ticket.Start_Date.ToString() });
                li.Tag = ticket;
                ticketView.Items.Add(li);
            }
        }



        private void PopulateUserView(List<User> users)
        {
            usersList.Items.Clear();
            foreach (User user in users)
            {
                // Populate ListView with correct values
                ListViewItem li = new ListViewItem(new string[4]
                {
                    user.First_Name,
                    user.Last_Name,
                    user.Email,
                    user.Role.ToString()  // Ensure the role is shown as a string
                });
                li.Tag = user;
                usersList.Items.Add(li);
            }
        }


        private ListViewItem CreateUserListViewItem(User user)
        {
            return new ListViewItem(new string[4] {
                user.First_Name,
                user.Last_Name,
                user.Username,
                user.Role.ToString()
            })
            { Tag = user };
        }
        private List<Ticket> SearchForTickets(string text)
        {
            string query = text.ToLower(); //Make the query lowercase for simplicity,
                                           //also avoids having to look for both 'and' and 'AND'. Same with 'or' and 'OR'
            query = query.Replace(", ", " or "); //turn every , into an 'or'. Other way around would work too
            query = query.Replace(" & ", " and "); //turn every & into an 'and'. Other way around would work too
            string[] splits = query.Split(" or "); //split the query into pieces to search for the different keywords
            List<Ticket> results = new List<Ticket>();
            foreach (string s in splits)
            {
                string[] searchKeywords = s.Split(" and "); //split any keywords with an 'and' in them
                foreach (ListViewItem li in ticketView.Items)
                {
                    Ticket ticket = (Ticket)li.Tag;
                    bool hasKeywords = true;
                    foreach (string keyword in searchKeywords)
                    {
                        string trimmedKeyword = keyword.Trim(); //remove trailing whitespace that could mess up the search
                        if (!ticket.Title.ToLower().Contains(trimmedKeyword) && !ticket.Description.ToLower().Contains(trimmedKeyword)) { hasKeywords = false; break; } //set to lowercase to avoid capitalization mistakes
                    }
                    if (hasKeywords && !results.Contains(ticket)) //if there isn't already a copy in the list,
                                                                  //because the query has 2 keywords that apply
                    {
                        results.Add(ticket);
                    }
                }
            }
            return results;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                //Update piecharts with new data
            }
            else if (tabControl.SelectedIndex == 1)
            {
                //Disable update and delete buttons until something is selected
                UpdateTicketView();
                btnDeleteIncident.Enabled = false;
                btnUpdateIncident.Enabled = false;
            }
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            IncidentCreatorModal incidentCreatorModal = new IncidentCreatorModal(this, null);
            incidentCreatorModal.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            // Pass a reference of MainForm to CreateUserForm
            CreateUserForm createUserForm = new CreateUserForm(this);
            createUserForm.Show();
        }

        public void RefreshUserList()
        {
            // Get all users from the database
            List<User> users = userService.GetAllUsers();

            // Clear the existing items in the users list view
            usersList.Items.Clear();

            // Repopulate the list view with the updated user list
            foreach (User user in users)
            {
                ListViewItem li = new ListViewItem(new string[]
                {
                    user.First_Name,
                    user.Last_Name,
                    user.Email,
                    user.Role.ToString()  // Convert role to string for display
                });
                li.Tag = user;
                usersList.Items.Add(li);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ticketView.SelectedItems.Count > 0)
            {
                // Get the selected ticket
                Ticket selectedTicket = (Ticket)ticketView.SelectedItems[0].Tag;

                // Open the TransferTickets form, passing the selected ticket
                TransferingTicketsForm transferForm = new TransferingTicketsForm(selectedTicket);
                transferForm.ShowDialog();  // Show the form modally
            }
            else
            {
                MessageBox.Show("Please select a ticket to transfer.");
            }
        }



        private void deleteUserButton_Click_1(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
            {
                User selectedUser = (User)usersList.SelectedItems[0].Tag;

                userService.DeleteUser(selectedUser.Id);

                MessageBox.Show("User updated successfully!");
                RefreshUserList();
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
            {
                User selectedUser = (User)usersList.SelectedItems[0].Tag;

                UpdateUserForm updateUserForm = new UpdateUserForm(selectedUser, this);
                updateUserForm.Show();
            }
            else
            {
                MessageBox.Show("Select a user to update");
            }
        }

        private void txtFilterByEmailIncident_TextChanged(object sender, EventArgs e)
        {

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ticket> tickets = ticketService.GetAllTickets();

            ticketView.Items.Clear();

            if (sortComboBox.SelectedItem is Priority selectedPriority)
            {
                foreach (Ticket ticket in tickets)
                {
                    if ((Priority)ticket.Priority == selectedPriority)
                    {
                        User user = userService.GetUserById(ticket.Reporter_id);
                        ListViewItem li = new ListViewItem(new string[5]
                        {
                    ticket.Title,
                    ticket.Description,
                    user.ToString(),
                    ticket.Status.ToString(),
                    ((Priority)ticket.Priority).ToString()
                        });
                        li.Tag = ticket;
                        ticketView.Items.Add(li);
                    }
                }
            }
            else
            {
                PopulateTicketView(tickets);
            }
        }

        private void txtFilterByEmail_TextChanged(object sender, EventArgs e)
        {
            List<User> users = userService.GetAllUsers();

            usersList.Items.Clear();

            string emailFilter = txtFilterByEmail.Text.Trim();
            List<User> filteredUsers = string.IsNullOrEmpty(emailFilter)
                ? users
                : users.Where(user => user.Email.Contains(emailFilter, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (User user in filteredUsers)
            {
                ListViewItem li = new ListViewItem(new string[]
                {
            user.First_Name,
            user.Last_Name,
            user.Email,
            user.Role.ToString()
                });
                li.Tag = user;
                usersList.Items.Add(li);
            }
        }

        private void ticketView_SelectedIndexChanged(object sender, EventArgs e)
        {//Disables the update and delete buttons if no ticket is selected
            try{if (ticketView.SelectedItems[0] != null){
                    btnDeleteIncident.Enabled = true;
                    btnUpdateIncident.Enabled = true;
                }
            }catch{
                btnDeleteIncident.Enabled = false;
                btnUpdateIncident.Enabled = false;
            }
        }

        private void btnUpdateIncident_Click(object sender, EventArgs e)
        {
            IncidentCreatorModal incidentCreatorModal = new IncidentCreatorModal(this, (Ticket)ticketView.SelectedItems[0].Tag);
            incidentCreatorModal.ShowDialog();
        }

        private void btnDeleteIncident_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TicketService ticketService = new TicketService();
                ticketService.DeleteTicket((Ticket)ticketView.SelectedItems[0].Tag);
                UpdateTicketView();
            }
        }

            public void UpdateTicketView()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.GetAllTickets();
            PopulateTicketView(tickets);
        }
    }
}
