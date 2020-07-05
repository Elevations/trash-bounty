using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrashBountyLib.Models
{
    public class CompletedBounty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("BountyId")]
        [JsonProperty("BountyId")]
        public string BountyId { get; set; }

        [BsonElement("CompletedBountyPictureLinks")]
        [JsonProperty("CompletedBountyPictureLinks")]
        public List<string> CompletedBountyPictureLinks { get; set; }

        [BsonElement("UserIds")]
        [JsonProperty("UserIds")]
        public List<string> UserIds { get; set; }

        [BsonElement("Points")]
        [JsonProperty("Points")]
        public int Points { get; set; }
    }
}