﻿using System;
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
            gas.Descripcion1 = txtDescripcion.Text.ToString();
            gas.Monto1 = Int32.Parse(txtMonto.Text.ToString());
            ng.CargarGasto(gas);

        }
    }
}