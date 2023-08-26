using Microsoft.EntityFrameworkCore;
using TP1ORM.Domain.Entities;
namespace TP1ORM.AccessData
{
    public class CineContext : DbContext
    {
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Funciones> Funciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Cine;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Peliculas>(entity =>
            {
                _ = entity.HasKey(p => p.PeliculaId);

                _ = entity.Property(p => p.Titulo).HasMaxLength(50).IsRequired();
                _ = entity.Property(p => p.Poster).HasMaxLength(255).IsRequired();
                _ = entity.Property(p => p.Sinopsis).HasMaxLength(255).IsRequired();
                _ = entity.Property(p => p.Trailer).HasMaxLength(255).IsRequired();
                _ = entity.ToTable("Peliculas");
            });

            _ = modelBuilder.Entity<Sala>(entity =>
            {
                _ = entity.HasKey(s => s.SalaId);

                _ = entity.Property(s => s.Capacidad).IsRequired();
                _ = entity.ToTable("Salas");
            });

            _ = modelBuilder.Entity<Tickets>(entity =>
            {
                _ = entity.HasKey(compuesta => new { compuesta.TicketId, compuesta.FuncionId });
                _ = entity.Property(t => t.Usuario).HasMaxLength(50).IsRequired();


                _ = entity.HasOne(f => f.Funciones).WithMany(t => t.TicketsNavigator);
                _ = entity.ToTable("Tickets");
            });

            _ = modelBuilder.Entity<Funciones>(entity =>
            {
                _ = entity.HasKey(f => f.FuncionId);

                _ = entity.Property(f => f.PeliculaId).IsRequired();
                _ = entity.Property(f => f.SalaId).IsRequired();
                _ = entity.Property(f => f.Fecha).IsRequired();
                _ = entity.Property(f => f.Horario).IsRequired();

                _ = entity.HasOne(p => p.Peliculas).WithMany(f => f.FuncionesNavigator).HasForeignKey(p => p.PeliculaId);
                _ = entity.HasOne(s => s.Sala).WithMany(f => f.FuncionesNavigator).HasForeignKey(s => s.SalaId);
                _ = entity.ToTable("Funciones");
            });
            _ = modelBuilder.Entity<Peliculas>().HasData(
                new Peliculas { PeliculaId = 1, Titulo = "Rapido y Furioso", Poster = "https://bit.ly/3u3wJIn", Sinopsis = "https://bit.ly/2VXsVMj", Trailer = "https://bit.ly/2XrPglr" },
                new Peliculas { PeliculaId = 2, Titulo = "En busca de la felicidad", Poster = "https://bit.ly/3At1JnE", Sinopsis = "https://bit.ly/3zrETvp", Trailer = "https://bit.ly/3zpfp1x" },
                new Peliculas { PeliculaId = 3, Titulo = "Mision Imposible", Poster = "https://bit.ly/2XygzdK", Sinopsis = "https://bit.ly/3lNVPrc", Trailer = "https://bit.ly/3EAIlYo" },
                new Peliculas { PeliculaId = 4, Titulo = "Celular", Poster = "https://bit.ly/3nQWyub", Sinopsis = "https://bit.ly/3nV2wtZ", Trailer = "https://bit.ly/3EATp7z" },
                new Peliculas { PeliculaId = 5, Titulo = "Bastardos sin gloria ", Poster = "https://bit.ly/3nSbhFk", Sinopsis = "https://bit.ly/3lLgE6e", Trailer = "https://bit.ly/3EDUyLA" },
                new Peliculas { PeliculaId = 6, Titulo = "Busqueda Implacable", Poster = "https://bit.ly/2XAxjSl", Sinopsis = "https://bit.ly/2ZktTnf", Trailer = "https://bit.ly/2XygPcI" },
                new Peliculas { PeliculaId = 7, Titulo = "Harry Potter Prisionero de Azkaban", Poster = "https://bit.ly/3u03Z39", Sinopsis = "https://bit.ly/3CuWqVj", Trailer = "https://bit.ly/2XIIdVZ" },
                new Peliculas { PeliculaId = 8, Titulo = "Invicto 3", Poster = "https://bit.ly/3nRE90c", Sinopsis = "https://bit.ly/39tpCiN", Trailer = "https://bit.ly/3lEU2od" },
                new Peliculas { PeliculaId = 9, Titulo = "Nueve Reinas", Poster = "https://bit.ly/3u3xv8f", Sinopsis = "https://bit.ly/3Cy6qwP", Trailer = "https://bit.ly/3krQypO" },
                new Peliculas { PeliculaId = 10, Titulo = "Atrapame si puedes", Poster = "https://bit.ly/2XKIhof", Sinopsis = "https://bit.ly/39npiCg", Trailer = "https://bit.ly/2VWI7ZX" }
                );
            _ = modelBuilder.Entity<Sala>().HasData(
                new Sala { SalaId = 1, Capacidad = 5 },
                new Sala { SalaId = 2, Capacidad = 15 },
                new Sala { SalaId = 3, Capacidad = 35 }
                );
        }
    }
}