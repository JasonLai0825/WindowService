using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace windowserviceTest.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/home")]
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Ok("test is success.");
        }
    }
}
