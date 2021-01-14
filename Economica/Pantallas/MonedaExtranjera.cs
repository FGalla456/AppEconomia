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
    public partial class MonedaExtranjera : Form
    {
        Genericas Gen = new Genericas();
        Entidades.MonedaExtranjera me = new Entidades.MonedaExtranjera();
        //N_MonedaExtranjera nme = new Negocio.N_MonedaExtranjera;

        public MonedaExtranjera()
        {
            InitializeComponent();
        }

        private void Dolar_Load(object sender, EventArgs e)
        {
            
            mcViejo.SetDate(DateTime.Parse("01/08/2020"));
            txtVCO1.Text = "76.25";  //Valor Compra Oficial
            txtVCB1.Text = "136";  //Valor Compra Blue
            txtVCOI1.Text = "99.13"; //Valor Compra con Impuesto
            txtVVO1.Text = "71.25";  //Valor Venta Oficial
            txtVVB1.Text = "131";  //Valor Venta Blue
            mcNuevo.SetDate(DateTime.Today);
            txtVCO2.Focus();
            //mcNuevo.MaxDate = DateTime.Today;
        }

        #region KeyPress

        public void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            Gen.PermitirSoloNumeros(sender,e);
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

        #region Botones
        private void btnInternet_Click(object sender, EventArgs e)
        {
            Precio_Moneda_Extranjera PME = new Precio_Moneda_Extranjera();
            PME.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ComprobarVacios())
            {
                me.VCompraBlue1 = float.Parse(txtVCB2.Text);
                me.VCompraOficial1 = float.Parse(txtVCO2.Text);
                me.VCompraOficialImpuesto1 = float.Parse(txtVCOI2.Text);
                me.VVentaBlue1 = float.Parse(txtVVB2.Text);
                me.VVentaOficial1 = float.Parse(txtVVO2.Text);
                me.Fecha1 = mcNuevo.ToString();
                this.Close();
            }
        }

        #endregion

        #region Validaciones

        private bool ComprobarVacios() 
        {
            bool Error = false;
            string DatosError = "";

            if (txtVCO2.Text.Trim() == "")  //Valor de Compra Oficial 
            {
                Error = true;
                DatosError += "\n - Valor de Compra Oficial";
            }
            if (txtVCB2.Text.Trim() == "") //Valor de Compra Blue
            {
                Error = true;
                DatosError += "\n - Valor de Compra Blue";
            }
            if (txtVCOI2.Text.Trim() == "") //Valor de Compra con Impuesto
            {
                Error = true;
                DatosError += "\n - Valor de Compra Con Impuesto";
            }
            if (txtVVO2.Text.Trim() == "") //Valor de Venta Oficial
            {
                Error = true;
                DatosError += "\n - Valor de Venta Oficial";
            }
            if (txtVVB2.Text.Trim() == "") //Valor de Venta Blue
            {
                Error = true;
                DatosError += "\n - Valor de Venta Blue";
            }
 
            Gen.CrearMensajeVacios(Error, DatosError);

            return Error;
        }


        #endregion

        private void mcNuevo_DateChanged(object sender, DateRangeEventArgs e)
        {
            mcNuevo.SelectionEnd = mcNuevo.SelectionStart;
            if (mcNuevo.SelectionStart >= DateTime.Today || mcNuevo.SelectionStart <= mcViejo.SelectionStart)
            {
                mcNuevo.SelectionStart = DateTime.Today;
            }
        }
    }
}
