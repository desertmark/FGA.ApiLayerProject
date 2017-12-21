using FGA.Congressus2.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FGA.Congressus2.Data.Context
{
    public class IdentityContext : IdentityDbContext<User, Role, string, UserLogin, UserRole, UserClaim>
    {
        public IdentityContext()
            : base("IdentityConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users", "Identity")
                .Ignore(u=>u.Id)
                .HasKey(u =>u.UserId);
            builder.Entity<UserLogin>().ToTable("UserLogins", "Identity");
            builder.Entity<UserClaim>().ToTable("UserClaims", "Identity");
            builder.Entity<UserRole>().ToTable("UserRoles", "Identity");
            builder.Entity<Role>().ToTable("Roles", "Identity");
                //.Property(u => u.Id).HasColumnName("RoleId"); 
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}
