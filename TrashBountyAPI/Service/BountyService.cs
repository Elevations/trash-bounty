using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashBountyLib.Models;

namespace TrashBountyAPI.Service
{
    public class BountyService
    {
        private readonly IMongoCollection<Bounty> _openBountyColl;
        private readonly IMongoCollection<Bounty> _completedBountyColl;
        public BountyService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _openBountyColl = database.GetCollection<Bounty>(settings.OpenBountiesCollectionName);
            _completedBountyColl = database.GetCollection<Bounty>(settings.ClosedBountiesCollectionName);
        }
        public List<Bounty> GetOpen()
        {
            return _openBountyColl.Find(bounty => true).ToList();
        } 
        public Bounty GetOpen(string id) =>
            _openBountyColl.Find<Bounty>(bounty => bounty.Id == id).FirstOrDefault();

        public List<Bounty> GetOpen(int limit)
        {
            return _openBountyColl.Find(bounty => true).Skip(0).Limit(limit).ToList();
        }
        public Bounty CreateOpen(Bounty b)
        {
            _openBountyColl.InsertOne(b);
            return b;
        }
        public List<Bounty> GetClosed(int limit)
        {
            return _completedBountyColl.Find(bounty => true).Skip(0).Limit(limit).ToList();
        }
        public async Task<bool> CreateOpenAsync(Bounty b)
        {
            await _openBountyColl.InsertOneAsync(b);
            return true;
        }
        public void UpdateOpen(string id, Bounty b)
        {
            _openBountyColl.ReplaceOne(trash => trash.Id == id, b);
        } 
        public void RemoveOpen(Bounty b)
        {
            _openBountyColl.DeleteOne(user => user.Id == b.Id);
        } 
        public void RemoveOpen(string id)
        {
            _openBountyColl.DeleteOne(user => user.Id == id);
        }

       public async Task<bool> CreateCloseAsync(Bounty b)
        {
            await _completedBountyColl.InsertOneAsync(b);
            return true;
        }
    }
}
