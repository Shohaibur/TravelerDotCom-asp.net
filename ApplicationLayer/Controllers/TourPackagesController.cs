using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    public class TourPackagesController : ApiController
    {
        [HttpGet]
        [Route("api/tourpackages")]
        public HttpResponseMessage Tourpackages()
        {
            try
            {
                var data = TourPackagesService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/tourpackages/{id}")]
        public HttpResponseMessage GetTourPackages(int id)
        {
            try
            {
                var data = TourPackagesService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
       
    }
}
