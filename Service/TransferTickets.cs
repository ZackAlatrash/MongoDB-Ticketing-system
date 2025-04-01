using DAL;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TransferTickets
    {
        private TicketDAO ticketDAO;

        public TransferTickets()
        {
            ticketDAO = new TicketDAO();
        }

        public void Transfer(ObjectId ticketId, ObjectId newHandlerId)
        {
            ticketDAO.TransferTicket(ticketId, newHandlerId);
        }
    }
}
