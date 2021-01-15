using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Negocio
{
    public class N_Usuario
    {

        DAOUsuario du = new DAOUsuario();

        public void CrearUsuario(Usuario usu) 
        {
            du.InsertarUsuario(usu);
        }

    }
}
