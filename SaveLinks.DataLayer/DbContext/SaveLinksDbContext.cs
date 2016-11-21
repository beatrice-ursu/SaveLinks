using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;
using SaveLinks.DataLayer.Entities;
using SaveLinks.DataLayer.Entities.Core;

namespace SaveLinks.DataLayer.DbContext
{
    public class SaveLinksDbContext : IdentityDbContext<ApplicationUser>
    {
        public SaveLinksDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public static SaveLinksDbContext Create()
        {
            return new SaveLinksDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}