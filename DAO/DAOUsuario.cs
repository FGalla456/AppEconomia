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

        public Usuario getTablaUsuarioEspecifico(string Correo, string Contraseña)
        {
            List<Usuario> lista = new List<Usuario>();
            DataTable tabla = ds.ObtenerTabla("Usuario", "select * from Usuario where Correo ='" + Correo + "' and Contrasena ='" + Contraseña + "'");
            Usuario usu = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                DataRow row = tabla.Rows[0];

                usu.IdUsuario1 = Int32.Parse(row["idUsuario"].ToString());
                usu.Correo1 = row["Correo"].ToString();
                usu.Contraseña1 = row["Contrasena"].ToString();
                usu.Nombre1 = row["Nombre"].ToString();
                usu.Apellido1 = row["Apellido"].ToString();
                usu.Nacimiento1 = row["Nacimiento"].ToString();
                usu.Administrador1 = Convert.ToBoolean(Int32.Parse(row["Administrador"].ToString()));
                usu.Estado1 = Convert.ToBoolean(Int32.Parse(row["Estado"].ToString()));
            }
            return usu;
        }


        public void InsertarUsuario(Usuario usu)
        {
            string consulta = "insert into Usuario(Correo,Contrasena,Nombre,Apellido,Nacimiento,Administrador,Estado) " +
                              "values ('" + usu.Correo1 + "','" + usu.Contraseña1 + "','" + usu.Nombre1 + "','" + usu.Apellido1 + "','" + usu.Nacimiento1 + "',0,1)";

            ds.RealizarConsulta(consulta);
        }

    }
}
