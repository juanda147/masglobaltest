using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HandsOn.Business;

namespace HandsOn.Controllers
{
    public class EmployeeAPIController : ApiController
    {
        [HttpGet]
        public IList<dynamic> GetAllEmployees()
        {
            return null;
        }
    }
}
