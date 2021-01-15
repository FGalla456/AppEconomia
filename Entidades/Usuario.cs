using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string Correo;
        private string Contraseña;
        private string Nombre;
        private string Apellido;
        private string Nacimiento;
        private bool Estado; 

        public string Correo1 { get => Correo; set => Correo = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Nacimiento1 { get => Nacimiento; set => Nacimiento = value; }
        public bool Estado1 { get => Estado; set => Estado = value; }
    }
}
