﻿using Economica.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economica
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Iniciar_Sesion In = new Iniciar_Sesion();
            In.ShowDialog();
        }

        #region ClicksPanelMenu
        private void btnGastos_Click(object sender, EventArgs e)
        {
            Gastos Gas = new Gastos();
            Gas.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            Ingresos Ing = new Ingresos();
            Ing.Show();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            Resumen res = new Resumen();
            res.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categorias Cat = new Categorias();
            Cat.Show();
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            MonedaExtranjera Me = new MonedaExtranjera();
            Me.Show();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais();
            pais.Show();
        }

        #endregion

        #region ClicksPanelSuperior

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion Con = new Configuracion();
            Con.Show();
        }

        #endregion
    }
}
