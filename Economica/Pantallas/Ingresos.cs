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
    public partial class Ingresos : Form
    {
        Genericas Gen = new Genericas();
        N_Ingreso ni = new N_Ingreso();
        Entidades.Ingresos ing = new Entidades.Ingresos(); 

        public Ingresos()
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
            ing.Descripcion1 = txtDescripcion.Text.ToString();
            ing.Monto1 = Int32.Parse(txtMonto.Text.ToString());
            ni.CargarIngreso(ing);
        }
    }
}
