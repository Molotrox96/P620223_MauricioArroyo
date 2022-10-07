using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Inventario
    {

        public int IDInventario { get; set; }
        public string NombreItem { get; set; }
        public string CodigoBarras { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadEnStock { get; set; }
        public bool Activo { get; set; }

        //Atributis Compuestos
        public Empresa MiEmpresa { get; set; }
        public Categoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }

        //Como la relación contra los proveedores (por medio de la tabla de  muchos a muchos) 
        //termina en '*', quiere decir que podrían haber varios proveedores que ofrecen un item
        //por lo tanto, el atributo es multivaluado, se debe usar LIST<>
        public List<InventarioProveedor> ListadoProvedores { get; set; }


        public Inventario()
        {
            MiEmpresa = new Empresa();
            MiCategoria = new Categoria();
            MiImpuesto = new Impuesto(); 
            ListadoProvedores = new List<InventarioProveedor>();
            Activo = true;
        }

        //Funciones y métodos
        public bool Agregar()
        {
            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //INSERT correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public bool Modificar()
        {
            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //UPDATE correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public bool Eliminar()
        {
            //En las eliminaciones logicas, lo que haremos será cambiar el valor del 
            //campo activo a 0 (FALSE)

            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //UPDATE correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public Inventario ConsultarPorID()
        {

            Inventario R = new Inventario();
            //TODO: En este caso el retorno es del mismo tipo de la clase
            //por lo tanto, hay que llenar los atributos con los datos 
            //que entregue un SP SELECT

            return R;

        }

        public bool ConsultarPorCodigoBarras(int IDEmpresa)
        {
            //En las eliminaciones logicas, lo que haremos será cambiar el valor del 
            //campo activo a 0 (FALSE)

            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //SELECT correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R; 
        }

        public DataTable ListarProveedores()
        {
            DataTable R = new DataTable();

            return R;
        }

        public bool AgregarProveedor()
        {
            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //INSERT correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public bool EliminarProveedor()
        {
            //En las eliminaciones logicas, lo que haremos será cambiar el valor del 
            //campo activo a 0 (FALSE)

            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //UPDATE correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public bool ModificarPrecioProveedor()
        {
            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //UPDATE correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

    }
}
