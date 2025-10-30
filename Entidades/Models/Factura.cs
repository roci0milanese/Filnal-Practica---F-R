namespace Entidades.Models
{
    public class Factura
    {

        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public decimal Total { get; set; }
        public string FormaPago { get; set; }

        // Clave foránea
        public int IdPedido { get; set; }
        public virtual Pedido Pedido { get; set; }

        // Relación con detalles
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

