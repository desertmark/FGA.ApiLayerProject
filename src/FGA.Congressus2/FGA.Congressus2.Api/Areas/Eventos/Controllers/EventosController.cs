using FGA.Congressus2.Data.Context;
using FGA.Congressus2.Data.Repositories;
using FGA.Congressus2.Entities;
using FGA.Congressus2.Negocio.Interfaces;
using FGA.Congressus2.Negocio.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FGA.Congressus2.Api.Areas.Eventos.Controllers
{
    public class EventosController : ApiController
    {
        private readonly IEventosNegocio EventosNegocio;
        public EventosController(IEventosNegocio eventosNegocio)
        {
            EventosNegocio = eventosNegocio;//new EventosNegocio(new EventosRepository(new IdentityContext(), new Congressus2Entities()));
        }
        // GET api/<controller>
        public async Task<IHttpActionResult> Get()
        {
            var q = await EventosNegocio.FindAll();
            return Ok(q.Result.ToList());
        }

        // GET api/<controller>/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var e = await EventosNegocio.FindById(id);
            return Ok(e.Result);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}