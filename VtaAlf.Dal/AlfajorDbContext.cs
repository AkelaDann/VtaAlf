using VtaAlf.Fll;
using VtaAlf.Mod;
using Microsoft.EntityFrameworkCore;

namespace VtaAlf.Dal
{
    // All the code in this file is included in all platforms.
    public class AlfajorDbContext: DbContext
    {
        public DbSet<AlfajorMod> alfajores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string conexion = $"FileName={ConexionFll.ConexionString("Alfajor")}";
            optionsBuilder.UseSqlite(conexion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlfajorMod>(entity =>
            {
                entity.HasKey(col => col.ID);
                entity.Property(col => col.ID).IsRequired().ValueGeneratedOnAdd();
            });
        }

    } 
}
