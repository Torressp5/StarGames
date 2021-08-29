using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.BLL
{
    public static class Session
    {
        private static string _nomeUsuario;

        public static string NmUsuario
        {
            get { return Session._nomeUsuario; }
            set { Session._nomeUsuario = value; }
        }
    }
}
