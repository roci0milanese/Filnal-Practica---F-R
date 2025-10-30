using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Cliente : Usuario
    {
        [Required] // no puede ser null
        public string NombreComercial { get; set; }

        public string? TelefonoTienda { get; set; } // Puede estar vacío

        [Required]
        public string EmailFactura { get; set; }

        [Required]
        public string RubroCategoria { get; set; }

        [Required]
        public string DireccionFiscal { get; set; }

        public Cliente() : base() { }

        public Cliente(
            string nombreComercial,
            string? telefonoTienda,
            string emailFactura,
            string rubroCategoria,
            string direccionFiscal
        ) : base()
        {
            NombreComercial = nombreComercial;
            TelefonoTienda = telefonoTienda;
            EmailFactura = emailFactura;
            RubroCategoria = rubroCategoria;
            DireccionFiscal = direccionFiscal;
        }
    }
}