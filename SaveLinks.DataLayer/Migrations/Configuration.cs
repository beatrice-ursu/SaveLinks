using SaveLinks.DataLayer.Entities;

namespace SaveLinks.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SaveLinks.DataLayer.DbContext.SaveLinksDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SaveLinks.DataLayer.DbContext.SaveLinksDbContext";
        }

        protected override void Seed(SaveLinks.DataLayer.DbContext.SaveLinksDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Persons.AddOrUpdate(
              p => p.Id,
              new Person { LastName = "Ursu", FirstName = "Robert", Age = 21, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now},
              new Person { LastName = "Toma", FirstName = "Beatrice", Age = 22, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
              new Person { LastName = "Naidin", FirstName = "Vlad", Age = 23, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now }
            );
            //
        }
    }
}
