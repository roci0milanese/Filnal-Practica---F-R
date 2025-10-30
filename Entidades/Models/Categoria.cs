using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        // Colección de subcategorías 
        public virtual ICollection<string> Subcategorias { get; set; }

        public int? IdCategoriaPadre { get; set; } // Guarda el id de la categoría padre

        // Relación con productos
        public virtual ICollection<Producto> Productos { get; set; }

        public Categoria(string nombre)
        {
            Nombre = nombre;
            Productos = new HashSet<Producto>();
            Subcategorias = new HashSet<string>();
        }

        public Categoria()
        {
            Productos = new HashSet<Producto>();
            Subcategorias = new HashSet<string>(); //hashset No admite duplicados , ideal para colecciones.
        }
    }
}
