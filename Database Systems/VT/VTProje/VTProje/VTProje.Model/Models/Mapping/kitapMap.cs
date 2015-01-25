using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class kitapMap : EntityTypeConfiguration<kitap>
    {
        public kitapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sipNo, t.parcaNo });

            // Properties
            this.Property(t => t.sipNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.parcaNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adi)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("kitap");
            this.Property(t => t.sipNo).HasColumnName("sipNo");
            this.Property(t => t.parcaNo).HasColumnName("parcaNo");
            this.Property(t => t.miktar).HasColumnName("miktar");
            this.Property(t => t.birimFiyat).HasColumnName("birimFiyat");
            this.Property(t => t.adi).HasColumnName("adi");
            this.Property(t => t.hangiDepo).HasColumnName("hangiDepo");

            // Relationships
            this.HasRequired(t => t.depo)
                .WithMany(t => t.kitaps)
                .HasForeignKey(d => d.hangiDepo);
            this.HasRequired(t => t.siparisler)
                .WithMany(t => t.kitaps)
                .HasForeignKey(d => d.sipNo);

        }
    }
}
