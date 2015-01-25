using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class musteriMap : EntityTypeConfiguration<musteri>
    {
        public musteriMap()
        {
            // Primary Key
            this.HasKey(t => t.mid);

            // Properties
            this.Property(t => t.mid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.isim)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("musteri");
            this.Property(t => t.mid).HasColumnName("mid");
            this.Property(t => t.isim).HasColumnName("isim");
        }
    }
}
