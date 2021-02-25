using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAO
{
    public class DAOGasto
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaGasto()
        {
            List<Gastos> lista = new List<Gastos>();
            DataTable tabla = ds.ObtenerTabla("Gasto", "select * from Gasto");
            return tabla;
        }

        public void InsertarGasto(Gastos gas)
        {
            string consulta = "insert into Gasto(idCategoria,Fecha,Monto,Descripcion,Estado) " +
                              "values (" + gas.IdCategoria + ",'" + gas.Fecha1 + "'," + gas.Monto1 + ",'" + gas.Descripcion1 + "',1)";

            ds.RealizarConsulta(consulta);
        }

        public DataTable getTablaGastosResumen()
        {
            List<Gastos> lista = new List<Gastos>();
            DataTable tabla = ds.ObtenerTabla("Gastos", "select Categoria.idCategoria as 'Categoria'," +
                "Categoria.Nombre,Monto from Gasto inner join Categoria on Categoria.idCategoria = Gasto.idCategoria where Gasto.Estado = 1");
            return tabla;
        }

    }
}
