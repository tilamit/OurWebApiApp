using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Utilities;

namespace WebApiApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("api/values/GetSampleReport")]
        public HttpResponseMessage GetSampleReport()
        {
            string reportPath = "~/Reports/";
            string reportFileName = "SampleReport.rpt";
            string exportFilename = "SampleReport.pdf";

            HttpResponseMessage result = CrystalReport.RenderReport(reportPath, reportFileName, exportFilename);
            return result;
        }
    }
}
