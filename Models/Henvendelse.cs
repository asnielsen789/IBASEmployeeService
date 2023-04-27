using MongoDB.Bson;
using System.Text.Json;

namespace IBASEmployeeService.Models
{
    /// <summary>
    /// POCO for employee data
    /// </summary>
    public class Henvendelse
    {
        /*[BsonId]
        public string? Id { get; set; }*/
        public int HenvendelseId { get; set; }

        public Bruger Bruger { get; set; }
        public string Beskrivelse { get; set; }

        public int Kategori { get; set; }

        public DateTime Dato { get; set; }

        public Henvendelse()
        {

        }

    }
}
/*
"Henvendelse": {
        "HenvendelseId": 4,
        "Bruger": {
            "BrugerId": 1,
            "Navn": "Bob",
            "Email": "Bob@gmail.com",
            "Telefonnummer": 41784376
        },
        "Beskrivelse": "Jeg skal bruge en ny drivlinie til min racercykel",
        "Kategori": 2,
        "Dato": "04:04:2023"
    },
*/