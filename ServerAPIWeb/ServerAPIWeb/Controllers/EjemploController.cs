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
        // GET: api/Ejemplo/5
        public string Get(string valor, string token)
        {
            return valor+token;
        }
    }
}
