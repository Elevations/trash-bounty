using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace TrashBountyLib.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Username")]
        [Required]
        [JsonProperty("Username")]
        public string Username { get; set; }

        [BsonElement("Email")]
        [Required]
        [EmailAddress]
        [JsonProperty("Email")]
        public string Email { get; set; }

        [BsonElement("Password")]
        [Required]
        [JsonProperty("Password")]
        public string Password { get; set; }

        [BsonElement("ProfileImageLink")]
        [JsonProperty("ProfileImageLink")]
        public string ProfileImageLink { get; set; }

        [BsonElement("PostedBountyIds")]
        [JsonProperty("PostedBountyIds")]
        public List<string> PostedBountyIds = new List<string>();

        [BsonElement("CompletedBountyIds")]
        [JsonProperty("CompletedBountyIds")]
        public List<string> CompletedBountyIds = new List<string>();

        [BsonElement("Points")]
        [JsonProperty("Points")]
        public int Points { get; set; }

        [BsonElement("BountyPoints")]
        [JsonProperty("BountyPoints")]
        public List<BountyPoint> BountyPoints = new List<BountyPoint>();
    }

    public struct BountyPoint
    {
        public string CompletedBountyId { get; set; }
        public int Points { get; set; }
    }
}
