using CesarRibeiro.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace CesarRibeiro.Infra.Migrations
{   
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

    }
}
