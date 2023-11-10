using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Repositories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5fbfade0-a0dd-47e9-bf7c-3c3f8c483af6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("82456e2c-06df-489a-88db-6b6aec5722de"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4276796c-10ff-4544-b2f7-819d5bcc46fc"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("880e2210-a262-45ad-992d-16ccc1708736"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5fbfade0-a0dd-47e9-bf7c-3c3f8c483af6"), new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"), "Nullam sed sapien turpis. Pellentesque quis neque nunc. Vivamus cursus et neque at posuere. Vivamus iaculis congue ipsum in commodo. Mauris quis ante condimentum, vulputate sem nec, facilisis velit. Fusce ligula nibh, finibus non elit porta, venenatis dictum massa. Aliquam vel quam at orci placerat tempor quis quis libero. Donec nec lacus purus.", "Admin", new DateTime(2023, 11, 10, 2, 55, 5, 199, DateTimeKind.Local).AddTicks(254), null, null, new Guid("437587af-85d1-4a98-8467-35a878cceed1"), false, null, null, "Title", 0 },
                    { new Guid("82456e2c-06df-489a-88db-6b6aec5722de"), new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tincidunt, enim eu facilisis condimentum, purus massa tristique felis, non congue nibh tortor at purus. Donec in viverra elit. Mauris eget velit non lacus porta mollis non id quam. Proin condimentum fermentum ornare. In lobortis tempus augue, a accumsan lectus molestie eu. Nulla facilisi. Nulla at pellentesque ante. Sed nec diam quis est tempor congue ac varius ante. Suspendisse ac massa vel quam ultricies suscipit. Quisque mi massa, vestibulum sed ultrices vel, varius consectetur lorem.", "Admin", new DateTime(2023, 11, 10, 2, 55, 5, 199, DateTimeKind.Local).AddTicks(223), null, null, new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"), false, null, null, "Title", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ebc1653-2b5f-4c28-b8fb-8de71c7d71cf"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 2, 55, 5, 199, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82212532-f3e7-4e53-8d1a-8f8752dc054d"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 2, 55, 5, 199, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("437587af-85d1-4a98-8467-35a878cceed1"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 2, 55, 5, 199, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("94054bb5-2fd2-4b91-bf53-6077f0684025"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 10, 2, 55, 5, 199, DateTimeKind.Local).AddTicks(531));
        }
    }
}
