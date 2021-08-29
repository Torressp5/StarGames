using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarGames.DAL;
using StarGames.DTO;

namespace StarGames.BLL
{
    public class NovidadesJogoBLL
    {
        NovidadesJogoDAL objDAL = new NovidadesJogoDAL();

        public List<NovidadesJogosDTO> ListarCategoria()
        {
            return objDAL.Listar();
        }
    }
}
