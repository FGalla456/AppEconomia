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
using Entidades;
using Negocio;

namespace Economica.Pantallas
{
    public partial class Pais : Form
    {
        Genericas Gen = new Genericas();
        Paises pais = new Paises();
        N_Pais np = new N_Pais();

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

        public Pais()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarVacios())
            {
                pais.Nombre_Pais1 = txtNombrePais.Text.ToString();
                pais.Nombre_Moneda1 = txtNombreMoneda.Text.ToString();
                np.CargarPais(pais);
            }
        }

        #region Validaciones
        public bool ComprobarVacios()
        {
            bool Error = false;
            string DatosError = "";
            if (txtNombrePais.Text.ToString() == "")
            {
                Error = true;
                DatosError += "\n - Nombre del Pais";
            }
            if (txtNombreMoneda.Text.ToString() == "")
            {
                Error = true;
                DatosError += "\n - Nombre de la Moneda";
            }
            
            Gen.CrearMensajeVacios(Error, DatosError);
            return Error;
        }
        #endregion
    }
}
