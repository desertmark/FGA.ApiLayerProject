using FGA.Congressus2.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Data.Context
{
    public partial class Congressus2Entities : DbContext
    {
        public static Congressus2Entities Create()
        {
            return new Congressus2Entities();
        }

        public static string GetSqlConnectionString(string serverName = ".", string databaseName = "congressus")
        {
            SqlConnectionStringBuilder providerCs = new SqlConnectionStringBuilder();

            providerCs.DataSource = serverName;
            providerCs.InitialCatalog = databaseName;
            providerCs.IntegratedSecurity = true;

            var csBuilder = new EntityConnectionStringBuilder();

            csBuilder.Provider = "System.Data.SqlClient";
            csBuilder.ProviderConnectionString = providerCs.ToString();

            csBuilder.Metadata = string.Format("res://{0}/Entities.Congressus2.csdl|res://{0}/Entities.Congressus2.ssdl|res://{0}/Entities.Congressus2.msl",
                typeof(Congressus2Entities).Assembly.FullName);

            return csBuilder.ToString();
        }
    }
}
