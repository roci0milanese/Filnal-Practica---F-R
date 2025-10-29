using Entidades.Models;

namespace Entidades
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Relaciones
        public int? IdUsuarioAdmin { get; set; }   // puede ser NULL
        public virtual Usuario? UsuarioAdmin { get; set; }

        public int? IdUsuarioCajero { get; set; }  // puede ser NULL
        public virtual Usuario? UsuarioCajero { get; set; }

        public int IdEmpresa { get; set; }
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
