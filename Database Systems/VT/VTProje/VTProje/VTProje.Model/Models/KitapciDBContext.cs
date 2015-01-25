using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using VTProje.UI.Model.Models.Mapping;

namespace VTProje.UI.Model.Models
{
    public partial class KitapciDBContext : DbContext
    {
        static KitapciDBContext()
        {
            Database.SetInitializer<KitapciDBContext>(null);
        }

        public KitapciDBContext()
            : base("Name=KitapciDBContext")
        {
        }

        public DbSet<depo> depoes { get; set; }
        public DbSet<fatura> faturas { get; set; }
        public DbSet<kitap> kitaps { get; set; }
        public DbSet<magazaMusteri> magazaMusteris { get; set; }
        public DbSet<musteri> musteris { get; set; }
        public DbSet<odemeler> odemelers { get; set; }
        public DbSet<onlineMusteri> onlineMusteris { get; set; }
        public DbSet<siparisler> siparislers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new depoMap());
            modelBuilder.Configurations.Add(new faturaMap());
            modelBuilder.Configurations.Add(new kitapMap());
            modelBuilder.Configurations.Add(new magazaMusteriMap());
            modelBuilder.Configurations.Add(new musteriMap());
            modelBuilder.Configurations.Add(new odemelerMap());
            modelBuilder.Configurations.Add(new onlineMusteriMap());
            modelBuilder.Configurations.Add(new siparislerMap());
        }
    }
}
