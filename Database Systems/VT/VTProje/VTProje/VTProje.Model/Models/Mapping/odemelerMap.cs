using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class odemelerMap : EntityTypeConfiguration<odemeler>
    {
        public odemelerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fatNo, t.takNo });

            // Properties
            this.Property(t => t.fatNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.takNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.odemeTipi)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.kartTipi)
                .HasMaxLength(100);

            this.Property(t => t.bankaKodu)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("odemeler");
            this.Property(t => t.fatNo).HasColumnName("fatNo");
            this.Property(t => t.takNo).HasColumnName("takNo");
            this.Property(t => t.odemeMiktari).HasColumnName("odemeMiktari");
            this.Property(t => t.odemeTipi).HasColumnName("odemeTipi");
            this.Property(t => t.kartTipi).HasColumnName("kartTipi");
            this.Property(t => t.son_kul_tar).HasColumnName("son_kul_tar");
            this.Property(t => t.kartNo).HasColumnName("kartNo");
            this.Property(t => t.bankaKodu).HasColumnName("bankaKodu");
            this.Property(t => t.cekNo).HasColumnName("cekNo");

            // Relationships
            this.HasRequired(t => t.fatura)
                .WithMany(t => t.odemelers)
                .HasForeignKey(d => d.fatNo);

        }
    }
}
