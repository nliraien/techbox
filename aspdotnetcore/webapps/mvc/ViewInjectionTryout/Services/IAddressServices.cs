using System.Collections.Generic;

namespace ViewInjectionTryout.Services
{
    public interface IAddressServices
    {
        List<string> ListCities();

        List<string> ListStates();
    }
}