using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAO
{
    public class DAOMonedaExtranjera
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaMonExt()
        {
            List<MonedaExtranjera> lista = new List<MonedaExtranjera>();
            DataTable tabla = ds.ObtenerTabla("MonedaExtranjera", "select * from MonedaExtranjera");
            return tabla;
        }

        public void InsertarValorMonExt(MonedaExtranjera me)
        {
            string consulta = "insert into MonedaExtranjera(Fecha,idPais,VCompraBlue,VCompraOficial,VVentaBlue,VVentaOficial,VCompraOficialImpuesto) " +
                               "values ('" + me.Fecha1 +"',"+ me.IdPais +"," + me.VCompraBlue1 + "," + me.VCompraOficial1 + ","
                               + me.VVentaBlue1 + "," + me.VVentaOficial1 + "," + me.VCompraOficialImpuesto1 + ")";

            ds.RealizarConsulta(consulta);
        }


    }
}
