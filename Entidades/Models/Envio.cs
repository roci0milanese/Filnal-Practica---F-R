using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Envio
    {
        [Key]
        public int IdEnvio { get; set; }

        [Required]
        public string TipoEnvio { get; set; } = null!;

        [Required]
        public double Costo { get; set; }

        [Required]
        public DateTime FechaEstimada { get; set; }

        [Required]
        public string NumeroSeguimiento { get; set; } = null!;

        // Claves foráneas
        [Required]
        public int IdEstado { get; set; }

        [Required]
        public virtual Estado Estado { get; set; } = null!;

        [Required]
        public int IdPedido { get; set; }

        [Required]
        public virtual Pedido Pedido { get; set; } = null!;

        // Constructor
        public Envio()
        {
        }

        public Envio(string tipoEnvio, double costo, DateTime fechaEstimada, int idEstado, int idPedido, string numeroSeguimiento)
            : this()
        {
            TipoEnvio = tipoEnvio;
            Costo = costo;
            FechaEstimada = fechaEstimada;
            IdEstado = idEstado;
            IdPedido = idPedido;
            NumeroSeguimiento = numeroSeguimiento;
        }
    }
}