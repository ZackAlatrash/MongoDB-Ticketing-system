using Model;
using MongoDB.Bson;
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

namespace Forms_UI
{
    public partial class TransferingTicketsForm : Form
    {
        private Ticket selectedTicket;
        private UserService userService;
        private TransferTickets transferTickets;

        public TransferingTicketsForm(Ticket ticket)
        {
            InitializeComponent();
            userService = new UserService();
            transferTickets = new TransferTickets();
            this.selectedTicket = ticket;
            LoadUsersIntoComboBox();
            this.selectedTicketLabel.Text = selectedTicket.Title;
        }

        public TransferingTicketsForm()
        {
            InitializeComponent();
        }

        private void LoadUsersIntoComboBox()
        {
            List<User> users = userService.GetAllUsers();

            foreach (var user in users)
            {
                usersComboBox.Items.Add(new ComboBoxItem(user.First_Name + " " + user.Last_Name, user.Id));
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            // Get the selected user
            ComboBoxItem selectedItem = (ComboBoxItem)usersComboBox.SelectedItem;
            ObjectId newHandlerId = (ObjectId)selectedItem.Value;

            // Transfer the ticket
            transferTickets.Transfer(selectedTicket.Id, newHandlerId);

            MessageBox.Show("Ticket transferred successfully!");

            this.Close();  // Close the form after transfer
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;  // Display text in the combo box
        }
    }

}

