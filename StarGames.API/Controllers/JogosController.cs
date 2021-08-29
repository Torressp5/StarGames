using StarGames.BLL;
using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StarGames.API.Controllers
{
    public class JogosController : ApiController
    {


        //Listar Por GET
        [HttpGet]
        [Route("api/Jogos/CONSOLE/{id?}")]
        public IHttpActionResult GetporJogos(int id)
        {
            try
            {

                CadastroJogoBLL objFiltrarjJogos = new CadastroJogoBLL();
                var ListarJogos = objFiltrarjJogos.FiltrarJogos(id);
                return Ok(ListarJogos);
            }
            catch (Exception erro)
            {

                return InternalServerError(erro);
            }
        }



    }
}
