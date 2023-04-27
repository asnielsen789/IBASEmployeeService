using MongoDB.Bson;
using System.Text.Json;

namespace IBASEmployeeService.Models
{
    public class Item
    {
        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public string? id { get; set; }
        public string Category{get;set;}
        public Henvendelse Henvendelse {get;set;}

        public Item(){

        }
    }
}