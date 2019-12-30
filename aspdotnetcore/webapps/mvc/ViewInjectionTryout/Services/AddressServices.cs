using System.Collections.Generic;

namespace ViewInjectionTryout.Services
{
    public class AddressServices
    {
        public List<string> ListCities()
        {
            return new List<string>()
            {
                "Redmond", "Bellevue", "Kirkland", "Bothell"
            };
        }

        public List<string> ListStates()
        {
            return new List<string>()
            {
                "California", "Oregon", "Washington"
            };
        }
    }
}