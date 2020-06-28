using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashBountyLib.Models;

namespace TrashBountyAPI.Service
{
    public class UserService
    {
        private readonly IMongoCollection<User> _tempUsersColl;

        public UserService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _tempUsersColl = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public List<User> Get()
        {
            return _tempUsersColl.Find(user => true).ToList();
        }

        public User Get(string id) =>
            _tempUsersColl.Find<User>(user => user.Id == id).FirstOrDefault();

        //public async Task<bool> User GetAsync(string id) =>
            //_tempUsersColl.Find<User>(user => user.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            _tempUsersColl.InsertOne(user);
            return user;
        }

        public async Task<bool> CreateAsync(User user)
        {
            await _tempUsersColl.InsertOneAsync(user);

            return true;
        }

        public void Update(string id, User userIn) =>
            _tempUsersColl.ReplaceOne(user => user.Id == id, userIn);

        public void Remove(User userIn) =>
            _tempUsersColl.DeleteOne(user => user.Id == userIn.Id);

        public void Remove(string id) =>
            _tempUsersColl.DeleteOne(user => user.Id == id);
    }
}
