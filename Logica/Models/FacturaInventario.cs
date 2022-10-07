using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaInventario
    {

        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Subtotal { get; set; } //Cantidad * PrecioVenta
        public decimal DescuentoTotal { get; set; }
        public decimal Subtotal2 { get; set; } //Subtotal - DescuentoTotal
        public decimal ImpuestoTotal { get; set; }
        public decimal TotalLinea { get; set; } //Subtotal2 + ImpuestoTotal

        //Atributos Compuestos
        public Inventario MiInventario { get; set; }

        public FacturaInventario()
        {
            MiInventario = new Inventario();
        }

        public decimal TotalizarLinea()
        {
            

            //Totalizar Subtotal
            Subtotal = Cantidad * PrecioVenta;

            //Monto del descuento
            DescuentoTotal = (Subtotal * PorcentajeDescuento) / 100;

            //Subtotal2
            Subtotal2 = Subtotal - DescuentoTotal; 

            //Impuesto
            ImpuestoTotal = (Subtotal2 * PorcentajeImpuesto) / 100;

            //Total final
            TotalLinea = Subtotal2 + ImpuestoTotal;


            return TotalLinea; 
        }

    }
}
