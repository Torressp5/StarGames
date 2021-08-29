using System;
using StarGames.DTO;
using StarGames.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarGame.Sitee
{
    public partial class XboxOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //request no parametro da query string
            int idGenero = 4;

            CadastroJogoBLL objJogoBLL = new CadastroJogoBLL();


            //buscar nome do genero
            string nomeGenero = objJogoBLL.SelecionarProduto(idGenero).NomeConsole;
            rptJogos.DataSource = objJogoBLL.FiltrarJogos(idGenero);
        
            rptJogos.DataBind();
        }
    }
}