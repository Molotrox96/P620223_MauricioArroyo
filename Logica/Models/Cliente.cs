using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {

        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        //En este caso hay un atributo compuesto que une la clase Cliente con la clase Empresa
        //esto debido a la lectura de la relacion que existe desde el Diagrama ER


        //Atributos complejos
        public Empresa MiEmpresa { get; set; }

        //Cuando tratamos atributos complejos, estos normalmente se definen como cualquier propiedad
        //pero esa propiedad NO ESTÁ instanciada, por lo tanto se debe instanciar en el constructor de la clase

        public Cliente()
        {
            //este es el metodo constructor de la clase
            MiEmpresa = new Empresa();

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

        public Cliente ConsultarPorID()
        {

            Cliente R = new Cliente();
            //TODO: En este caso el retorno es del mismo tipo de la clase
            //por lo tanto, hay que llenar los atributos con los datos 
            //que entregue un SP SELECT

            return R;

        }

        public bool ConsultarPorCedula()
        {

            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //SELECT correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            //TODO: Usar SP con parámetro para ver proovedores eliminados o activos

            return R;
        }

    }
}
