using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{

    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Tipo { get; set; } = null!;

        [Required]
        public int Numero { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public string FormaPago { get; set; } = null!;

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public virtual Pedido Pedido { get; set; } = null!;

        public virtual ICollection<DetallePedido> Detalles { get; set; }

        public Factura()
        {
            Detalles = new HashSet<DetallePedido>();
        }

        public Factura(DateTime fecha, string tipo, int numero, decimal total, string formaPago, int idPedido)
            : this()
        {
            Fecha = fecha;
            Tipo = tipo;
            Numero = numero;
            Total = total;
            FormaPago = formaPago;
            IdPedido = idPedido;
        }
    }
}