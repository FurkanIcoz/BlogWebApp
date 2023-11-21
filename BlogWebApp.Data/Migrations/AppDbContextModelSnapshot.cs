﻿// <auto-generated />
using System;
using BlogWebApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogWebApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad50f467-45e7-44ae-bdf0-fb809bd19ce7"),
                            ConcurrencyStamp = "744ce65e-6f89-4caa-9cba-4c3ab218e28f",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("4f12b8d8-f709-41af-91a4-276b022ed318"),
                            ConcurrencyStamp = "113ee9fc-beb9-4046-95d1-3ce26ac23e4d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("81806dd9-84e1-4936-b6a4-0e05e31d3802"),
                            ConcurrencyStamp = "a9ca5770-a907-45bc-995b-1c69b0c6bbd3",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc1d6da5-c95f-4ef4-bb60-ce1f03a488b2"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "835c9b8e-184f-40e8-8e4e-7335c4d0716e",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("437587af-85d1-4a98-8467-35a878cceed1"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOMAoosFoShzmqzI1U+mz+Hr5UMbCYdqvYwvR38jKxxI0lbkRqQuovjYZWCOo8uWlw==",
                            PhoneNumber = "+905439999988",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2a35a447-7e4d-466d-a9f9-253c99e0fc15",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("aa851df3-5b04-4a9f-9871-22e81fa71bdc"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cbed4cff-df64-443e-9d2f-bc5efead699f",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Furkan",
                            ImageId = new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"),
                            LastName = "Icoz",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPQ/bCTILmX3oerx3IrHq/9RkQ5DcTA3EHijB+CfB84seCGP+FHBic0o3qR1h7vMJA==",
                            PhoneNumber = "+905439999999",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "8b8a26a9-cd6d-4404-b784-5925f2aeab87",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        });
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("aa851df3-5b04-4a9f-9871-22e81fa71bdc"),
                            RoleId = new Guid("ad50f467-45e7-44ae-bdf0-fb809bd19ce7")
                        },
                        new
                        {
                            UserId = new Guid("dc1d6da5-c95f-4ef4-bb60-ce1f03a488b2"),
                            RoleId = new Guid("4f12b8d8-f709-41af-91a4-276b022ed318")
                        });
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e8e45a1-0248-4a61-8299-f38d3333eebd"),
                            CategoryId = new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"),
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tincidunt, enim eu facilisis condimentum, purus massa tristique felis, non congue nibh tortor at purus. Donec in viverra elit. Mauris eget velit non lacus porta mollis non id quam. Proin condimentum fermentum ornare. In lobortis tempus augue, a accumsan lectus molestie eu. Nulla facilisi. Nulla at pellentesque ante. Sed nec diam quis est tempor congue ac varius ante. Suspendisse ac massa vel quam ultricies suscipit. Quisque mi massa, vestibulum sed ultrices vel, varius consectetur lorem.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 11, 17, 1, 3, 13, 451, DateTimeKind.Local).AddTicks(917),
                            ImageId = new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"),
                            IsDeleted = false,
                            Title = "Title",
                            UserId = new Guid("aa851df3-5b04-4a9f-9871-22e81fa71bdc"),
                            ViewCount = 0
                        },
                        new
                        {
                            Id = new Guid("1a1370d1-829f-4bed-a4fe-9e3d1bc6f968"),
                            CategoryId = new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"),
                            Content = "Nullam sed sapien turpis. Pellentesque quis neque nunc. Vivamus cursus et neque at posuere. Vivamus iaculis congue ipsum in commodo. Mauris quis ante condimentum, vulputate sem nec, facilisis velit. Fusce ligula nibh, finibus non elit porta, venenatis dictum massa. Aliquam vel quam at orci placerat tempor quis quis libero. Donec nec lacus purus.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 11, 17, 1, 3, 13, 451, DateTimeKind.Local).AddTicks(943),
                            ImageId = new Guid("437587af-85d1-4a98-8467-35a878cceed1"),
                            IsDeleted = false,
                            Title = "Title",
                            UserId = new Guid("dc1d6da5-c95f-4ef4-bb60-ce1f03a488b2"),
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"),
                            CreatedBy = "AdminTest",
                            CreatedDate = new DateTime(2023, 11, 17, 1, 3, 13, 451, DateTimeKind.Local).AddTicks(1103),
                            IsDeleted = false,
                            Name = "C# ASP.NET CORE MVC"
                        },
                        new
                        {
                            Id = new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"),
                            CreatedBy = "TestAdmin",
                            CreatedDate = new DateTime(2023, 11, 17, 1, 3, 13, 451, DateTimeKind.Local).AddTicks(1114),
                            IsDeleted = false,
                            Name = "Java Spring Boot"
                        });
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"),
                            CreatedBy = "AdminImageTest",
                            CreatedDate = new DateTime(2023, 11, 17, 1, 3, 13, 451, DateTimeKind.Local).AddTicks(1199),
                            FileName = "FileNameTest",
                            FileType = "Jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("437587af-85d1-4a98-8467-35a878cceed1"),
                            CreatedBy = "AdminTestImage",
                            CreatedDate = new DateTime(2023, 11, 17, 1, 3, 13, 451, DateTimeKind.Local).AddTicks(1201),
                            FileName = "TestFileName",
                            FileType = "Png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogWebApp.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.Article", b =>
                {
                    b.HasOne("BlogWebApp.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogWebApp.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("BlogWebApp.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogWebApp.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
