using FGA.Congressus2.Data.Context;
using FGA.Congressus2.Data.Stores;
using FGA.Congressus2.Entities.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Threading.Tasks;

namespace FGA.Congressus2.Negocio.Negocio
{
    // Configure el administrador de usuarios de aplicación que se usa en esta aplicación. UserManager se define en ASP.NET Identity y se usa en la aplicación.

    public class UsuarioNegocio : UserManager<User, string>
    {
        public UsuarioNegocio(IUserStore<User, string> store)
            : base(store)
        {
        }

        public override Task<IdentityResult> CreateAsync(User user, string password)
        {
            user.Id = Guid.NewGuid().ToString();
            return base.CreateAsync(user, password);
        }

        public override Task<IdentityResult> CreateAsync(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            return base.CreateAsync(user);
        }

        public static UsuarioNegocio Create(IdentityFactoryOptions<UsuarioNegocio> options, IOwinContext context)
        {
            var manager = new UsuarioNegocio(new UsuarioStore(context.Get<IdentityContext>()));
            // Configure la lógica de validación de nombres de usuario
            manager.UserValidator = new UserValidator<User>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure la lógica de validación de contraseñas
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<User>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }
}
