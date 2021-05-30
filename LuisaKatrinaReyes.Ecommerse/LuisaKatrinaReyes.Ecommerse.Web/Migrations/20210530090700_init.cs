using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LuisaKatrinaReyes.Ecommerse.Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TagLine = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TagLine = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: true),
                    TagId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("e8dbc96e-0017-4040-870a-bba392a940a0"), new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(7558), "Tag 1", new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(8174) },
                    { new Guid("32febb22-f596-4b1e-b0a8-b11ad54be201"), new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9660), "Tag 2", new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9672) },
                    { new Guid("32febb22-f596-4b1e-b0a8-b11ad54be202"), new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9703), "Tag 3", new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9704) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "EmailAddress", "FirstName", "LastName", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"), new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(7660), "luisakatrinareyes@mailinator.com", "Luisa Katrina", "Reyes", 5, new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(7663) },
                    { new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"), new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8945), "izzelkatereyes@gmail.com", "Izzel Kate", "Reyes", 1000, new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8947) },
                    { new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"), new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8997), "leojinbsenreyes@gmail.com", "Leoj Ibsen", "Reyes", 1000, new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8998) }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "Id", "CreatedAt", "Key", "Type", "UpdatedAt", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("ddfeb295-decb-4967-ad83-2bda117b1413"), new DateTime(2021, 5, 30, 9, 7, 0, 46, DateTimeKind.Utc).AddTicks(6926), "Password", 1, new DateTime(2021, 5, 30, 9, 7, 0, 46, DateTimeKind.Utc).AddTicks(6950), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"), "$2b$10$i2jLvf4LR8VrnJLjwQHpEe5jFWh6Qrtf.Vd9qFHbo7Q05nmPxDml2" },
                    { new Guid("7dd8c275-b0cd-41a4-92fc-9f834881fae4"), new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3049), "LoginStatus", 0, new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3078), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"), "Active" },
                    { new Guid("0ff847fd-a0df-4aed-979b-5cd7a01321c6"), new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3229), "LoginRetries", 1, new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3230), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"), "0" },
                    { new Guid("32605134-1fa4-4222-9a47-ad75da700cc8"), new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3467), "Password", 1, new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3468), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"), "$2b$10$ZtlA1XJMXLLLfapOQcbwS.OoCocJsjLT96mLYcGwKzow/sxwTLnEa" },
                    { new Guid("dcb5e68c-9c5a-4573-b347-a4ff5c463aaa"), new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(2880), "LoginStatus", 0, new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(2903), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"), "Active" },
                    { new Guid("e27ede2c-8168-4dc6-a8eb-cab565f8209a"), new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3247), "LoginRetries", 1, new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3248), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"), "0" },
                    { new Guid("087e924c-5232-4e2d-8c77-bc7ed3527c3e"), new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3302), "Password", 1, new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3303), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"), "$2b$10$ad3IioJ0odaD.pULlBOVP.2uYHF3ktlGjFVhrZKpeeotoq6QAq6lK" },
                    { new Guid("052c724d-fb53-47f4-bcc1-8cf5c86e857c"), new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1280), "LoginStatus", 0, new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1301), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"), "Active" },
                    { new Guid("1c34968f-15f2-4a65-a7c2-9db98471461f"), new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1346), "LoginRetries", 1, new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1347), new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"), "0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
