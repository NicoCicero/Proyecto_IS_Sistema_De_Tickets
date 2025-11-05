using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AdminSeedHelper
    {
        /// <summary>
        /// Genera Salt+Hash PBKDF2 para la contraseña y devuelve el SQL para insertar el usuario.
        /// Usalo una sola vez y copiá el SQL resultante a SSMS.
        /// </summary>
        public static string BuildInsertAdminSql(string email, string nombre, string passwordPlano)
        {
            var crypto = CryptoManager.Instancia;
            byte[] salt = crypto.GenerateSalt(16);
            string hashHex = crypto.HashPasswordPBKDF2(passwordPlano, salt);

            string saltHexForSql = "0x" + BitConverter.ToString(salt).Replace("-", "");
            string sql = $@"
            INSERT INTO Usuario (Usuario_Email, Usuario_Nombre, Usuario_Contraseña, Usuario_Salt, HashAlgVer, Activo)
            VALUES ('{email.Replace("'", "''")}', '{nombre.Replace("'", "''")}', '{hashHex}', {saltHexForSql}, 'PBKDF2-SHA256-v1', 1);

            /* Luego asigná el rol de Administrador (ajustá los IDs reales):
            INSERT INTO UsuarioRol (Usuario_Id, Rol_Id) VALUES (<Usuario_Id_creado>, <RolId_Admin>);
            */".Trim();

            return sql;
        }
        public static string BuildUpdateAdminSql(string email, string nuevaPasswordPlano)
        {
            var crypto = CryptoManager.Instancia;
            byte[] salt = crypto.GenerateSalt(16);
            string hashHex = crypto.HashPasswordPBKDF2(nuevaPasswordPlano, salt);
            string saltHexForSql = "0x" + BitConverter.ToString(salt).Replace("-", "");

            return $@"
UPDATE Usuario
SET Usuario_Contraseña = '{hashHex}',
    Usuario_Salt       = {saltHexForSql},
    HashAlgVer         = 'PBKDF2-SHA256-v1',
    IntentosFallidos   = 0,
    BloqueadoHasta     = NULL
WHERE Usuario_Email = '{email.Replace("'", "''")}';
";
        }
    }
}
