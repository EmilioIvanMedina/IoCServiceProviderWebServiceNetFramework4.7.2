using IoCWebServiceSampleServicesProject.Interfaces;

namespace IoCWebServiceSampleServicesProject.Implementations
{
    public class CountryService : ICountryService
    {
        public string GetCountryName(int idCountry) =>
            idCountry == 1 ? "ARGENTINA" :
            idCountry == 2 ? "BOLIVIA" :
            idCountry == 3 ? "PERU" :
            "NO DATA";
    }
}
