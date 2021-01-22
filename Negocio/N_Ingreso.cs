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
    public class N_Ingreso
    {

        DAOIngreso di = new DAOIngreso();

        public DataTable getTabla() 
        {
            return di.getTablaIngreso();
        }

        public DataTable getTablaResumen()
        {
            return di.getTablaIngresoResumen();
        }

        public void CargarIngreso(Ingresos ing) 
        {
            di.InsertarIngreso(ing);
        }

    }
}
