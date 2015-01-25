using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class magazaMusteriMap : EntityTypeConfiguration<magazaMusteri>
    {
        public magazaMusteriMap()
        {
            // Primary Key
            this.HasKey(t => t.mid);

            // Properties
            this.Property(t => t.mid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("magazaMusteri");
            this.Property(t => t.mid).HasColumnName("mid");
            this.Property(t => t.telNo).HasColumnName("telNo");

            // Relationships
            this.HasRequired(t => t.musteri)
                .WithOptional(t => t.magazaMusteri);

        }
    }
}
