using BL;
using ET;
using System.Collections.Generic;
using System.Web.Http;

namespace ApiTest.Controllers
{
    public class PersonasController : ApiController
    {

        private PersonaBL personaBL = new PersonaBL();


        // GET: api/Persona
        [HttpGet]
        [Route("api/list")]
        public IEnumerable<Persona> Get()
        {
            var personas = personaBL.Listar();
            return personas;
        }

        // POST: api/Persona
        [HttpPost]
        [Route("api/register")]
        public bool Post([FromBody]Persona persona )
        {
            var personas = personaBL.Registrar(persona);
            return personas;
        }

    }
}
