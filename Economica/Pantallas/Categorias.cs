using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generica;
using Negocio;
using Entidades;

namespace Economica.Pantallas
{
    public partial class Categorias : Form
    {
        Genericas Gen = new Genericas();
        N_Categoria nc = new N_Categoria();
        Entidades.Categorias cat = new Entidades.Categorias();

        public Categorias()
        {
            InitializeComponent();
        }

        #region KeyPress

        public void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            Gen.PermitirSoloNumeros(sender, e);
        }

        public void PermitirSoloLetras(object sender, KeyPressEventArgs e)
        {
            Gen.PermitirSoloLetras(sender, e);
        }

        public void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            Gen.NoPermitirEscribir(sender, e);
        }


        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarVacios()) 
            {
                if(rbGasto.Checked)
                cat.Tipo1 = 0;
                else
                {
                    cat.Tipo1 = 1;
                }
                cat.Nombre1 = txtNombre.Text.ToString();
                cat.Descripcion1 = txtDescripcion.Text.ToString();
                nc.CargarCategoria(cat);
                Gen.CrearMensajeCargaCorrecta("Gasto");
            }
        }

        #region Validaciones
        private bool ComprobarVacios() 
        {
            bool Error = false;
            string DatosError = "";
            if (txtNombre.Text.ToString().Trim() == "") 
            {
                Error = true;
                DatosError += "\n - Nombre de la Categoria";
            }
            if (rbGasto.Checked == false && rbIngreso.Checked == false) 
            {
                Error = true;
                DatosError += "\n - Tipo";
            }

            Gen.CrearMensajeVacios(Error,DatosError);
            return Error;
        }

        #endregion

    }
}
