using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using TrashBountyLib;

namespace TrashBountyLib.Models
{
    public class NewBounty
    {
        [Required]
        public string Description { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string PosterId { get; set; }
        public string ImageData { get; set; }
    }
}
