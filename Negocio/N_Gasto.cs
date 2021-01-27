using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Data;

namespace Negocio
{
    public class N_Gasto
    {

        DAOGasto dg = new DAOGasto();

        public DataTable getTabla()
        {
            return dg.getTablaGasto();
        }

        public DataTable getTablaResumen()
        {
            return dg.getTablaGastosResumen();
        }

        public void CargarGasto(Gastos gas)
        {
            dg.InsertarGasto(gas);
        }

    }
}
