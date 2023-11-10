using BlogWebApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("0EBC1653-2B5F-4C28-B8FB-8DE71C7D71CF"),
                CreatedBy = "AdminTest",
                Name = "C# ASP.NET CORE MVC"
            }
            ,new Category
            {
                Id = Guid.Parse("82212532-F3E7-4E53-8D1A-8F8752DC054D"),
                CreatedBy = "TestAdmin",
                Name = "Java Spring Boot"
            }
            );
        }
    }
}
