using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Office.Migrations
{
    public partial class DescricaoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47697c2d-6bb4-404c-9868-f8385ce16ab3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d4aae1a5-d6e8-4261-9243-b96bc2726ab1", "d4aae1a5-d6e8-4261-9243-b96bc2726ab1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4aae1a5-d6e8-4261-9243-b96bc2726ab1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4aae1a5-d6e8-4261-9243-b96bc2726ab1");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produto",
                maxLength: 100,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9606bf9-407b-4d8c-ba31-4871e9760831", "28b529d5-055f-4e94-96d4-32a50328c575", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5834c7d-5feb-47df-882e-e1a4f6f33099", "7169a2cb-20bf-440e-83d9-c359a12a2fa3", "VISITANTE", "VISITANTE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cidade", "ConcurrencyStamp", "Cpf", "DataCadastro", "DataNascimento", "Email", "EmailConfirmed", "Foto", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9606bf9-407b-4d8c-ba31-4871e9760831", 0, "Barra Bonita", "cdfb764d-2bcc-4470-97fc-329f72c9cac2", "39493629830", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rodrigostramantinoli@gmail.com", true, null, false, null, "ADMIN", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "AQAAAAEAACcQAAAAEI8w+NhaDEQtcl5SxamcaNU5bgKX0Jtzsfly4KGXC5s62NoE+iU0zZSo6NHOLewJ8A==", null, false, "45420240", false, "rodrigostramantinoli@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e9606bf9-407b-4d8c-ba31-4871e9760831", "e9606bf9-407b-4d8c-ba31-4871e9760831" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5834c7d-5feb-47df-882e-e1a4f6f33099");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e9606bf9-407b-4d8c-ba31-4871e9760831", "e9606bf9-407b-4d8c-ba31-4871e9760831" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9606bf9-407b-4d8c-ba31-4871e9760831");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9606bf9-407b-4d8c-ba31-4871e9760831");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produto");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4aae1a5-d6e8-4261-9243-b96bc2726ab1", "47bf6784-636d-454f-bf6f-6e2491769826", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47697c2d-6bb4-404c-9868-f8385ce16ab3", "7c596db7-596e-44bf-9985-296364718ed6", "VISITANTE", "VISITANTE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cidade", "ConcurrencyStamp", "Cpf", "DataCadastro", "DataNascimento", "Email", "EmailConfirmed", "Foto", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d4aae1a5-d6e8-4261-9243-b96bc2726ab1", 0, "Barra Bonita", "74a76e9b-ecd3-4af3-82ad-0f283087e525", "39493629830", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rodrigostramantinoli@gmail.com", true, null, false, null, "ADMIN", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "RODRIGOSTRAMANTINOLI@GMAIL.COM", "AQAAAAEAACcQAAAAEKP0cp//+XMmvylpW9uQO2GcfaCO+cQIOmFK9SmdSgdlE7gkSS9rPkrVNMw0EYlyEQ==", null, false, "45420240", false, "rodrigostramantinoli@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d4aae1a5-d6e8-4261-9243-b96bc2726ab1", "d4aae1a5-d6e8-4261-9243-b96bc2726ab1" });
        }
    }
}
