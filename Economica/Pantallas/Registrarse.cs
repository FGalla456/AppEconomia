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
    public partial class Registrarse : Form
    {
        Genericas gen = new Genericas();
        N_Usuario nu = new N_Usuario();
        Usuario usu = new Usuario();

        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarVacios())
            {
                if (!ValidarCampos()) 
                {
                    usu.Nombre1 = txtNombre.Text.ToString();
                    usu.Apellido1 = txtApellido.Text.ToString();
                    usu.Correo1 = txtCorreo.Text.ToString();
                    if (txtContraseña.Text.ToString() == txtRepetirContra.Text.ToString())
                    {
                        usu.Contraseña1 = txtContraseña.Text.ToString();
                    }
                    DateTime dt = DateTime.Parse(dtpNacimiento.Text.ToString());
                    usu.Nacimiento1 = dt.ToString("yyyy-MM-dd");
                    nu.CrearUsuario(usu);
                    this.Close();
                }
            }
        }
       
        #region Validaciones
        
        public bool ComprobarVacios() 
        {
            bool Error = false;
            string DatosError = "";
            if (txtNombre.Text.ToString() == "") 
            {
                Error = true;
                DatosError += "\n - Nombre";
            }
            if (txtApellido.Text.ToString() == "")
            {
                Error = true;
                DatosError += "\n - Apellido";
            }
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
            else 
            {
                if (txtContraseña.Text.ToString() != txtRepetirContra.Text.ToString())
                {
                    //Error = true;
                    MessageBox.Show("Las Contraseñas no Coinciden");
                }
            }

            gen.CrearMensajeVacios(Error, DatosError);
            return Error;
        }

        public bool ValidarCampos()
        {
            string DatosError = "";
            bool Error = false;
            if (txtNombre.Text.ToString().Trim().Length < 2)
            {
                Error = true;
                DatosError += "\n - Nombre Invalido";
            }
            if (txtApellido.Text.ToString().Trim().Length < 2)
            {
                Error = true;
                DatosError += "\n - Apellido Invalido";
            }
            if (txtCorreo.Text.ToString().Trim().Length < 8)
            {
                Error = true;
                DatosError += "\n - Tamaño del Correo Incorrecto";
            }
            else
            {
                if (txtCorreo.Text.ToString().Trim().Contains("@"))
                {
                    if (txtCorreo.Text.ToString().Trim().IndexOf("@") < 2)
                    {
                        Error = true;
                        DatosError += "\n - Formato del Correo Incorrecto";
                    }
                }
                else 
                {
                    Error = true;
                    DatosError += "\n - Formato del Correo Incorrecto";
                }
            }
            if (txtContraseña.Text.ToString().Trim().Length < 2)
            {
                Error = true;
                DatosError += "\n - Contraseña Demasiado Corta";
            }
            gen.CrearMensajeValidacionesErroneas(Error, DatosError);
            return Error;
        }

        #endregion
    }
}
