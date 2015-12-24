using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Configuration;

namespace AgendaMongoDB
{
    public class ConexaoDB : IDisposable
    {
        public IMongoClient MongoClient { get; }
        public IMongoCollection<BsonDocument> MongoCollection { get; }

        public ConexaoDB()
        {
            try
            {
                var host = ConfigurationManager.AppSettings["host"];
                var databaseName = ConfigurationManager.AppSettings["database"];
                var collectionName = ConfigurationManager.AppSettings["collection"];

                MongoClient = new MongoClient(host);
                IMongoDatabase database = MongoClient.GetDatabase(databaseName);
                MongoCollection = database.GetCollection<BsonDocument>(collectionName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
