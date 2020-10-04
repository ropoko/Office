﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Office;

namespace Office.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "e9606bf9-407b-4d8c-ba31-4871e9760831",
                            ConcurrencyStamp = "28b529d5-055f-4e94-96d4-32a50328c575",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d5834c7d-5feb-47df-882e-e1a4f6f33099",
                            ConcurrencyStamp = "7169a2cb-20bf-440e-83d9-c359a12a2fa3",
                            Name = "VISITANTE",
                            NormalizedName = "VISITANTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(85);

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(85);

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "e9606bf9-407b-4d8c-ba31-4871e9760831",
                            RoleId = "e9606bf9-407b-4d8c-ba31-4871e9760831"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Office.Models.Categoria", b =>
                {
                    b.Property<int>("IDCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IDCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Office.Models.ItemPedido", b =>
                {
                    b.Property<int>("IDItemPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IDPedido")
                        .HasColumnType("int");

                    b.Property<int>("IDProduto")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoIDPedido")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoIDProduto")
                        .HasColumnType("int");

                    b.HasKey("IDItemPedido");

                    b.HasIndex("PedidoIDPedido");

                    b.HasIndex("ProdutoIDProduto");

                    b.ToTable("Item_Pedido");
                });

            modelBuilder.Entity("Office.Models.Pedido", b =>
                {
                    b.Property<int>("IDPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataBusca")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IDCliente")
                        .HasColumnName("IDCliente")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4");

                    b.HasKey("IDPedido");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Office.Models.Produto", b =>
                {
                    b.Property<int>("IDProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("CategoriasIDCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IDProduto");

                    b.HasIndex("CategoriasIDCategoria");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Office.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnName("Cidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("Cpf")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(85) CHARACTER SET utf8mb4")
                        .HasMaxLength(85);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e9606bf9-407b-4d8c-ba31-4871e9760831",
                            AccessFailedCount = 0,
                            Cidade = "Barra Bonita",
                            ConcurrencyStamp = "cdfb764d-2bcc-4470-97fc-329f72c9cac2",
                            Cpf = "39493629830",
                            DataCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rodrigostramantinoli@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Nome = "ADMIN",
                            NormalizedEmail = "RODRIGOSTRAMANTINOLI@GMAIL.COM",
                            NormalizedUserName = "RODRIGOSTRAMANTINOLI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI8w+NhaDEQtcl5SxamcaNU5bgKX0Jtzsfly4KGXC5s62NoE+iU0zZSo6NHOLewJ8A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "45420240",
                            TwoFactorEnabled = false,
                            UserName = "rodrigostramantinoli@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Office.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Office.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Office.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Office.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Office.Models.ItemPedido", b =>
                {
                    b.HasOne("Office.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoIDPedido");

                    b.HasOne("Office.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoIDProduto");
                });

            modelBuilder.Entity("Office.Models.Pedido", b =>
                {
                    b.HasOne("Office.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Office.Models.Produto", b =>
                {
                    b.HasOne("Office.Models.Categoria", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriasIDCategoria");
                });
#pragma warning restore 612, 618
        }
    }
}
