using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace VTProje.UI.Model.Models.Mapping
{
    public class faturaMap : EntityTypeConfiguration<fatura>
    {
        public faturaMap()
        {
            // Primary Key
            this.HasKey(t => t.fatNo);

            // Properties
            this.Property(t => t.fatNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("fatura");
            this.Property(t => t.fatNo).HasColumnName("fatNo");
            this.Property(t => t.sipNo).HasColumnName("sipNo");
            this.Property(t => t.tarih).HasColumnName("tarih");
            this.Property(t => t.indirim).HasColumnName("indirim");

            // Relationships
            this.HasRequired(t => t.siparisler)
                .WithMany(t => t.faturas)
                .HasForeignKey(d => d.sipNo);

        }
    }
}
