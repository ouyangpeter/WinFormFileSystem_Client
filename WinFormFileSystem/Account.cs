using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFileSystem
{
    class Account
    {
        private static string uname;
        private static string passwd;

        public static void SetUname(string _uname)
        {
            uname = _uname;
        }
        public static void SetPasswd(string _passwd)
        {
            passwd = _passwd;
        }

        public static string GetUname()
        {
            return uname;
        }
        public static string GetPasswd()
        {
            return passwd;
        }
   
    }
}
