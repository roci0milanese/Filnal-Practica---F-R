namespace Entidades.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public double Total { get; set; }
        public string DireccionEntrega { get; set; }
        public string MetodoPago { get; set; }
        public string? NumeroSeguimiento { get; set; }

        public int IdUsuario { get; set; }
        public int IdEstado { get; set; }

        // Relaciones
        public virtual Usuario Usuario { get; set; }
        public virtual Estado Estado { get; set; }

        public virtual ICollection<DetallePedido> DetallesPedido { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual Factura Factura { get; set; }


        public Pedido()
        {
            DetallesPedido = new HashSet<DetallePedido>();
            Pagos = new HashSet<Pago>();
        }

        public Pedido(DateTime fechaPedido, double total, string direccionEntrega, string metodoPago, int idUsuario, int idEstado)
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


