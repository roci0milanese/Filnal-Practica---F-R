namespace Entidades.Models
{
    public class ProductoProveedor
    {
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public double Precio { get; set; }
        public DateTime FechaAlta { get; set; }

        // Relaciones
        public Producto Producto { get; set; }
        public Proveedor Proveedor { get; set; }

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



