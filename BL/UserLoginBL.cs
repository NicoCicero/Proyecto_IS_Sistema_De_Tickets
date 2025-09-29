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
        private static UserLoginBL _instancia;
        private UserLoginBL() { }

        public static UserLoginBL Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new UserLoginBL();
                return _instancia;
            }
        }

        private readonly UserLoginDAL _userLoginDAL = new UserLoginDAL();
        private readonly CryptoManager _crypto = CryptoManager.Instancia;

        public bool LoginUser(string user, string password)
        {
            var hs = _userLoginDAL.ObtenerHashYSalt(user);
            if (hs.HashHex == null) return false;               // usuario no existe

            string hashIngresado = _crypto.HashPasswordPBKDF2(password, hs.Salt);
            return _crypto.ConstantTimeEquals(hs.HashHex, hashIngresado);
        }

    }
}
