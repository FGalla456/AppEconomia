using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DAOPais
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaCategoria()
        {
            List<Paises> lista = new List<Paises>();
            DataTable tabla = ds.ObtenerTabla("Pais", "select * from Pais");
            return tabla;
        }

        public void InsertarPais(Paises pais)
        {
            string consulta = "insert into Pais(Nombre_Pais,Nombre_Moneda,Estado) " +
                              "values ('" + pais.Nombre_Pais1 + "','" + pais.Nombre_Moneda1 + "',1)";

            ds.RealizarConsulta(consulta);
        }
    }
}
