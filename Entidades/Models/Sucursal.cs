using Entidades.Models;

namespace Entidades
{
    using System.ComponentModel.DataAnnotations;

    public class Sucursal
    {
        [Key]
        public int IdSucursal { get; set; } // (NOT NULL, PK)

        [Required]
        public string NombreSucursal { get; set; } // (NOT NULL)

        [Required]
        public string Direccion { get; set; } // (NOT NULL)

        [Required]
        public string Telefono { get; set; } // (NOT NULL)

        [Required]
        public string Email { get; set; } // (NOT NULL)

        public int? IdUsuarioAdmin { get; set; } // (NULL)
        public virtual Usuario? UsuarioAdmin { get; set; }

        public int? IdUsuarioCajero { get; set; } // (NULL)
        public virtual Usuario? UsuarioCajero { get; set; }

        [Required]
        public int IdEmpresa { get; set; } // (NOT NULL, FK)
        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

        public Sucursal()
        {
            Stocks = new HashSet<Stock>();
        }

        public Sucursal(string nombreSucursal, string direccion, string telefono, string email, int idEmpresa)
            : this()
        {
            NombreSucursal = nombreSucursal;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            IdEmpresa = idEmpresa;
        }
    }
}