using IoCWebServiceSampleServicesProject.Implementations;
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
            var service = new StatisticsService();
            return Convert.ToString(service.GetCountryPopulation(id));
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
