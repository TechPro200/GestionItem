
using Microsoft.EntityFrameworkCore; 
using GestionItem.Models; 

namespace GestionItem.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=GestionItemDB.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.NombreUsuario)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Correo)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .Property(u => u.ContrasenaHash)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Cargo)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}