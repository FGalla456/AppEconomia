using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;

namespace Negocio
{
    public class N_Pais
    {
        DAOPais dp = new DAOPais();

        public DataTable getTablaPais() 
        {
            return dp.getTablaCategoria();
        }

        public void CargarPais(Paises pais) 
        {
            dp.InsertarPais(pais);
        }


    }
}
