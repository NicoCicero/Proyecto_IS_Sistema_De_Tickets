using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AuditoriaRepository : DAL
    {
        public void Registrar(string evento, int? usuarioId, string detalle)
        {
            using (var cn = GetConnection())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Auditoria (FechaUtc, UsuarioId, Evento, Detalle)
                VALUES (SYSUTCDATETIME(), @uid, @ev, @det);", cn))
            {
                cmd.Parameters.AddWithValue("@uid", (object)usuarioId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ev", evento);
                cmd.Parameters.AddWithValue("@det", (object)detalle ?? DBNull.Value);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
