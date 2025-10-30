using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class DetallePedido
    {

        [Key]
        public int IdPedidoDetalle { get; set; }

        // Id del producto al que pertenece (clave foránea)
        public int IdProducto { get; set; }

        // Id del pedido al que pertenece (clave foránea)
        public int IdPedido { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; set; }

        // Relaciones
        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

        [ForeignKey("IdPedido")]
        public virtual Pedido Pedido { get; set; }

        public DetallePedido() { }


        public DetallePedido(int idProducto, int idPedido, int cantidad, double precioUnitario, double subtotal)
        {
            IdProducto = idProducto;
            IdPedido = idPedido;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }
    }
}


