using FGA.Congressus2.Data.Repositories;
using FGA.Congressus2.Data.Repositories.Interfaces;
using FGA.Congressus2.Entities;
using FGA.Congressus2.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Negocio.Negocio
{
    public class EventosNegocio : Negocio<Eventos>, IEventosNegocio
    {
        public EventosNegocio(IEventosRepository repository) : base(repository)
        {           
        }
    }
}
