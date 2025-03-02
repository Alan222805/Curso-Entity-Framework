using curso_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace curso_EntityFramework
{
    public class TareasContext : DbContext
    {
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Tarea> Tareas {get; set;}

        public TareasContext(DbContextOptions<TareasContext> options) : base(options){ }
    }
}