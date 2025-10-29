using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Cliente
    { 

        [Key]
        public int IdCliente { get; set; }

        public string NombreComercial { get; set; }

        public string? TelefonoTienda { get; set; } //(puede estar vacío)

        public string EmailFactura { get; set; }
        public string RubroCategoria { get; set; }
        public string DireccionFiscal { get; set; }

        // Relación con los pedidos (un cliente puede tener muchos pedidos)
        public virtual ICollection<Pedido> Pedidos { get; set; }

      
        public Cliente(string nombreComercial, string? telefonoTienda, string emailFactura, string rubroCategoria, string direccionFiscal)
        {
            NombreComercial = nombreComercial;
            TelefonoTienda = telefonoTienda;
            EmailFactura = emailFactura;
            RubroCategoria = rubroCategoria;
            DireccionFiscal = direccionFiscal;
            Pedidos = new HashSet<Pedido>();
        }

 
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>(); 
        }
    }
}


