using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class depoMap : EntityTypeConfiguration<depo>
    {
        public depoMap()
        {
            // Primary Key
            this.HasKey(t => t.did);

            // Properties
            this.Property(t => t.did)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.konum)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("depo");
            this.Property(t => t.did).HasColumnName("did");
            this.Property(t => t.konum).HasColumnName("konum");
        }
    }
}
