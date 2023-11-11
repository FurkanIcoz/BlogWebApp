using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4276796c-10ff-4544-b2f7-819d5bcc46fc"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("880e2210-a262-45ad-992d-16ccc1708736"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("095bd5a1-61f0-4169-9bf6-542a5eac21bf"), new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tincidunt, enim eu facilisis condimentum, purus massa tristique felis, non congue nibh tortor at purus. Donec in viverra elit. Mauris eget velit non lacus porta mollis non id quam. Proin condimentum fermentum ornare. In lobortis tempus augue, a accumsan lectus molestie eu. Nulla facilisi. Nulla at pellentesque ante. Sed nec diam quis est tempor congue ac varius ante. Suspendisse ac massa vel quam ultricies suscipit. Quisque mi massa, vestibulum sed ultrices vel, varius consectetur lorem.", "Admin", new DateTime(2023, 11, 11, 18, 34, 18, 148, DateTimeKind.Local).AddTicks(712), null, null, new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"), false, null, null, "Title", 0 },
                    { new Guid("b272f29f-9903-4b52-9a48-f2ee3e624bb0"), new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"), "Nullam sed sapien turpis. Pellentesque quis neque nunc. Vivamus cursus et neque at posuere. Vivamus iaculis congue ipsum in commodo. Mauris quis ante condimentum, vulputate sem nec, facilisis velit. Fusce ligula nibh, finibus non elit porta, venenatis dictum massa. Aliquam vel quam at orci placerat tempor quis quis libero. Donec nec lacus purus.", "Admin", new DateTime(2023, 11, 11, 18, 34, 18, 148, DateTimeKind.Local).AddTicks(738), null, null, new Guid("437587af-85d1-4a98-8467-35a878cceed1"), false, null, null, "Title", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4f12b8d8-f709-41af-91a4-276b022ed318"), "1906351e-550e-4ab8-9b21-3d6fdaccd378", "Admin", "ADMIN" },
                    { new Guid("81806dd9-84e1-4936-b6a4-0e05e31d3802"), "07a01186-60ca-4039-83b2-3d5fd466424e", "User", "USER" },
                    { new Guid("ad50f467-45e7-44ae-bdf0-fb809bd19ce7"), "cae912fe-99b8-4867-a8ee-b7bf3dfe40c7", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("aa851df3-5b04-4a9f-9871-22e81fa71bdc"), 0, "ad58b633-c39e-4ff1-a53f-e25092edf84a", "superadmin@gmail.com", true, "Furkan", "Icoz", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKp6/ER9+r2DVfn40sjuWQ6TelsiSgEOuAtgvti3ieYCkg27d+XdztOlekZSBF5WQA==", "+905439999999", true, "904a5e92-b410-4ba9-93ed-f59cce75af71", false, "superadmin@gmail.com" },
                    { new Guid("dc1d6da5-c95f-4ef4-bb60-ce1f03a488b2"), 0, "526e659a-0d6d-4d8e-968e-aae00d723d6a", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPp836YleVHoJRqxxid/dDfVmwcD0FIrFvGWVGF+FwplzcnZPzfzgdZ2by3kExjWZQ==", "+905439999988", false, "81df15a3-b352-4f5c-9c5b-fca1d1de085f", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 18, 34, 18, 148, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 18, 34, 18, 148, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("437587af-85d1-4a98-8467-35a878cceed1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 18, 34, 18, 148, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 11, 18, 34, 18, 148, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ad50f467-45e7-44ae-bdf0-fb809bd19ce7"), new Guid("aa851df3-5b04-4a9f-9871-22e81fa71bdc") },
                    { new Guid("4f12b8d8-f709-41af-91a4-276b022ed318"), new Guid("dc1d6da5-c95f-4ef4-bb60-ce1f03a488b2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("095bd5a1-61f0-4169-9bf6-542a5eac21bf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b272f29f-9903-4b52-9a48-f2ee3e624bb0"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4276796c-10ff-4544-b2f7-819d5bcc46fc"), new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tincidunt, enim eu facilisis condimentum, purus massa tristique felis, non congue nibh tortor at purus. Donec in viverra elit. Mauris eget velit non lacus porta mollis non id quam. Proin condimentum fermentum ornare. In lobortis tempus augue, a accumsan lectus molestie eu. Nulla facilisi. Nulla at pellentesque ante. Sed nec diam quis est tempor congue ac varius ante. Suspendisse ac massa vel quam ultricies suscipit. Quisque mi massa, vestibulum sed ultrices vel, varius consectetur lorem.", "Admin", new DateTime(2023, 11, 10, 3, 37, 44, 798, DateTimeKind.Local).AddTicks(2061), null, null, new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"), false, null, null, "Title", 0 },
                    { new Guid("880e2210-a262-45ad-992d-16ccc1708736"), new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"), "Nullam sed sapien turpis. Pellentesque quis neque nunc. Vivamus cursus et neque at posuere. Vivamus iaculis congue ipsum in commodo. Mauris quis ante condimentum, vulputate sem nec, facilisis velit. Fusce ligula nibh, finibus non elit porta, venenatis dictum massa. Aliquam vel quam at orci placerat tempor quis quis libero. Donec nec lacus purus.", "Admin", new DateTime(2023, 11, 10, 3, 37, 44, 798, DateTimeKind.Local).AddTicks(2084), null, null, new Guid("437587af-85d1-4a98-8467-35a878cceed1"), false, null, null, "Title", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 3, 37, 44, 798, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 3, 37, 44, 798, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("437587af-85d1-4a98-8467-35a878cceed1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 3, 37, 44, 798, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 3, 37, 44, 798, DateTimeKind.Local).AddTicks(2325));
        }
    }
}
