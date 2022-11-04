using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_MauricioArroyo.Formularios
{
    public partial class FrmPrincipalMDI : Form
    {
        public FrmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void FrmPrincipalMDI_Load(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //En el caso del form de gestion de usuarios es nescesario establecerlo en globales

            //Si queremos que un formulario se muestre solo una vez deberiamos verificar que esté visible o no y en caso
            //de que lo esté este se reinstancia y se muestra de nuevo

            //El símbolo '!' niega una condición lógica
            if (!Globales.MiFormMantUsuarios.Visible)
            {
                Globales.MiFormMantUsuarios = new FrmUsuariosGestion(); 
                Globales.MiFormMantUsuarios.Show();
            }
           
        }
    }
}
