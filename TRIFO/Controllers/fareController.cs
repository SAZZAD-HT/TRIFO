using BAL.Services;
using BAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TRIFO.Controllers
{
    public class fareController : ApiController
    {
        [HttpGet]
        [Route("api/Fare")]
        public HttpResponseMessage Get()
        {
            var data = Fareservices.GetFare();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Fare/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = Fareservices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Doctor/add")]
        [HttpPost]
        public HttpResponseMessage Add(FareDto obj)
        {
            var data = Fareservices.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
