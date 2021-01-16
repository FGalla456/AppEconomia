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
        int idPais;
        string VCompraBlue;
        string VCompraOficial;
        string VVentaBlue;
        string VVentaOficial;
        string VCompraOficialImpuesto;

        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public int IdPais { get => idPais; set => idPais = value; }
        public string VCompraBlue1 { get => VCompraBlue; set => VCompraBlue = value; }
        public string VCompraOficial1 { get => VCompraOficial; set => VCompraOficial = value; }
        public string VVentaBlue1 { get => VVentaBlue; set => VVentaBlue = value; }
        public string VVentaOficial1 { get => VVentaOficial; set => VVentaOficial = value; }
        public string VCompraOficialImpuesto1 { get => VCompraOficialImpuesto; set => VCompraOficialImpuesto = value; }

    }
}
