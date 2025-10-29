using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.Models
{
   
    public class Medios_De_Contacto
    {
        public string Medio { get; set; }
        public string Valor { get; set; }

        // Clave foránea 
        public int EmpresaId { get; set; }

        // Relación: cada medio pertenece a una sola empresa
        public Empresa Empresa { get; set; }
    }


   
    public class Empresa
    {
        // (clave primaria)
       [Key] public int IdEmpresa { get; set; }
        public string NombreComercial { get; set; }

        // Logo de la empresa (puede ser una ruta o URL de la imagen)
        public string Logo { get; set; }
        public string Colores { get; set; }
        public string Tipografia { get; set; }
        public int Cuit { get; set; }
        public string Direccion { get; set; }
        public List<Medios_De_Contacto> MediosContacto { get; set; } = new();

  
        public Empresa(string nombreComercial, string logo, string colores, string tipografia, int cuit, string direccion)
        {
            NombreComercial = nombreComercial;
            Logo = logo;
            Colores = colores;
            Tipografia = tipografia;
            Cuit = cuit;
            Direccion = direccion;
        }

        // Una empresa puede tener varios proveedores, productos y sucursales
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }

        public Empresa()
        {
            Proveedores = new HashSet<Proveedor>();
            Productos = new HashSet<Producto>();
            Sucursales = new HashSet<Sucursal>();
        }
    }
}