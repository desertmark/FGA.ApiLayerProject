using FGA.Congressus2.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FGA.Congressus2.Data.Stores
{
    public class UsuarioStore : UserStore<User, Role, string, UserLogin, UserRole, UserClaim>
    {
        public UsuarioStore(DbContext context) : base(context)
        {
        }
    }
}
