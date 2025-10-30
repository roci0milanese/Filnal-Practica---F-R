using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Categoria
    {
        [Key] public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public List<string>? Subcategorias { get; set; }  // Lista de subcategorías (por ejemplo: "Remeras", "Pantalones")
        public int? IdCategoriaPadre { get; set; } // Guarda el id de la categoría padre 
        // ? significa que puede ser null
        public List<Producto> Productos { get; set; } // Relación con los productos (una categoría puede tener varios productos)

        public Categoria(string nombre)
        {
            Nombre = nombre;
            Productos = new List<Producto>();
            Subcategorias = new List<string>();
        }

        public Categoria()
        {
            Productos = new List<Producto>();
            Subcategorias = new List<string>();
        }
    }
}

