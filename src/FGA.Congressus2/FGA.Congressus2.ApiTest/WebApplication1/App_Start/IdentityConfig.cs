//using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
//using Microsoft.Owin;
//using WebApplication1.Models;
//using System;
//using System.Security.Claims;
//using FGA.Congressus2.Entities.Entities;
//using FGA.Congressus2.Data.Context;

//namespace WebApplication1
//{
//    // Configure el administrador de usuarios de aplicación que se usa en esta aplicación. UserManager se define en ASP.NET Identity y se usa en la aplicación.

//    public class ApplicationUserManager : UserManager<User, string>
//    {
//        public ApplicationUserManager(IUserStore<User, string> store)
//            : base(store)
//        {
//        }

//        public override Task<IdentityResult> CreateAsync(User user, string password)
//        {
//            user.Id = Guid.NewGuid().ToString();
//            return base.CreateAsync(user, password);
//        }

//        public override Task<IdentityResult> CreateAsync(User user)
//        {
//            user.Id = Guid.NewGuid().ToString();
//            return base.CreateAsync(user);
//        }

//        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
//        {
//            var manager = new ApplicationUserManager(new UserStore<User, Role, string, UserLogin, UserRole, UserClaim>(context.Get<IdentityContext>()));
//            // Configure la lógica de validación de nombres de usuario
//            manager.UserValidator = new UserValidator<User>(manager)
//            {
//                AllowOnlyAlphanumericUserNames = false,
//                RequireUniqueEmail = true
//            };
//            // Configure la lógica de validación de contraseñas
//            manager.PasswordValidator = new PasswordValidator
//            {
//                RequiredLength = 6,
//                RequireNonLetterOrDigit = true,
//                RequireDigit = true,
//                RequireLowercase = true,
//                RequireUppercase = true,
//            };
//            var dataProtectionProvider = options.DataProtectionProvider;
//            if (dataProtectionProvider != null)
//            {
//                manager.UserTokenProvider = new DataProtectorTokenProvider<User>(dataProtectionProvider.Create("ASP.NET Identity"));
//            }
//            return manager;
//        }
//    }
//}
