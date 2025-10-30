using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Notificacion
    {
        [Key]
        public int IdNotificacion { get; set; }

        [Required]
        public int UsuarioDestino { get; set; } // FK

        [Required]
        public string Mensaje { get; set; } = null!;

        [Required]
        public DateTime FechaEnvio { get; set; }

        [Required]
        public int IdUsuario { get; set; } // FK

        [Required]
        public int IdEstado { get; set; } // FK

        // Relaciones
        [Required]
        public virtual Usuario Usuario { get; set; } = null!;

        [Required]
        public virtual Usuario Destino { get; set; } = null!;

        [Required]
        public virtual Estado Estado { get; set; } = null!;

        public Notificacion()
        {
        }

        public Notificacion(int usuarioDestino, string mensaje, DateTime fechaEnvio, int idUsuario, int idEstado)
            : this()
        {
            UsuarioDestino = usuarioDestino;
            Mensaje = mensaje;
            FechaEnvio = fechaEnvio;
            IdUsuario = idUsuario;
            IdEstado = idEstado;
        }
    }
}