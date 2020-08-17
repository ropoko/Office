using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Office.Migrations
{
    public partial class usuFoto_prodFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94947cfe-acd1-457e-bce6-85a3399d3d6c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "655f23d5-93cc-40fd-b8e2-eff76e43bc12", "655f23d5-93cc-40fd-b8e2-eff76e43bc12" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "655f23d5-93cc-40fd-b8e2-eff76e43bc12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "655f23d5-93cc-40fd-b8e2-eff76e43bc12");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Produto",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "AspNetUsers",
                maxLength: 300,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9500fd86-a1a3-42d4-9a01-c1bf4a13b550", "7b267143-d6e1-44c3-8e7e-623b90895df4", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a4aefe3-fdcd-4ff8-8952-ccda83cf8d4a", "5837536a-f570-47d0-ba48-c43f40cd3cd1", "VISITANTE", "VISITANTE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cidade", "ConcurrencyStamp", "Cpf", "DataNascimento", "Email", "EmailConfirmed", "Foto", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9500fd86-a1a3-42d4-9a01-c1bf4a13b550", 0, "Barra Bonita", "35c0ea09-c8f2-4121-aafc-2ef8a4281dc3", "39493629830", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rodrigostramantinoli@gmail.com", true, null, false, null, "ADMIN", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "AQAAAAEAACcQAAAAEEF0zqeAUDmVNjL2uIZY1LQqCYJcTNQHvVO8LyLvqLyAXYnqvCNmm+t+ruO6NlH/WA==", null, false, "6128980", false, "rodrigostramantinoli@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9500fd86-a1a3-42d4-9a01-c1bf4a13b550", "9500fd86-a1a3-42d4-9a01-c1bf4a13b550" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a4aefe3-fdcd-4ff8-8952-ccda83cf8d4a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9500fd86-a1a3-42d4-9a01-c1bf4a13b550", "9500fd86-a1a3-42d4-9a01-c1bf4a13b550" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9500fd86-a1a3-42d4-9a01-c1bf4a13b550");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9500fd86-a1a3-42d4-9a01-c1bf4a13b550");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "655f23d5-93cc-40fd-b8e2-eff76e43bc12", "96f0c96b-de16-4ab9-8041-eaacb4bcf455", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94947cfe-acd1-457e-bce6-85a3399d3d6c", "314517a8-84b6-46f1-a04f-4675fcb8e790", "VISITANTE", "VISITANTE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cidade", "ConcurrencyStamp", "Cpf", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "655f23d5-93cc-40fd-b8e2-eff76e43bc12", 0, "Barra Bonita", "99a4da57-6810-4693-86db-d39c8ab66744", "39493629830", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rodrigostramantinoli@gmail.com", true, false, null, "Admin", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "AQAAAAEAACcQAAAAEElidym6rE9564JuuJgbaUhKn8BAGPyq3+Z9r1jv4VdrU5INSGi68wU0d6gCZSDwKA==", null, false, "6849756", false, "rodrigostramantinoli@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "655f23d5-93cc-40fd-b8e2-eff76e43bc12", "655f23d5-93cc-40fd-b8e2-eff76e43bc12" });
        }
    }
}
