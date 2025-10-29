using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? Telefono { get; set; }
        public string Correo { get; set; }
        public string? ProductosSuministrados { get; set; }

        // Relaciones
        public virtual ICollection<ProductoProveedor> ProductosProveedor { get; set; }

        public Proveedor()
        {
            ProductosProveedor = new HashSet<ProductoProveedor>();
        }

        public Proveedor(string nombre, string apellido, string correo, string? telefono = null, string? productosSuministrados = null)
            : this()
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            ProductosSuministrados = productosSuministrados;
        }
    }
}