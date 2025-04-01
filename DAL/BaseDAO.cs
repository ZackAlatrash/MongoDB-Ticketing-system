using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;

namespace DAL
{
    public abstract class BaseDao
    {
        public MongoClient mongoClient;

        public BaseDao()
        {

            string connectionString = "mongodb+srv://mahmoudf1993:Newline!2@sqlproject.9gzhd.mongodb.net/?retryWrites=true&w=majority&appName=SQLProject";
            mongoClient = new MongoClient(connectionString);
            //var collection = mongoClient.GetDatabase("CRUDProject").GetCollection<BsonDocument>("User");
            //var filter = Builders<BsonDocument>.Filter.Eq("first_name", "John");
            //var document = collection.Find(filter).First();
            //Console.WriteLine(document);
        }

        protected IMongoCollection<BsonDocument> READCollection(string collectionName)
        {
            return mongoClient.GetDatabase("CRUDProject").GetCollection<BsonDocument>(collectionName);
        }

        
    }
}
