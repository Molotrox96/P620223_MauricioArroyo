using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {

        public int IDFactura { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }

        public List<FacturaInventario> Detalle { get; set; }
        public Usuario MiUsuario { get; set; }
        public Cliente MiCliente { get; set; }
        public FacturaTipo MiFacturaTipo { get; set; }

        public Factura()
        {
            Detalle = new List<FacturaInventario>();
            MiUsuario = new Usuario();
            MiCliente = new Cliente();
            MiFacturaTipo = new FacturaTipo();

            Fecha = DateTime.Now; //Para agregar la fecha del momento cuando se hace una factura
            
        }

        public int Agregar()
        {
            
            return 0; 
        }

        public bool Imprimir()
        {
            bool R = false;
            
            return R;
        }

        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
