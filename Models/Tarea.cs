using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace curso_EntityFramework.Models
{
    public class Tarea
    {
        [Key]
        public Guid TareaId {get; set;}

        [ForeignKey("CategoriaId")]
        public Guid CategoriaId {get; set;}

        [Required]
        [MaxLength(200)]
        public string Titulo {get; set;}
        public string Descripcion {get; set;}
        public Prioridad PrioridadTarea {get; set;}
        public DateOnly FechaCreacion {get; set;}

        public virtual Categoria ? Categoria {get; set;}

        [NotMapped] //No se añade a la base de datos este atributo
        public string Resumen{get; set;}
    }
}

public enum Prioridad
{
    Baja,
    Media,
    Alta
}