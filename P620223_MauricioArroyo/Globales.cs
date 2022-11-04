using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_MauricioArroyo
{
    public static class Globales
    {
        //Los objetos que definamos en esta clase serán accesibles desde la totalidad de la aplicación. 
        //Además esta clase al ser STATIC se auto instancia

        //El siguiente formulario principal se puede invocar desde cualquier lugar(LOGIN en nuestro caso)
        public static Form MiFormPrincipal = new Formularios.FrmPrincipalMDI();

        public static Form MiFormMantUsuarios = new Formularios.FrmUsuariosGestion(); 

    }
}
