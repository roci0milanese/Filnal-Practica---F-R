using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Pago
    {

        public int IdPago { get; set; }
        public double Monto { get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaPago { get; set; }

        public int IdEstado { get; set; }
        public int IdPedido { get; set; }
        public int IdFactura { get; set; }

        // Relaciones
        public virtual Estado Estado { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Factura Factura { get; set; }

        public Pago()
        {
        }

        public Pago(double monto, string metodoPago, DateTime fechaPago, int idEstado, int idPedido, int idFactura)
        {
            Monto = monto;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;
            IdEstado = idEstado;
            IdPedido = idPedido;
            IdFactura = idFactura;
        }
    }
}

