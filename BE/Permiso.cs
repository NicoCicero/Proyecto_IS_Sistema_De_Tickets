using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Permiso
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;     // ej.: "Usuarios.Editar"
        public string Descripcion { get; set; } = string.Empty;

        public override string ToString() => Codigo;
    }
}
