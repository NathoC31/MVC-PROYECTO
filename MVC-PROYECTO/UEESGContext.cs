using Microsoft.EntityFrameworkCore;

public class UEESGContext(DbContextOptions<UEESGContext> options) : DbContext(options)
{
    public DbSet<MVC_PROYECTO.Models.Maestro> Maestro { get; set; } = default!;

    public DbSet<MVC_PROYECTO.Models.Aula> Aula { get; set; } = default!;

    public DbSet<MVC_PROYECTO.Models.Libro> Libro { get; set; } = default!;
}
