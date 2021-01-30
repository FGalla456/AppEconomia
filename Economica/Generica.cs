using Economica.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generica
{
    class Genericas
    {
        #region KeyPress
        public void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void PermitirDecimales(object sender, KeyPressEventArgs e, string Texto)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
            if (Texto != "")
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (Texto.Contains('.'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.KeyChar = '.';
                        e.Handled = false;
                    }
                }
            }
        }

        public void PermitirSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion


        #region Mensajes

        #region Errores

        public void CrearMensajeVacios(bool Error,string Datos) 
        {
            if (Error == true)
            {
                MessageBox.Show("Faltan completar los campos: " + Datos);
            }
        }
        public void CrearMensajeValidacionesErroneas(bool Error, string Datos)
        {
            if (Error == true)
            {
                MessageBox.Show("Los siguientes campos no cumplen los requisitos solicitados: " + Datos);
            }
        }

        public void CrearMensajeFechaErronea()
        {
            MessageBox.Show("La Fecha no puede ser posterior a la actual: " + DateTime.Now.ToString());
        }

        #endregion

        #region Cargas
        public void CrearMensajeCargaCorrecta(string clase)
        {
            MessageBox.Show("La siguiente carga fue realizada correctamente: " + clase);
        }

        #endregion

        #endregion
    }
}
