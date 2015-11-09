using Nightpath.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Nightpath.DAL
{
    public class NightpathContext : DbContext
    {
        public NightpathContext() : base("NightpathContext")
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Points> Points { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Establishment> Establishments { get; set; }

        public DbSet<Estab_Owner> Estab_Owners { get; set; }

        public DbSet<Client> Clients { get; set; }
        
    }
}