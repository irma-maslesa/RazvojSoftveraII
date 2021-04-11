using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database.Configuration
{
    public class DobavljaciEntityTypeConfiguration : IEntityTypeConfiguration<Dobavljaci>
    {
        public void Configure(EntityTypeBuilder<Dobavljaci> builder)
        {
            builder.HasKey(e => e.DobavljacId);

            builder.ToTable("Dobavljaci");

            builder.Property(e => e.DobavljacId).HasColumnName("DobavljacID");

            builder.Property(e => e.Adresa)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Fax).HasMaxLength(25);

            builder.Property(e => e.KontaktOsoba).HasMaxLength(100);

            builder.Property(e => e.Napomena).HasMaxLength(500);

            builder.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Telefon)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(e => e.Web).HasMaxLength(100);

            builder.Property(e => e.ZiroRacuni).HasMaxLength(255);
        }
    }
}
