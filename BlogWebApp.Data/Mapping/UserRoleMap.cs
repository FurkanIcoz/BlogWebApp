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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("AA851DF3-5B04-4A9F-9871-22E81FA71BDC"),
                RoleId= Guid.Parse("AD50F467-45E7-44AE-BDF0-FB809BD19CE7"),
                            
            },
            new AppUserRole
            {
                UserId = Guid.Parse("DC1D6DA5-C95F-4EF4-BB60-CE1F03A488B2"),
                RoleId = Guid.Parse("4F12B8D8-F709-41AF-91A4-276B022ED318"),
            });
        }
    }
}
