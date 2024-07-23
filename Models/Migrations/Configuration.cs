using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Migrations
{
    internal sealed class Configuration: DbMigrationsConfiguration<Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Models.DatabaseContext";
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
