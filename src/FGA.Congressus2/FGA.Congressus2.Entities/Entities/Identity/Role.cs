using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FGA.Congressus2.Entities.Identity
{
    public partial class Role : IdentityRole<string, UserRole>
    {
    }
}
