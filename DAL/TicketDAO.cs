using Model;
using Model.Enums;
using MongoDB.Bson;
using MongoDB.Driver;
using Model.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class TicketDAO : BaseDao
    {
        IMongoCollection<BsonDocument> collection;
        public TicketDAO()
        {
            collection = this.READCollection("Tickets");
        }
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();

            //Limit the amount of entries to 50, won't be the most recent
            List<BsonDocument> documents = collection.Find(_ => true).Limit(50).ToListAsync().Result;
            //Sort documents the same way as searching does, to keep it consistent
            documents = OrderDocumentsByRecent(documents);
            foreach (BsonDocument document in documents)
            { //Get all tickets
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }
        public List<Ticket> GetTicketsFromSearchQuery(string query)
        {
            //Make the query lowercase and replace the "," and "&" signs as those can be used for searching too
            query = query.ToLower();
            query = query.Replace(", ", " or ");
            query = query.Replace(" & ", " and ");

            List<Ticket> tickets = new List<Ticket>();

            if (query.Trim().Length == 0)
            {
                //If the query is empty, return all tickets instead
                //This primarily happens when removing your query
                return GetAllTickets();
            }
            //Split the query into segments which are handled alone
            string[] segments = query.Split(" or ");
            List<BsonDocument> documents = new List<BsonDocument>();
            foreach (string segment in segments)
            {
                //For each segment, make a search using the query in that segment as you can't combine multiple text searches
                string searchString = string.Empty;
                string[] andSplits = segment.Split(" and ");
                foreach (string split in andSplits)
                {
                    //Search for specific words, as otherwise you would always be using AND searching,
                    //so "database AND issues" would return the same as "database issues"
                    //MongoDB does use tokenization, so issu becomes issue, but databas doesn't become database
                    searchString += "\"" + split + "\" ";
                }
                searchString = searchString.Trim();
                FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Text(searchString);

                foreach (BsonDocument document in collection.Find(filter).ToListAsync().Result)
                {
                    documents.Add(document);
                }
            }
            //Flatten the list to remove duplicates and order them by date so the most recent is first
            documents = FlattenDocumentList(documents);
            documents = OrderDocumentsByRecent(documents);
            foreach (BsonDocument document in documents)
            {
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }
        private List<BsonDocument> OrderDocumentsByRecent(List<BsonDocument> documents)
        {
            IOrderedEnumerable<BsonDocument> orderedDocuments = documents.OrderBy(doc => doc["Start_Date"].ToUniversalTime());
            List<BsonDocument> returnList = new List<BsonDocument>(); //Make a new list to return sorted documents
            foreach (BsonDocument document in orderedDocuments)
            {
                returnList.Add(document);
            }
            //reverse list as order was ascending instead of descending
            returnList.Reverse();
            return returnList;
        }

        private List<BsonDocument> FlattenDocumentList(List<BsonDocument> documents)
        {
            List<BsonDocument> flattenedList = new List<BsonDocument>();
            foreach (BsonDocument document in documents)
            {
                bool inList = false;
                foreach (BsonDocument document2 in flattenedList)
                {
                    //If document already in the flattened list
                    if (document["_id"] == document2["_id"])
                    {
                        inList = true;
                    }
                }
                if (!inList)
                {
                    flattenedList.Add(document);
                }
            }
            return flattenedList;
        }
        public List<Ticket> GetTicketsFromSearchQuery2(string query)
        {
            List<Ticket> tickets = new List<Ticket>();

            if (query.Trim() == "")
            {
                //if query is just emptiness with no words, return all tickets instead
                return GetAllTickets();
            }
            //Split the query at " or "
            string[] orSplits = query.Split(" or ");
            List<FilterDefinition<BsonDocument>> andFilters = new List<FilterDefinition<BsonDocument>>();
            foreach (string orSplit in orSplits)
            {
                //Got all queries prepared
                //Now to split it at " and "
                string[] andSplits = orSplit.Split(" and ");
                List<FilterDefinition<BsonDocument>> currentFilters = new List<FilterDefinition<BsonDocument>>();
                foreach (string andSplit in andSplits)
                {
                    //Make filter for each split
                    currentFilters.Add(Builders<BsonDocument>.Filter.Text(andSplit));
                }
                andFilters.Add(Builders<BsonDocument>.Filter.And(currentFilters));
                //empty currentFilters so no duplicate filters occur.
                currentFilters.Clear();
            }
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Or(andFilters);


            foreach (BsonDocument document in collection.Find(filter).Sort(Builders<BsonDocument>.Sort.Ascending("Start_Date")).ToListAsync().Result)
            {
                //turn all results into tickets
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }

        public void CreateNewTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            collection.InsertOne(ticket);
        }

        public void UpdateTicket(Ticket updatedTicket)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(ticket => ticket.Id, updatedTicket.Id);

            collection.ReplaceOne(filter, updatedTicket);
        }
        public void DeleteTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, ticket.Id);

            collection.DeleteOne(filter);
        }
        public void UpdateTicketStatus(Ticket ticket, Status status)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            var filter = Builders<Ticket>.Filter.Eq("_id", ticket.Id);
            var update = Builders<Ticket>.Update.Set("Status", (int)status);
            collection.UpdateOne(filter, update);
        }
        
        public void TransferTicket(ObjectId ticketId, ObjectId newHandlerId)
        {
            var collection = this.READCollection("Tickets");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticketId);
            var update = Builders<BsonDocument>.Update.Set("Handler_id", newHandlerId);  // Update the Handler_id
            collection.UpdateOne(filter, update);
        }

    }
}
