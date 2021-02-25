using Economica.Pantallas;
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
        Entidades.Usuario usu = new Entidades.Usuario();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.Invalidate();
            lblVersion.Text = "0.9.1";
            Iniciar_Sesion In = new Iniciar_Sesion();
            In.ShowDialog();
            usu = In.usu;
            if(usu.Correo1 == null) 
            {
                this.Close();
            }
            else 
            {
                lblNombre.Text = "Hola " + usu.Nombre1 + " " + usu.Apellido1;
                if (usu.Administrador1 == true) 
                {
                    btnPais.Visible = true;
                }
                else 
                {
                    btnPais.Visible = false;
                }
            }

        }

        private void AbrirHijo<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //   formulario.Dock = DockStyle.Fill;
                formulario.Anchor = AnchorStyles.Bottom;
                formulario.Anchor = AnchorStyles.Left;
                formulario.Anchor = AnchorStyles.Right;
                formulario.Anchor = AnchorStyles.Top;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //Si el Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        #region ClicksPanelMenu
        private void btnGastos_Click(object sender, EventArgs e)
        {
            AbrirHijo<Gastos>();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirHijo<Ingresos>();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            AbrirHijo<Resumen>();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirHijo<Categorias>();
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            AbrirHijo <MonedaExtranjera>();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            AbrirHijo<Pais>();
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
            AbrirHijo<Configuracion>();
        }

        #endregion

        private void PanelSuperior_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Blue);
            e.Graphics.DrawRectangle(p, PanelSuperior.Left - 1, PanelSuperior.Top - 1, PanelSuperior.Width + 1, PanelSuperior.Height + 1);
        }
    }
}
