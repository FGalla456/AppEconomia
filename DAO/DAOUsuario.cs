using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DAOUsuario
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            DataTable tabla = ds.ObtenerTabla("Usuario", "select * from Usuario");
            return tabla;
        }

        public void InsertarUsuario(Usuario usu)
        {
            string consulta = "insert into Usuario(Correo,Contrasena,Nombre,Apellido,Nacimiento,Estado) " +
                              "values ('" + usu.Correo1 + "'," + usu.Contraseña1 + "," + usu.Nombre1 + ",'" + usu.Apellido1 + "'," + usu.Nacimiento1 + "1)";

            ds.RealizarConsulta(consulta);
        }

    }
}
