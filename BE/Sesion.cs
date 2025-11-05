using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{ 
    /// <summary>Sesión de usuario para controlar login/logout y auditoría.</summary>
    public class Sesion
    {
        public Guid Id { get; set; }             // Identificador único de la sesión
        public int UsuarioId { get; set; }       // FK a Usuario
        public DateTime InicioUtc { get; set; }  // Inicio de sesión (UTC)
        public DateTime? FinUtc { get; set; }    // Fin de sesión (UTC), null si sigue activa

        // Metadatos opcionales
        public string Ip { get; set; }           // puede ser null en C# 7.3
        public string UserAgent { get; set; }    // puede ser null en C# 7.3
    }
    
}
