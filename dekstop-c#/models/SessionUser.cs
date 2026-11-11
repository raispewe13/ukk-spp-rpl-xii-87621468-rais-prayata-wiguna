using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Mysqlx.Notice.Warning.Types;

namespace dekstop_c_.models
{
    public class SessionUser
    {
        public SessionUser(int idPetugas, string username, string namaPetugas, string level, bool isLoggedIn)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;
            IsLoggedIn = isLoggedIn;
        }

        public int IdPetugas { get; set; }
        public string Username { get; set; }
        public string NamaPetugas { get; set; }
        public string Level { get; set; }
        public bool IsLoggedIn { get; set; }

        

        public static void SetSession(int idPetugas, string username, string namaPetugas, string level, bool isLoggedIn)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level.ToLower();
            IsLoggedIn = true;

        }
        public static void ClearSession(int idPetugas, string username, string namaPetugas, string level, bool isLoggedIn)
        {
            idPetugas = 0;
            username = null;
            namaPetugas = null;
            level = null;
            isLoggedIn = false;
        }



        public static bool IsAdmin()
        {
            return level == "admin";
        }
    }
}
