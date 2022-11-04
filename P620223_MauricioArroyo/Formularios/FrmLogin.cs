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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BtnVerPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Cierra completamente la App
            Application.Exit();
        }

        private void BtnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false; 
        }

        private void BtnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true; 
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //TODO: Se debe validar el ingreso del usuario

            //Si la validación es correcta, permite bel ingreso al sistema y muestra el formulario principal

            Globales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}
