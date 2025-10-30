namespace Entidades.Models
{
    public class Notificacion
    {
        public int IdNotificacion { get; set; }
        public int UsuarioDestino { get; set; }//(FK)
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int IdUsuario { get; set; } // cliente (FK)
        public int IdEstado { get; set; }// estado (FK)

        // Relaciones 
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Destino { get; set; }
        public virtual Estado Estado { get; set; }

        public Notificacion()
        {
        }

        public Notificacion(int usuarioDestino, string mensaje, DateTime fechaEnvio, int idUsuario, int idEstado)
        {
            UsuarioDestino = usuarioDestino;
            Mensaje = mensaje;
            FechaEnvio = fechaEnvio;
            IdUsuario = idUsuario;
            IdEstado = idEstado;
        }
    }
}

