using IoCWebServiceSampleServicesProject.Interfaces;
using System;

namespace IoCWebServiceSampleServicesProject.Implementations
{
    public class StatisticsService : IStatisticsService
    {
        ICountryService _countryService;

        public StatisticsService(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public int GetCountryPopulation(int countryId)
        {
            var countryName = _countryService.GetCountryName(countryId);

            return countryName == "ARGENTINA" ? 46230000 :
                countryName == "BOLIVIA" ? 12220000 :
                throw new ApplicationException("NO DATA");
        }
    }
}
