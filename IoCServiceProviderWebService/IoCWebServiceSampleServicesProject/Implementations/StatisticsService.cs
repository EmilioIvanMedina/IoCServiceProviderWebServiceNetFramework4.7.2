using IoCWebServiceSampleServicesProject.Interfaces;
using System;

namespace IoCWebServiceSampleServicesProject.Implementations
{
    public class StatisticsService : IStatisticsService
    {
        public int GetCountryPopulation(int countryId)
        {
            var countryService = new CountryService();
            var countryName = countryService.GetCountryName(countryId);

            return countryName == "ARGENTINA" ? 46230000 :
                countryName == "BOLIVIA" ? 12220000 :
                throw new ApplicationException("NO DATA");
        }
    }
}
