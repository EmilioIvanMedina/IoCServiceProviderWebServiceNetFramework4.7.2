using IoCWebServiceSampleServicesProject.Implementations;
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
        // GET: api/Country
        public IEnumerable<string> Get()
        {
            return new string[] { "ARGENTINA", "PERU" };
        }

        // GET: api/Country/5
        public string Get(int id)
        {
            var service = new CountryService();
            return service.GetCountryName(id);
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
