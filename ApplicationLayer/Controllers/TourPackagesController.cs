using BusinessLogicLayer.DTOs;
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
        [HttpPost]
        [Route("api/tourpackages/create")]
        public HttpResponseMessage Create(TourPackagesDTO data)
        {
            try
            {
                var res = TourPackagesService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/tourpackages/update")]
        public HttpResponseMessage Update(TourPackagesDTO data)
        {
            var exmp = TourPackagesService.Get(data.TourPackageId);
            if (exmp != null)
            {
                try
                {
                    var res = TourPackagesService.Update(data);

                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated" });

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Tour Package is not found" });
        }
        [HttpPost]
        [Route("api/tourpackages/delete/{id}")]
        public HttpResponseMessage Delete(int Id) //int id
        {
            var exmp = TourPackagesService.Get(Id);

            if (exmp != null)
            {
                try
                {
                    var res = TourPackagesService.Delete(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Deleted" });

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Product not found" });
        }
    }
    
}
