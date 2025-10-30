using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Producto
    {

        [Key]
        public int IdProducto { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }
        public string? Tallas { get; set; }
        public string? Colores { get; set; }
        public string? Imagen { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int Stock { get; set; }

        // Claves foráneas
        public int EmpresaId { get; set; }
        public int? CategoriaId { get; set; }

        // Relaciones
        public virtual Empresa Empresa { get; set; }
        public virtual Categoria? Categoria { get; set; }

        public virtual ICollection<ProductoProveedor> ProductosProveedor { get; set; }
        public virtual ICollection<DetallePedido> ItemsPedido { get; set; }

        public Producto()
        {
            ProductosProveedor = new HashSet<ProductoProveedor>();
            ItemsPedido = new HashSet<DetallePedido>();
        }

        public Producto(string nombre, string? descripcion, string? tallas, string? colores,
                        string? imagen, decimal precio, int stock, int empresaId, int? categoriaId = null)
            : this()
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Tallas = tallas;
            Colores = colores;
            Imagen = imagen;
            Precio = precio;
            Stock = stock;
            EmpresaId = empresaId;
            CategoriaId = categoriaId;
        }
    }
}
