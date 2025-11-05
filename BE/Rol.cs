using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Rol
    { /// <summary>
      /// Rol de alto nivel (p. ej. Admin, Operador, Soporte).
      /// </summary>

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public override string ToString() => Nombre;
    }
}

