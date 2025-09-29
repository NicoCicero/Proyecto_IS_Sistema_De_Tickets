using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioAdminRepository : DAL
    {
        public List<Rol> ListarRoles()
        {
            var list = new List<Rol>();
            using (var cn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT Rol_Id, Rol_Nombre FROM Rol ORDER BY Rol_Nombre;", cn))
            {
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                        list.Add(new Rol { Id = rd.GetInt32(0), Nombre = rd.GetString(1) });
                }
            }
            return list;
        }
        public bool EmailExiste(string email)
        {
            using (var cn = GetConnection())
            using (var cmd = new SqlCommand("SELECT 1 FROM Usuario WHERE Usuario_Email = @em;", cn))
            {
                cmd.Parameters.AddWithValue("@em", email);
                cn.Open();
                return cmd.ExecuteScalar() != null;
            }
        }

        public int InsertUsuario(string email, string nombre, string hashHex, byte[] salt, bool activo, IEnumerable<int> rolesIds)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        int newId;
                        using (var cmd = new SqlCommand(@"
                            INSERT INTO Usuario
                                (Usuario_Email, Usuario_Nombre, Usuario_Contraseña, Usuario_Salt, HashAlgVer, Activo, IntentosFallidos)
                            VALUES
                                (@em, @nom, @hash, @salt, 'PBKDF2-SHA256-v1', @act, 0);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);", cn, tx))
                        {
                            cmd.Parameters.AddWithValue("@em", email);
                            cmd.Parameters.AddWithValue("@nom", nombre);
                            cmd.Parameters.AddWithValue("@hash", hashHex);
                            cmd.Parameters.AddWithValue("@salt", salt);
                            cmd.Parameters.AddWithValue("@act", activo);
                            newId = (int)cmd.ExecuteScalar();
                        }

                        if (rolesIds != null)
                        {
                            foreach (var rid in rolesIds)
                            {
                                using (var cmd = new SqlCommand(
                                    "INSERT INTO UsuarioRol (Usuario_Id, Rol_Id) VALUES (@uid, @rid);", cn, tx))
                                {
                                    cmd.Parameters.AddWithValue("@uid", newId);
                                    cmd.Parameters.AddWithValue("@rid", rid);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        tx.Commit();
                        return newId;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
