using FGA.Congressus2.Data.Context;
using FGA.Congressus2.Data.Repositories.Interfaces;
using FGA.Congressus2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Data.Repositories
{
    public class EventosRepository : Repository<Eventos>, IEventosRepository
    {
        public EventosRepository(IdentityContext idContext, Congressus2Entities context) : base (idContext, context)
        {
        }
    }
}
