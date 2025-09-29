using BE;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserAdminService
    {
        private static readonly Lazy<UserAdminService> _inst =
            new Lazy<UserAdminService>(() => new UserAdminService());
        public static UserAdminService Instancia => _inst.Value;

        private readonly UsuarioAdminRepository _repo = new UsuarioAdminRepository();
        private readonly CryptoManager _crypto = CryptoManager.Instancia;

        private UserAdminService() { }

        public List<Rol> ListarRoles()
        {
            if (!SessionManager.Instancia.TieneRol("Administrador"))
                throw new UnauthorizedAccessException("Solo un Administrador puede registrar usuarios.");
            return _repo.ListarRoles();
        }

        public int CrearUsuario(string email, string nombre, string passwordPlano, bool activo, IEnumerable<int> rolesIds)
        {
            if (!SessionManager.Instancia.TieneRol("Administrador"))
                throw new UnauthorizedAccessException("Solo un Administrador puede registrar usuarios.");

            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email requerido");
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre requerido");
            if (string.IsNullOrEmpty(passwordPlano) || passwordPlano.Length < 8)
                throw new ArgumentException("La contraseña debe tener al menos 8 caracteres");
            if (rolesIds == null || !rolesIds.Any())
                throw new ArgumentException("Selecciona al menos un rol");

            if (_repo.EmailExiste(email))
                throw new InvalidOperationException("Ya existe un usuario con ese email.");

            var salt = _crypto.GenerateSalt(16);
            var hash = _crypto.HashPasswordPBKDF2(passwordPlano, salt);

            return _repo.InsertUsuario(email, nombre, hash, salt, activo, rolesIds);
        }
    }
}
