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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150);
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Title",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tincidunt, enim eu facilisis condimentum, purus massa tristique felis, non congue nibh tortor at purus. Donec in viverra elit. Mauris eget velit non lacus porta mollis non id quam. Proin condimentum fermentum ornare. In lobortis tempus augue, a accumsan lectus molestie eu. Nulla facilisi. Nulla at pellentesque ante. Sed nec diam quis est tempor congue ac varius ante. Suspendisse ac massa vel quam ultricies suscipit. Quisque mi massa, vestibulum sed ultrices vel, varius consectetur lorem.",
                CreatedBy= "Admin",
                CategoryId = Guid.Parse("0EBC1653-2B5F-4C28-B8FB-8DE71C7D71CF"),
                ImageId = Guid.Parse("94054BB5-2FD2-4B91-BF53-6077F0684025")

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Title",
                Content = "Nullam sed sapien turpis. Pellentesque quis neque nunc. Vivamus cursus et neque at posuere. Vivamus iaculis congue ipsum in commodo. Mauris quis ante condimentum, vulputate sem nec, facilisis velit. Fusce ligula nibh, finibus non elit porta, venenatis dictum massa. Aliquam vel quam at orci placerat tempor quis quis libero. Donec nec lacus purus.",
                CreatedBy = "Admin",
                CategoryId = Guid.Parse("82212532-F3E7-4E53-8D1A-8F8752DC054D"),
                ImageId = Guid.Parse("437587AF-85D1-4A98-8467-35A878CCEED1")
            });
        }
    }
}
