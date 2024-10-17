using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierApp.Domain;

namespace NTierApp.DAL
{
    public class FilmMapping : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(x => x.FilmName).IsRequired().HasMaxLength(100);
            builder.ToTable("Films");
            builder.HasOne(x => x.FilmCategory)
                .WithMany(x => x.Films)
                .HasForeignKey(x => x.CategoryID);
            builder.HasOne(x => x.FilmDetail)
                .WithOne(x => x.Film)
                .HasForeignKey<FilmDetail>(x => x.FilmID);
        }
    }
}
