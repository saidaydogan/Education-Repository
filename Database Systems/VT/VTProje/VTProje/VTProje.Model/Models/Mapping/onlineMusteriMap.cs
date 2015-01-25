using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class onlineMusteriMap : EntityTypeConfiguration<onlineMusteri>
    {
        public onlineMusteriMap()
        {
            // Primary Key
            this.HasKey(t => t.mid);

            // Properties
            this.Property(t => t.mid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("onlineMusteri");
            this.Property(t => t.mid).HasColumnName("mid");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.szt).HasColumnName("szt");

            // Relationships
            this.HasRequired(t => t.musteri)
                .WithOptional(t => t.onlineMusteri);

        }
    }
}
