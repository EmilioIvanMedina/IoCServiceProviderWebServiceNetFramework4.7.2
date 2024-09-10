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
    public class CountryController : ApiController
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: api/Country
        public IEnumerable<string> Get()
        {
            return new string[] { "ARGENTINA", "PERU" };
        }

        // GET: api/Country/5
        public string Get(int id)
        {
            return _countryService.GetCountryName(id);
        }

        // POST: api/Country
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Country/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Country/5
        public void Delete(int id)
        {
        }
    }
}
