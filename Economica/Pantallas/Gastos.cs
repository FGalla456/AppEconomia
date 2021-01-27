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

namespace Economica
{
    public partial class Gastos : Form
    {
        Genericas Gen = new Genericas();
        N_Gasto ng = new N_Gasto();
        N_Categoria nc = new N_Categoria();
        Entidades.Gastos gas = new Entidades.Gastos();
        
        public Gastos()
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
            gas.IdCategoria = Int32.Parse(cbCategorias.SelectedValue.ToString());
            gas.Descripcion1 = txtDescripcion.Text.ToString();
            gas.Monto1 = Int32.Parse(txtMonto.Text.ToString());
            ng.CargarGasto(gas);
            Gen.CrearMensajeCargaCorrecta("Gasto");

        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            cbCategorias.ValueMember = "idCategoria";
            cbCategorias.DisplayMember = "Nombre";
            cbCategorias.DataSource = nc.getTablaCatFiltrada(0);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecha.Value > DateTime.Now)
            {
                dtpFecha.Value = DateTime.Now;
                Gen.CrearMensajeFechaErronea();
            }
        }
    }
}
