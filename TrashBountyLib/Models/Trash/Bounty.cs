using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrashBountyLib.Models
{
    public class Bounty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Latitude")]
        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [BsonElement("Longitude")]
        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [BsonElement("PosterId")]
        [JsonProperty("PosterId")]
        public string PosterId { get; set; }

        [BsonElement("CompletedBountyId")]
        [JsonProperty("CompletedBountyId")]
        public string CompletedBountyId { get; set; }

        [BsonElement("BountyPictureLinks")]
        [JsonProperty("BountyPictureLinks")]
        public List<string> BountyPictureLinks { get; set; }
    }
}
