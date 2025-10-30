namespace Entidades.Models
{
    public class Stock
    {
        public int IdStock { get; set; }
        public int CantidadDisponible { get; set; }
        public DateTime FechaActualizacion { get; set; }

        // Relaciones
        public int? IdProveedor { get; set; }       // Puede ser NULL
        public virtual Proveedor? Proveedor { get; set; }

        public int IdProducto { get; set; }
        public virtual Producto Producto { get; set; }

        public int IdSucursal { get; set; }
        public virtual Sucursal Sucursal { get; set; }

        public int IdEstado { get; set; }
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

