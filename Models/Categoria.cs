using System.ComponentModel.DataAnnotations;

namespace curso_EntityFramework.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId {get; set;}
        
        [MaxLength(150)]
        public string ? Nombre {get; set;}
        public string ? Descripcion {get; set;}
        public virtual ICollection<Tarea> ? Tareas {get; set;}
    }
}