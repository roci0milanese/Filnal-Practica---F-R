using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; } // (NOT NULL, PK)

        [Required]
        public string Nombre { get; set; } // (NOT NULL)

        [Required]
        public string Apellido { get; set; } // (NOT NULL)

        public string? Telefono { get; set; } // (NULL)

        [Required]
        [EmailAddress] // validar el formato del correo.
        public string Correo { get; set; } // (NOT NULL, UNIQUE)

        public string? ProductosSuministrados { get; set; } // (NULL)

        // Relaciones
        public virtual ICollection<ProductoProveedor> ProductosProveedor { get; set; }

        public Proveedor()
        {
            ProductosProveedor = new HashSet<ProductoProveedor>();
        }

        public Proveedor(string nombre, string apellido, string correo, string? telefono = null, string? productosSuministrados = null)
            : this()
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            ProductosSuministrados = productosSuministrados;
        }
    }
}