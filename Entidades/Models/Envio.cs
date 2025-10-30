namespace Entidades.Models
{
    public class Envio
    {
        public int IdEnvio { get; set; }
        public string TipoEnvio { get; set; }
        public double Costo { get; set; }
        public DateTime FechaEstimada { get; set; }
        public string NumeroSeguimiento { get; set; }

        // Claves foráneas
        public int IdEstado { get; set; }
        public Estado Estado { get; set; }

        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }

        // Constructor
        public Envio()
        {
            Estado = new Estado();
            Pedido = new Pedido();
        }

        public double CalcularCosto()
        {
            return Costo;
        }
    }
}
