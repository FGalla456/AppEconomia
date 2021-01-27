using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gastos
    {
        string Fecha;
        private int idCategoria;
        private float Monto;
        private string Descripcion;
        private bool Estado;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public float Monto1 { get => Monto; set => Monto = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public bool Estado1 { get => Estado; set => Estado = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
    }
}
