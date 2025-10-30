using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }

        [Required]
        public string NombreEstado { get; set; } = null!;

        [Required]
        public string Descripcion { get; set; } = null!;

        // Relación 1:N con Pedido
        public virtual ICollection<Pedido> Pedidos { get; set; }


        public Estado()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public Estado(string nombreEstado, string descripcion)
            : this()
        {
            NombreEstado = nombreEstado;
            Descripcion = descripcion;
        }
    }
 
}

