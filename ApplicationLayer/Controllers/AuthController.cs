using ApplicationLayer.Models;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/auth")]
        public HttpResponseMessage Login(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            bool isAuthenticated = AuthService.Authenticate(login.Username, login.Password);

            if (isAuthenticated)
            {
                
                return Request.CreateResponse(HttpStatusCode.OK, "Authentication successful.");
            }
            else
            {
                
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid username or password");
            }
        }
    }
}
