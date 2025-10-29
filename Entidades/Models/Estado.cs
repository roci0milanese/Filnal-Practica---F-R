using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public string Descripcion { get; set; }

        // Relación 1:N con Pedido
        public virtual ICollection<Pedido> Pedidos { get; set; }

        //  inicializa la colección
        public Estado()
        {
            Pedidos = new HashSet<Pedido>();
        }

      
        public Estado(string nombreEstado, string descripcion = null) : this()
        {
            NombreEstado = nombreEstado;
            Descripcion = descripcion;
        }

      
    }
}  
