using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FGA.Congressus2.Entities.Identity
{
    public class User : IdentityUser<string, UserLogin, UserRole, UserClaim>
    {
        public string UserId { get; set; }
        public override string Id
        {
            get
            {
                return UserId;
            }
            set
            {
                UserId = value;
            }
        }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User,string> manager, string authenticationType)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }
}
