using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DAOCategoria
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaCategoria()
        {
            List<Categorias> lista = new List<Categorias>();
            DataTable tabla = ds.ObtenerTabla("Categoria", "select * from Categoria");
            return tabla;
        }

        public DataTable getTablaCategoriaFiltrada(int Tipo)
        {
            List<Categorias> lista = new List<Categorias>();
            DataTable tabla = ds.ObtenerTabla("Categoria", "select * from Categoria where Tipo =" + Tipo);
            return tabla;
        }

        public void InsertarCategoria(Categorias cat)
        {
            string consulta = "insert into Categoria(Tipo,Nombre,Descripcion,Estado) " +
                              "values (" + cat.Tipo1 + ",'" + cat.Nombre1 + "','" + cat.Descripcion1 + "',1)";

            ds.RealizarConsulta(consulta);
        }
    }
}
