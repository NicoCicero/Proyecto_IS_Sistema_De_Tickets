using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class UserLoginDAL : DAL
    {

        public (string HashHex, byte[] Salt) ObtenerHashYSalt(string email)
        {
            using (var connection = GetConnection())
            using (var cmd = new SqlCommand("SELECT Usuario_Contraseña, Usuario_Salt FROM Usuario WHERE Usuario_Email = @user", connection))
            {
                cmd.Parameters.AddWithValue("@user", email);
                connection.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        string hashHex = rd.GetString(0);
                        byte[] salt = (byte[])rd[1];
                        return (hashHex, salt);
                    }
                }
            }
            return (null, null);
        }
    }

}
