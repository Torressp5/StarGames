using StarGames.DAL;
using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.BLL
{
    public class TipoConsolesBLL
    {
        TipoConsoleDAL objDAL = new TipoConsoleDAL();

        public List<TipoConsoleDTO> ListarCategoria()
        {
            return objDAL.Listar();
        }
    }

}
