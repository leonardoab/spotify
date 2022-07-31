using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.Domain.Album;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Spotify.Repository.Mapping
{
    internal class BandaMapping : IEntityTypeConfiguration<Banda>
    {
        public void Configure(EntityTypeBuilder<Banda> builder)
        {
            builder.ToTable("Bandas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Foto).IsRequired();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1024);

            builder.HasMany(x => x.Albuns).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
