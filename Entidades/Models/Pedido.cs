using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required]
        public DateTime FechaPedido { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public string DireccionEntrega { get; set; } = null!;

        [Required]
        public string MetodoPago { get; set; } = null!;

        public string? NumeroSeguimiento { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [Required]
        public int IdEstado { get; set; }

        // Relaciones
        [Required]
        public virtual Usuario Usuario { get; set; } = null!;

        [Required]
        public virtual Estado Estado { get; set; } = null!;

        public virtual ICollection<DetallePedido> DetallesPedido { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }

        public virtual Factura? Factura { get; set; }

        public Pedido()
        {
            DetallesPedido = new HashSet<DetallePedido>();
            Pagos = new HashSet<Pago>();
        }

        public Pedido(DateTime fechaPedido,
                      double total,
                      string direccionEntrega,
                      string metodoPago,
                      int idUsuario,
                      int idEstado)
            : this()
        {
            FechaPedido = fechaPedido;
            Total = total;
            DireccionEntrega = direccionEntrega;
            MetodoPago = metodoPago;
            IdUsuario = idUsuario;
            IdEstado = idEstado;
        }
    }
}
