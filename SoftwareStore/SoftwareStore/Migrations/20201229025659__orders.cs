using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareStore.Migrations
{
    public partial class _orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("80725dc8-353e-4b5f-9277-31739833ce2a"),
                column: "ConcurrencyStamp",
                value: "3be945d1-e3f7-4312-86fb-010119a8525d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6a6898d-9bd3-4b44-9cba-d3b13aeb3258"),
                columns: new[] { "ConcurrencyStamp", "DateAdded", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "f04a402c-9b88-4515-8e7c-f9137b36d3af", new DateTime(2020, 12, 29, 2, 56, 58, 951, DateTimeKind.Utc).AddTicks(1422), "admin@admin.com", "admin@admin.com", "admin@admin.com", "AQAAAAEAACcQAAAAEJ6o9lI8p+3HDT9PcNAdFS9bd/2opPK+O8fbCpNbbHpybi1nAC8khGnEXFI6rQOLKQ==", "admin@admin.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("80725dc8-353e-4b5f-9277-31739833ce2a"),
                column: "ConcurrencyStamp",
                value: "f60086fb-95cb-4c84-a8ff-017d564de50f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6a6898d-9bd3-4b44-9cba-d3b13aeb3258"),
                columns: new[] { "ConcurrencyStamp", "DateAdded", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "d7148818-4177-44ff-af1e-611ba88bc0b5", new DateTime(2020, 12, 28, 15, 20, 32, 796, DateTimeKind.Utc).AddTicks(1680), "admin@admin.ru", "admin@admin.ru", "admin@admin.ru", "AQAAAAEAACcQAAAAEBNIssRVmy9xnr/OshkAv1doRYk6po79FgaDzZBh8WAAQjkTw+uCvydgkVHyctXlqw==", "admin@admin.ru" });
        }
    }
}
