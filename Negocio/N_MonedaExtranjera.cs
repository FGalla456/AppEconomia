using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Negocio
{
    public class N_MonedaExtranjera
    {
        DAOMonedaExtranjera dme = new DAOMonedaExtranjera();
        public void CargarValorMonExt(MonedaExtranjera me)
        {
            dme.InsertarValorMonExt(me);
        }

    }
}
