using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
  public class Context : DbContext
  {
    //informando que vou ter uma tabela que vai se chamar categoria
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
        Database=cursomvc;Integrated Security=True");
    }

  }
}

