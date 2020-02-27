using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using KelnerStoliki.Models.SampleData;
using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace KelnerStoliki.Controllers.ApiControllers {
    public class DaniaLookupController : ApiController {

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(SampleData.Dania, loadOptions));
        }
    }
}
