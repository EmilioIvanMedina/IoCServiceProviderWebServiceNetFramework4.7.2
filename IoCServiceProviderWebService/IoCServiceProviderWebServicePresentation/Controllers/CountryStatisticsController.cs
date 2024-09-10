using IoCWebServiceSampleServicesProject.Implementations;
using IoCWebServiceSampleServicesProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoCServiceProviderWebServicePresentation.Controllers
{
    public class CountryStatisticsController : ApiController
    {
        private readonly ICountryService _countryService;
        private readonly IStatisticsService _statisticsService;

        public CountryStatisticsController(ICountryService countryService, IStatisticsService statisticsService)
        {
            _countryService = countryService;
            _statisticsService = statisticsService;
        }

        // GET: api/CountryStatistics
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CountryStatistics/Population/5
        [HttpGet]
        [Route("api/CountryStatistics/Population/{id}")]
        public string Population(int id)
        {
            return Convert.ToString(_statisticsService.GetCountryPopulation(id));
        }

        // POST: api/CountryStatistics
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CountryStatistics/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CountryStatistics/5
        public void Delete(int id)
        {
        }
    }
}
