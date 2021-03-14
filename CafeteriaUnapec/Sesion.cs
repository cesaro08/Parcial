using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaUnapec
{
    class Sesion
    {
        public static int idTipo,id;
        public static string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public int Id { get => id; set => id = value; }
    }
}
