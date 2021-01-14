using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareStore.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("80725dc8-353e-4b5f-9277-31739833ce2a"), "f60086fb-95cb-4c84-a8ff-017d564de50f", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "DateAdded", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f6a6898d-9bd3-4b44-9cba-d3b13aeb3258"), null, 0, "d7148818-4177-44ff-af1e-611ba88bc0b5", new DateTime(2020, 12, 28, 15, 20, 32, 796, DateTimeKind.Utc).AddTicks(1680), null, "admin@admin.ru", true, false, null, "admin@admin.ru", "admin@admin.ru", "AQAAAAEAACcQAAAAEBNIssRVmy9xnr/OshkAv1doRYk6po79FgaDzZBh8WAAQjkTw+uCvydgkVHyctXlqw==", null, false, "", false, "admin@admin.ru" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AppUserId", "DateAdded", "Information", "OS", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2013, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Best Selling Disk Utility Software just got even more powerful. Fix It Utilities Professional comes packed with cutting edge. New Features designed to let you take control of your PC. Featuring the exclusive patent pending piece Analyzer Technology, 400% Faster Windows Registry Repair, a new Program Optimizer and Anti Virus Engine, as well as a dramatically redesigned and more intuitive User Interface design, Fix It Utilities is clearly the most flexible, powerful yet easy to use piece utility program available.", "Windows Vista, Windows 8, Windows 10, Windows 7", 19.90m, "Fix-It Utilities Professional" },
                    { new Guid("88acf17c-ce69-4475-a6b0-aefe8d6a6c88"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "This USB will allow you to re-install Mac on a new SSD Hard Drive, or recover your existing version if you are having system or software failure. Simple and easy to use, no guess work. Use it without technical skills. It will work with some qualifiers: your hardware must be functional and your hardware must be as close as possible to the original Apple approved for the system. The ideal install / upgrade would happen on an original machine.", "macOS X High Sierra 10.13", 28.00m, "Bootable USB Stick" },
                    { new Guid("48b8cb74-94db-4641-9895-1de2f2be8827"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "PCmover Express 11 is the ONLY software that automatically transfers files, settings, and user profiles from an old PC to a new one! It’s the easiest way to move to a new PC without leaving anything behind, even when there are different versions of Windows on the old and new PC. Nothing is changed on the old PC and nothing is overwritten on the new PC.", "Windows Vista, Windows 8, Windows 10, Windows XP, Windows 7", 19.90m, "Laplink PCmover Express" },
                    { new Guid("b2f97cfb-3fc6-454a-86a5-5a04c6cc779a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The most up to date Windows Emergency Boot Disk on the market! Below are a few of the things that this disk will do for you", "Windows 98, 2000, XP, Vista, 7, 10", 12.99m, "Ralix Windows Emergency Boot Disk" },
                    { new Guid("82dd7661-6b9b-4f24-8439-2ce7ce0c566a"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "AVG TuneUp is 15 years of computer optimization expertise that jogs your old PC back in shape, or keeps your new one running as fast as day 1.", "Windows 8, Windows 10, Mac OS X, Windows 7, Android", 24.99m, "AVG TuneUp" },
                    { new Guid("ac6bcfad-63a0-444a-a9d5-a58248bfbe0b"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Best Cloning Software. It Simply Works | Make an exact copy of HDD, SSD or NVMe SSD, with Dynamic Resizing | Available in CD-ROM and Download", "Windows Vista, Windows 8, Windows 10, Windows 7", 21.99m, "NTI Echo 5" },
                    { new Guid("0b53d140-b2f4-4474-a890-a37a74cbad2d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Still pining for that brand-new PC feeling? Get it back — and keep it — with the optimization and cleaning tools offered by Avast Cleanup Premium.", "Windows", 19.99m, "Avast Cleanup Premium" },
                    { new Guid("a23a5ff0-561d-4a7d-a867-eb1eeacf6306"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "This software will reset your Windows login password. it is compatible with Windows 10, 8.1, 8, 7", "Window 10, 8, 7, Vista, XP", 20.99m, "Windows Password Reset USB" },
                    { new Guid("4b96e514-78a7-48da-90d5-4d2c07012a8f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quite possibly the most comprehensive Windows optimization suite ever! Gain new disk space, disable unwanted services and boost your PC performance to the max! Protect your privacy and customize Windows to your needs.Enjoy steady performance and a lean, secure system!", "Windows 10, 8.1, 8, 7", 22.99m, "WinOptimizer 18" },
                    { new Guid("cff12241-dec0-4d7a-9af3-edcfcd0bc194"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2012, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CleanMy Mac & PC is one of the best and easiest to use cleaning solutions on the market for your OS. It consists of CleanMyMac for Macs & CleanMyPC for Windows based computers. CleanMyMac is the ultimate tool to keep your Mac clean and healthy.", "Windows Vista, Mac OS X, Windows XP, Windows 7", 15.99m, "CleanMy Mac & PC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("80725dc8-353e-4b5f-9277-31739833ce2a"), new Guid("f6a6898d-9bd3-4b44-9cba-d3b13aeb3258") });

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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
