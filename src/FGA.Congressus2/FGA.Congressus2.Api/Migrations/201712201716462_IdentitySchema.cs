namespace FGA.Congressus2.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentitySchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Identity.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "Identity.UserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("Identity.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("Identity.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "Identity.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "Identity.UserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Identity.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "Identity.UserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("Identity.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Identity.UserRoles", "UserId", "Identity.Users");
            DropForeignKey("Identity.UserLogins", "UserId", "Identity.Users");
            DropForeignKey("Identity.UserClaims", "UserId", "Identity.Users");
            DropForeignKey("Identity.UserRoles", "RoleId", "Identity.Roles");
            DropIndex("Identity.UserLogins", new[] { "UserId" });
            DropIndex("Identity.UserClaims", new[] { "UserId" });
            DropIndex("Identity.Users", "UserNameIndex");
            DropIndex("Identity.UserRoles", new[] { "RoleId" });
            DropIndex("Identity.UserRoles", new[] { "UserId" });
            DropIndex("Identity.Roles", "RoleNameIndex");
            DropTable("Identity.UserLogins");
            DropTable("Identity.UserClaims");
            DropTable("Identity.Users");
            DropTable("Identity.UserRoles");
            DropTable("Identity.Roles");
        }
    }
}
