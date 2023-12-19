using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SongStore.Models;
using System.Diagnostics.Metrics;

namespace MusicStore.Models.DataAccess.Configuration;

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> entity)
    {
        // seed initial data
        entity.HasData(
            new Category { CategoryId = 1, CategoryName = "Pop" },
            new Category { CategoryId = 2, CategoryName = "Country" },
            new Category { CategoryId = 3, CategoryName = "Hiphop" },
            new Category { CategoryId = 4, CategoryName = "Electronic" },
            new Category { CategoryId = 5, CategoryName = "Rock" },
            new Category { CategoryId = 6, CategoryName = "Indie" },
            new Category { CategoryId = 7, CategoryName = "R&B" },
            new Category { CategoryId = 8, CategoryName = "Jazz" },
            new Category { CategoryId = 9, CategoryName = "Ambient" },
            new Category { CategoryId = 10, CategoryName = "Reggae" }
        );
    }
}
