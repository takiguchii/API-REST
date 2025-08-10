using ConectDatabase;
using Microsoft.EntityFrameworkCore;

namespace ConectDatabase.Data
{
    public partial class AppDbContext : DbContext
    {
        // Construtor que recebe a configuração do Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Esta propriedade representa a tabela "Animes" no banco de dados
        public DbSet<Anime> Animes { get; set; }

        // Esta é a nova propriedade que representa a tabela "Generos"
        public DbSet<Genero> Generos { get; set; }
    }
}