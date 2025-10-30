using System.ComponentModel.DataAnnotations;


namespace Entidades.Models
{

    public class Medios_De_Contacto
    {
        [Required]
        public string Medio { get; set; } = null!;

        [Required]
        public string Valor { get; set; } = null!;

        // Clave foránea
        [Required]
        public int EmpresaId { get; set; }

        // Relación: cada medio pertenece a una sola empresa
        [Required]
        public virtual Empresa Empresa { get; set; } = null!;
    }

    public class Empresa
    {
       
        [Key]
        public int IdEmpresa { get; set; }

        [Required]
        public string NombreComercial { get; set; } = null!;

        [Required]
        public string Logo { get; set; } = null!;

        [Required]
        public string Colores { get; set; } = null!;

        [Required]
        public string Tipografia { get; set; } = null!;

        [Required]
        public int Cuit { get; set; }

        [Required]
        public string Direccion { get; set; } = null!;

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