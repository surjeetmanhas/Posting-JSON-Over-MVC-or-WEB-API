using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContosoUniversity.Controllers
{
    public class StudentAPIController : ApiController
    {
        [HttpPost]
        public string TestAction([FromBody]string  student)
        {
            //return "Hello from http post web api controller: " + student;
            return student;
        }
    }
}
