using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerAPIWeb.Controllers
{
    public class EjemploController : ApiController
    {
        public string Get(string prueba)
        {
            return "value";
        }
    }
}
