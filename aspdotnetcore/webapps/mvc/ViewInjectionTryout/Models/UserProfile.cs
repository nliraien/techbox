using System;

namespace ViewInjectionTryout.Models
{
    public class UserProfile
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}