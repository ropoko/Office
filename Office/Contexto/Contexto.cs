using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Office.Models;
using System;

namespace Office
{
    public class Contexto : IdentityDbContext<Usuario>
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Usuario>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            mb.Entity<Usuario>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            mb.Entity<Usuario>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            mb.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            mb.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            mb.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            mb.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            mb.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));

            mb.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            mb.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            mb.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            mb.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            mb.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            mb.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            mb.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            mb.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            mb.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = ADMIN_ID;

            mb.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ID,
                Name = "ADMIN",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "VISITANTE",
                NormalizedName = "VISITANTE"
            });

            var hash = new PasswordHasher<Usuario>();
            mb.Entity<Usuario>().HasData(new Usuario
            {
                Id = ADMIN_ID,
                Nome = "ADMIN",
                UserName = "rodrigostramantinoli@gmail.com",
                NormalizedUserName = "RODRIGOSTRAMANTINOLI@GMAIL.COM",
                Email = "rodrigostramantinoli@gmail.com",
                NormalizedEmail = "RODRIGOSTRAMANTINOLI@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hash.HashPassword(null, "teste"),
                SecurityStamp = hash.GetHashCode().ToString(),
				Cidade = "Barra Bonita",
				Cpf = "394.936.298-30"
            });

            mb.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
