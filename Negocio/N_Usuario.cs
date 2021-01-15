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
    public class N_Usuario
    {

        DAOUsuario du = new DAOUsuario();

        public void CrearUsuario(Usuario usu) 
        {
            du.InsertarUsuario(usu);
        }

        public Usuario VerificarUsuario(string Correo,string Contraseña) 
        {
           return du.getTablaUsuarioEspecifico(Correo,Contraseña);
        }

    }
}
