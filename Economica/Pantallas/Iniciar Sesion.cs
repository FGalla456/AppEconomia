using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Generica;

namespace Economica.Pantallas
{
    public partial class Iniciar_Sesion : Form
    {
        Genericas gen = new Genericas();
        N_Usuario nusu = new N_Usuario();
        Usuario usu = new Usuario();

        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse Reg = new Registrarse();
            Reg.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarVacios())
            {
                usu = nusu.VerificarUsuario(txtCorreo.Text.ToString(), txtContraseña.Text.ToString());

                if (usu.Estado1 == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario Inexistente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Validaciones

        public bool ComprobarVacios()
        {
            bool Error = false;
            string DatosError = "";
            if (txtCorreo.Text.ToString() == "")
            {
                Error = true;
                DatosError += "\n - Correo";
            }
            if (txtContraseña.Text.ToString() == "")
            {
                Error = true;
                DatosError += "\n - Contraseña";
            }

            gen.CrearMensajeVacios(Error, DatosError);
            return Error;
        }
        #endregion
    }
}
