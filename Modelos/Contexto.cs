using Microsoft.EntityFrameworkCore;

public class SerieContext: DbContext{

    public DbSet<Serie_Libro_Pelicula> Serie_Libro_Pelicula {get; set;} = null;
    public DbSet<Personaje> Personaje {get; set;} = null;

    public SerieContext(DbContextOptions<SerieContext> options)
    : base(options) {}
}