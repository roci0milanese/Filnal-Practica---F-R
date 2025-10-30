using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{

    public class ProductoProveedor
    {
        [Key]
        [Required]
        public int IdProducto { get; set; } // (NOT NULL, PK, FK)

        [Key]
        [Required]
        public int IdProveedor { get; set; } // (NOT NULL, PK, FK)

        [Required]
        public double Precio { get; set; } // (NOT NULL)

        [Required]
        public DateTime FechaAlta { get; set; } // (NOT NULL)

        // Relaciones
        public virtual Producto Producto { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        public ProductoProveedor() { }

        public ProductoProveedor(int idProducto, int idProveedor, double precio, DateTime fechaAlta)
        {
            IdProducto = idProducto;
            IdProveedor = idProveedor;
            Precio = precio;
            FechaAlta = fechaAlta;
        }
    }
}



