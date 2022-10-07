using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasennia { get; set; }
        public string CodigoRecuperacion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public Empresa MiEmpresa { get; set; }

        public UsuarioRol MiRol { get; set; }

        public Usuario()
        {
            MiEmpresa = new Empresa();
            MiRol = new UsuarioRol();
            Activo = true; 

        }

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

        public Usuario ConsultarPorID()
        {

            Usuario R = new Usuario();
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

        public bool ConsultarPorNombreUsuario()
        {

            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //SELECT correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public bool ConsultarPorEmail()
        {

            bool R = false;
            //TODO: ejecutar un SP que tenga la instruccion
            //SELECT correspondiente y retornar TRUE si
            //todo sale bien
            return R;

        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            //TODO: Usar SP con parámetro para ver proovedores eliminados o activos

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            //TODO: Usar SP con parámetro para ver proovedores eliminados o activos

            return R;
        }

        public bool ValidarLogin(string NombreUsuario , string Contrasennia)
        {
            bool R = false;

            return R; 
        }

        public bool EnviarCodigoRecuperacion(string Email)
        {

            bool R = false;

            return R;

        }

        public bool ResetearContrasennia()
        {

            bool R = false;

            return R;

        }


    }
}
