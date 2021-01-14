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

            if (usu.Correo1 == txtCorreo.Text.ToString() && usu.Contraseña1 == txtContraseña.Text.ToString()) 
            {

            }
            else 
            {
                MessageBox.Show("Usuario Inexistente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
