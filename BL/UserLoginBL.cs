using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;


namespace BL
{
    public class UserLoginBL
    {

        UserLoginDAL UserLoginDAL = new UserLoginDAL();
        public bool LoginUser(string user, string password)
        {
            var (hashGuardado, salt) = UserLoginDAL.ObtenerHashYSalt(user);
            if (hashGuardado == null) return false;
            string hashIngresado = PasswordHasher.HashPasswordWithSalt(password, salt);
            return string.Equals(hashGuardado, hashIngresado, StringComparison.Ordinal);
        }
    }
}
