using MongoDB.Bson;
using System.Text.Json;

namespace IBASEmployeeService.Models
{
    /// <summary>
    /// POCO for employee data
    /// </summary>
    public class Henvendelse
    {
        public int HenvendelseId { get; set; }
        public Bruger Bruger { get; set; }
        public string Beskrivelse { get; set; }
        public string Dato { get; set; }

        public Henvendelse(int henvendelseId, Bruger bruger, string beskrivelse, string dato)
        {
            HenvendelseId = henvendelseId;
            Bruger = bruger;
            Beskrivelse = beskrivelse;
            Dato = dato;
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