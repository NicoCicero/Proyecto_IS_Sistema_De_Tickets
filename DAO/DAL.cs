using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL
    {

        private readonly string mConn;
        
        public DAL()
        {
            mConn = "Data Source=localhost;Initial Catalog=Sistema_De_Tickets;User ID=dev_user;Password=dev_user;TrustServerCertificate=True;";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(mConn);
        }

    }
}
