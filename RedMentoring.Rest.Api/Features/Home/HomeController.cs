using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace RedMentoring.Rest.Api.Features.Home
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Index()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("<html><body><h1>RedMentoring.Rest.Api</h1></body></html>", Encoding.UTF8, "text/html");
            return response;
        }
    }
}
