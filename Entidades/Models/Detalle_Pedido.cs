using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class DetallePedido
    {
        [Key]
        public int IdPedidoDetalle { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public double PrecioUnitario { get; set; }

        [Required]
        public double Subtotal { get; set; }

        // Relaciones
        [Required]
        public virtual Producto Producto { get; set; } = null!;

        [Required]
        public virtual Pedido Pedido { get; set; } = null!;

        public DetallePedido() { }

        public DetallePedido(int idProducto, int idPedido, int cantidad, double precioUnitario, double subtotal)
            : this()
        {
            IdProducto = idProducto;
            IdPedido = idPedido;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = subtotal;
        }
    }
}