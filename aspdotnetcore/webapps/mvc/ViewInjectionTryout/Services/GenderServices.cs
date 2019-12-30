using System.Collections.Generic;

namespace ViewInjectionTryout.Services
{
    public class GenderServices
    {
        public List<string> ListGenders()
        {
            return new List<string>()
            {
                "male", "female", "not specified"
            };
        }
    }
}