using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MonedaExtranjera
    {
        string Fecha;
        float VCompraBlue;
        float VCompraOficial;
        float VVentaBlue;
        float VVentaOficial;
        float VCompraOficialImpuesto;

        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public float VCompraBlue1 { get => VCompraBlue; set => VCompraBlue = value; }
        public float VCompraOficial1 { get => VCompraOficial; set => VCompraOficial = value; }
        public float VVentaBlue1 { get => VVentaBlue; set => VVentaBlue = value; }
        public float VVentaOficial1 { get => VVentaOficial; set => VVentaOficial = value; }
        public float VCompraOficialImpuesto1 { get => VCompraOficialImpuesto; set => VCompraOficialImpuesto = value; }
    }
}
