using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        [Required]
        public double Monto { get; set; }

        [Required]
        public string MetodoPago { get; set; } = null!;

        [Required]
        public DateTime FechaPago { get; set; }

        [Required]
        public int IdEstado { get; set; }

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public int IdFactura { get; set; }

        // Relaciones
        [Required]
        public virtual Estado Estado { get; set; } = null!;

        [Required]
        public virtual Pedido Pedido { get; set; } = null!;

        public virtual Factura? Factura { get; set; }

        public Pago()
        {
        }

        public Pago(double monto, string metodoPago, DateTime fechaPago, int idEstado, int idPedido, int idFactura)
        {
            Monto = monto;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;
            IdEstado = idEstado;
            IdPedido = idPedido;
            IdFactura = idFactura;
        }
    }
}
