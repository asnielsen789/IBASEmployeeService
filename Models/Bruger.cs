namespace IBASEmployeeService.Models
{
    public class Bruger
    {
        public int BrugerId { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Telefonnummer { get; set; }
        public Bruger()
        {

        }
    }
}

/*
"Bruger": {
            "BrugerId": 1,
            "Navn": "Bob",
            "Email": "Bob@gmail.com",
            "Telefonnummer": 41784376
        },
*/