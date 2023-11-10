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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("94054BB5-2FD2-4B91-BF53-6077F0684025"),
                CreatedBy = "AdminImageTest",
                FileName = "FileNameTest",
                FileType = "Jpg",

            },
            new Image
            {
                Id = Guid.Parse("437587AF-85D1-4A98-8467-35A878CCEED1"),
                CreatedBy = "AdminTestImage",
                FileName = "TestFileName",
                FileType = "Png",
            });
        }
    }
}
