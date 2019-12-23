using System;
using System.ComponentModel.DataAnnotations;

namespace RPMovies.Models
{
    public class Actor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
    }
}