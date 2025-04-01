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

namespace Forms_UI
{
    public partial class IncidentCreatorModal : Form
    {
        Ticket ticket;
        UserService userService;
        MainForm mainForm;
        public IncidentCreatorModal(MainForm main, Ticket ticket)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ticket = ticket;
            this.mainForm = main;
            userService = new UserService();
            PopulateReporterComboBox(userService.GetAllUsers());
            PopulateHandlerComboBox(userService.GetAllServiceUsers());
            if (ticket == null)
            {
                TopLabel.Text = "Create New Incident";
                btnSubmitIncident.Text = "Submit Incident";
                comboBoxStatus.SelectedIndex = 0;
                comboBoxPriority.SelectedIndex = 0;
            }
            else
            {
                TopLabel.Text = "Update Incident";
                btnSubmitIncident.Text = "Update Incident";
                FillOutFields(ticket);
            }


        }

        private void FillOutFields(Ticket ticket)
        {
            txtBoxSubjectofIncident.Text = ticket.Title;
            comboBoxPriority.SelectedIndex = (int)ticket.Priority;
            textBoxDescription.Text = ticket.Description;
            foreach (User user in comboBoxUsername.Items)
            {
                // If the UserId of the Ticket matches the Id of the User, select it
                if (user.Id == ticket.Reporter_id)
                {
                    comboBoxUsername.SelectedItem = user;
                    break;
                }
            }
            foreach (User user in comboBoxHandler.Items)
            {
                // If the UserId of the Ticket matches the Id of the User, select it
                if (user.Id == ticket.Handler_id)
                {
                    comboBoxHandler.SelectedItem = user;
                    break;
                }
            }
            dateTimeDeadline.Value = ticket.End_Date;
            dateTimeReportTime.Value = ticket.Start_Date;
            comboBoxStatus.SelectedIndex = (int)ticket.Status;
        }

        private void PopulateReporterComboBox(List<User> users)
        {
            foreach (User user in users)
            {

                comboBoxUsername.Items.Add(user);
            }
        }
        private void PopulateHandlerComboBox(List<User> users)
        {
            foreach (User user in users)
            {

                comboBoxHandler.Items.Add(user);
            }
        }

        private void btnCancelIncidentSubmission_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitIncident_Click(object sender, EventArgs e)
        {
            Priority priority;
            try
            {
                priority = (Priority)Enum.Parse(typeof(Priority), comboBoxPriority.Text);
            }
            catch
            {
                priority = Priority.Low;
            }
            Status status;
            try
            {
                status = (Status)Enum.Parse(typeof(Status), comboBoxStatus.Text);
            }
            catch
            {
                status = Status.Open;
            }

            TicketService ticketService = new TicketService();


            ObjectId reporterid = ((User)(comboBoxUsername.SelectedItem)).Id;
            ObjectId handlerid = ((User)(comboBoxHandler.SelectedItem)).Id;
            Ticket ticket = new Ticket(txtBoxSubjectofIncident.Text, textBoxDescription.Text, reporterid, handlerid, status, dateTimeReportTime.Value, dateTimeDeadline.Value, priority);
            if (this.ticket != null)
            {
                ticket.Id = this.ticket.Id;
                ticketService.UpdateTicket(ticket);
            }
            else
            {
                ticketService.CreateNewTicket(ticket);
                MessageBox.Show("Ticket succesfully added");
            }

            mainForm.UpdateTicketView();
            this.Close();
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                // Disable the close button by removing the system menu close option
                const int CS_NOCLOSE = 0x200;
                myCp.ClassStyle |= CS_NOCLOSE;
                return myCp;
            }
        }
    }
}
