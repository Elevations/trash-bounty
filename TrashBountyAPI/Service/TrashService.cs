using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashBountyLib.Models;
using TrashBountyAPI.Models;

/*namespace TrashBountyAPI.Service
{
    /*
     * TODO: FIX ALL THE NAMING SCHEMES!!!
     *
    public class TrashService
    {
        private readonly IMongoCollection<Bounty> _tempTrashColl;

        public TrashService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _tempTrashColl = database.GetCollection<Bounty>(settings.TrashCollectionName);
        }

        public List<Bounty> Get() =>
            _tempTrashColl.Find(bounty => true).ToList();

        public Bounty Get(string id) =>
            _tempTrashColl.Find<Bounty>(bounty => bounty.Id == id).FirstOrDefault();

        //public async Task<bool> User GetAsync(string id) =>
        //_tempUsersColl.Find<User>(user => user.Id == id).FirstOrDefault();

        public Bounty Create(Bounty b)
        {
            _tempTrashColl.InsertOne(b);
            return b;
        }

        public async Task<bool> CreateAsync(Bounty b)
        {
            await _tempTrashColl.InsertOneAsync(b);

            return true;
        }

        public void Update(string id, Bounty b) =>
            _tempTrashColl.ReplaceOne(trash => trash.Id == id, b);

        public void Remove(Bounty b) =>
            _tempTrashColl.DeleteOne(user => user.Id == b.Id);

        public void Remove(string id) =>
            _tempTrashColl.DeleteOne(user => user.Id == id);
    }
}*/