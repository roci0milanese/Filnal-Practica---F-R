using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Reporte
    {
        [Key]
        public int IdReporte { get; set; } // (NOT NULL, PK)

        [Required]
        public string TipoReporte { get; set; } // (NOT NULL)

        [Required]
        public DateTime FechaInicio { get; set; } // (NOT NULL)

        [Required]
        public DateTime FechaFin { get; set; } // (NOT NULL)

        public string? Datos { get; set; } // (NULL)

        [Required]
        public int IdUsuario { get; set; } // (NOT NULL, FK)
        public virtual Usuario Usuario { get; set; }

        [Required]
        public int IdEstado { get; set; } // (NOT NULL, FK)
        public virtual Estado Estado { get; set; }

        public Reporte() { }

        public Reporte(string tipoReporte, DateTime fechaInicio, DateTime fechaFin, int idUsuario, int idEstado)
        {
            TipoReporte = tipoReporte;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            IdUsuario = idUsuario;
            IdEstado = idEstado;
        }
    }
}
