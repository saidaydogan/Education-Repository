using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class siparislerMap : EntityTypeConfiguration<siparisler>
    {
        public siparislerMap()
        {
            // Primary Key
            this.HasKey(t => t.siparisNo);

            // Properties
            this.Property(t => t.siparisNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("siparisler");
            this.Property(t => t.siparisNo).HasColumnName("siparisNo");
            this.Property(t => t.tarih).HasColumnName("tarih");
            this.Property(t => t.musteriNo).HasColumnName("musteriNo");

            // Relationships
            this.HasRequired(t => t.musteri)
                .WithMany(t => t.siparislers)
                .HasForeignKey(d => d.musteriNo);

        }
    }
}
