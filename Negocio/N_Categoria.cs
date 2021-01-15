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
    public class N_Categoria
    {

        DAOCategoria dc = new DAOCategoria();

        public DataTable getTabla()
        {
            return dc.getTablaCategoria();
        }

        public DataTable getTablaCatFiltrada(int Tipo)
        {
            return dc.getTablaCategoriaFiltrada(Tipo);
        }

        public void CargarCategoria(Categorias cat)
        {
            dc.InsertarCategoria(cat);
        }
    }
}
