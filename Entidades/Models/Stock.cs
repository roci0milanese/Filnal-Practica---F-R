namespace Entidades.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Stock
    {
        [Key]
        public int IdStock { get; set; } // (NOT NULL, PK)

        [Required]
        public int CantidadDisponible { get; set; } // (NOT NULL)

        [Required]
        public DateTime FechaActualizacion { get; set; } // (NOT NULL)

        public int? IdProveedor { get; set; } // (NULL)
        public virtual Proveedor? Proveedor { get; set; }

        [Required]
        public int IdProducto { get; set; } // (NOT NULL, FK)
        public virtual Producto Producto { get; set; }

        [Required]
        public int IdSucursal { get; set; } // (NOT NULL, FK)
        public virtual Sucursal Sucursal { get; set; }

        [Required]
        public int IdEstado { get; set; } // (NOT NULL, FK)
        public virtual Estado Estado { get; set; }

        public Stock() { }

        public Stock(int cantidadDisponible, DateTime fechaActualizacion, int idProducto, int idSucursal, int idEstado, int? idProveedor = null)
        {
            CantidadDisponible = cantidadDisponible;
            FechaActualizacion = fechaActualizacion;
            IdProducto = idProducto;
            IdSucursal = idSucursal;
            IdEstado = idEstado;
            IdProveedor = idProveedor;
        }
    }
}