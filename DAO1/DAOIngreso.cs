using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAO
{
    public class DAOIngreso
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaIngreso()
        {
            List<Ingresos> lista = new List<Ingresos>();
            DataTable tabla = ds.ObtenerTabla("Ingreso", "select * from Ingreso");
            return tabla;
        }

        public void InsertarIngreso(Ingresos ing)
        {
            string consulta = "insert into Ingreso(idCategoria,Monto,Descripcion,Estado) " +
                               "values (" + ing.IdCategoria + "," + ing.Monto1 + ",'" + ing.Descripcion1 + "',1)";

            ds.RealizarConsulta(consulta);
        }
    }
}
