using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public string TipoReporte { get; set; } 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? Datos { get; set; }

        // Relaciones
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int IdEstado { get; set; }
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

       