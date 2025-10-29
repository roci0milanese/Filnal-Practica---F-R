using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string? IdiomaPreferido { get; set; }
        public string? Telefono { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string CondicionIVA { get; set; }

        // Relaciones
        public virtual ICollection<Reporte> Reportes { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }


        public Usuario()
        {
            Reportes = new HashSet<Reporte>();   
            Pedidos = new HashSet<Pedido>(); 
            //cuando se crea un usuario,también se crean listas vacías donde se
            //los pedidos que pertenecen a ese usuario. no permite elementos repetidos.
        }


        public Usuario(
            string nombreUsuario, string apellido, string email, string password, string tipoUsuario,
            DateTime fechaRegistro, string cuit, string razonSocial, string condicionIVA)
            : this() //Llama al otro constructor de la misma clase para reutilizar código.
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