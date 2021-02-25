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
            string consulta = "insert into Ingreso(idCategoria,Fecha,Monto,Descripcion,Estado) " +
                               "values (" + ing.IdCategoria + ",'" + ing.Fecha1 + "'," + ing.Monto1 + ",'" + ing.Descripcion1 + "',1)";

            ds.RealizarConsulta(consulta);
        }

        public DataTable getTablaIngresoResumen()
        {
            List<Ingresos> lista = new List<Ingresos>();
            DataTable tabla = ds.ObtenerTabla("Ingreso", "select Categoria.idCategoria as 'Categoria'," +
                "Categoria.Nombre,Monto from Ingreso inner join Categoria on Categoria.idCategoria = Ingreso.idCategoria where Ingreso.Estado = 1");
            return tabla;
        }
    }
}
