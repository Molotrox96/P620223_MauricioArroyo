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
    public partial class FrmUsuariosGestion : Form
    {
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //Establecer como padre el formulario principal, de forma que se anide dentro del mismo
            MdiParent = Globales.MiFormPrincipal;

            CargarRolesDeUsuario();
            CargarEmpresas();


        }

        private void CargarRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRolUsuario = new Logica.Models.UsuarioRol();


            DataTable dt = new DataTable();
            dt = MiRolUsuario.Listar();


            if (dt != null && dt.Rows.Count > 0)
            {

                CboxRolUsuario.ValueMember = "IDUsuarioRol";
                CboxRolUsuario.DisplayMember = "Rol";
                CboxRolUsuario.DataSource = dt;
                CboxRolUsuario.SelectedIndex = -1; 
         

            }
        }


        private void CargarEmpresas()
        {
            Logica.Models.Empresa MiEmpresa = new Logica.Models.Empresa();


            DataTable dt = new DataTable();
            dt = MiEmpresa.Listar();


            if (dt != null && dt.Rows.Count > 0)
            {

                CboxEmpresa.ValueMember = "ID";
                CboxEmpresa.DisplayMember = "D";
                CboxEmpresa.DataSource = dt;
                CboxEmpresa.SelectedIndex = -1;


            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //Lo primero que debemos hacer es validar los datos mínimos necesarios
            //están completos.

            //Luego, se procede a realizar las 3 validaciones que se indican por medio de
            //los INCLUDE (USES) en el diagrama de casos de uso expandido
            //Si las 3 validaciones son NEGATIVAS se tiene permiso para agregar el usuario.

            if (ValidarCamposRequeridos())
            {
                //Los campos están completos
                bool CPorCedula;
                bool CPorNombreUsuario;
                bool CPorEmail;

                //Se crea una nueva instancia del usuario local y se agregan los valores 
                //de los atributos
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                MiUsuarioLocal.NombreUsuario = TxtNomUsuario.Text.Trim();
                MiUsuarioLocal.Email = TxtEmail.Text.Trim();
                MiUsuarioLocal.Contrasennia = TxtContrasennia.Text.Trim();

                MiUsuarioLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(CboxEmpresa.SelectedValue);
                MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CboxRolUsuario.SelectedValue);

                CPorCedula = MiUsuarioLocal.ConsultarPorCedula();
                CPorNombreUsuario = MiUsuarioLocal.ConsultarPorNombreUsuario();
                CPorEmail = MiUsuarioLocal.ConsultarPorEmail();

                if (!CPorCedula && !CPorNombreUsuario && !CPorEmail)
                {
                    string MSG = string.Format("¿Está seguro de agregar al usuario: {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(MSG, )

                    //Si las 3 validaciones son negativas agregamos el usuario

                    bool OK = MiUsuarioLocal.Agregar();

                    if (OK)
                    {
                        MessageBox.Show("Usuario agregado correctamente!", ":)", MessageBoxButtons.OK);


                    }
                    else
                    {
                        MessageBox.Show("No se agregó el usuario", ":(", MessageBoxButtons.OK);

                    }

                }
                else
                {
                    if (CPorCedula)
                    {
                        MessageBox.Show("Ya existe un usuario con la cédula digitada", "Error de Validación", MessageBoxButtons.OK);
                        return;


                    }

                    if (CPorNombreUsuario)
                    {
                        MessageBox.Show("Ya existe un usuario con el Nombre de Usuario digitado", "Error de Validación", MessageBoxButtons.OK);
                        return;


                    }

                    if (CPorEmail)
                    {
                        MessageBox.Show("Ya existe un usuario con el Email digitado", "Error de Validación", MessageBoxButtons.OK);
                        return;


                    }
                }


            }

        }

        private bool ValidarCamposRequeridos()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) && 
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNomUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()) &&
                CboxEmpresa.SelectedIndex > -1 && 
                CboxRolUsuario.SelectedIndex > -1)
            {
                R = true; 
            }
            else
            {
                //Se le informa al usuario que validación está fallando
                //estas validaciones en negativo deben ser puntuales para poder 
                //explicar al usuario que está fallando

                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre", "Error de Validación", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Cédula", "Error de Validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtNomUsuario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre de Usuario", "Error de Validación", MessageBoxButtons.OK);
                    TxtNomUsuario.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Correo", "Error de Validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Contraseña", "Error de Validación", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    return false;

                }



                //Validaciones de los COMBOBOX
                if (CboxEmpresa.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Empresa", "Error de Validación", MessageBoxButtons.OK);
                    CboxEmpresa.Focus();
                    return false;

                }

                if (CboxRolUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Rol de Usuario", "Error de Validación", MessageBoxButtons.OK);
                    CboxRolUsuario.Focus();
                    return false;

                }

            }

            return R;

        }






    }
}
