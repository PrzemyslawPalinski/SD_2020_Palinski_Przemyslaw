using System;

namespace VolleyballApp.API.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public DateTime TimeOfMatch { get; set; }
    }
}