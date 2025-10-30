using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{

    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; } // PK (NOT NULL)

        [Required]
        public string NombreUsuario { get; set; } // (NOT NULL)

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string TipoUsuario { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        public string? IdiomaPreferido { get; set; } // (NULL)

        public string? Telefono { get; set; } // (NULL)

        [Required]
        public string Cuit { get; set; } // (NOT NULL, UNIQUE en configuración)

        [Required]
        public string RazonSocial { get; set; } // (NOT NULL)

        [Required]
        public string CondicionIVA { get; set; } // (NOT NULL)

        // Relaciones
        public virtual ICollection<Reporte> Reportes { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public Usuario()
        {
            Reportes = new HashSet<Reporte>();
            Pedidos = new HashSet<Pedido>();
        }

        public Usuario(
            string nombreUsuario,
            string apellido,
            string email,
            string password,
            string tipoUsuario,
            DateTime fechaRegistro,
            string cuit,
            string razonSocial,
            string condicionIVA
        ) : this()
        {
            NombreUsuario = nombreUsuario;
            Apellido = apellido;
            Email = email;
            Password = password;
            TipoUsuario = tipoUsuario;
            FechaRegistro = fechaRegistro;
            Cuit = cuit;
            RazonSocial = razonSocial;
            CondicionIVA = condicionIVA;
        }
    }
}