using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiTesteVideo.Models;

namespace ApiTesteVideo.Controllers
{
    public class TesteController : ApiController
    {
        [Route("api/teste")]
        public HttpResponseMessage GetTeste()
        {
            List<Retorno> retornos = Retorno.ObterRetorno();
            return Request.CreateResponse<List<Retorno>>(HttpStatusCode.OK, retornos);
        }
    }
}
