using StarGames.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarGame.Sitee
{
    public partial class Plataforma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //request no parametro da query string
            int idGenero = 5 ;

            CadastroJogoBLL objJogoBLL = new CadastroJogoBLL();
            

            //buscar nome do genero
            string nomeGenero = objJogoBLL.SelecionarProduto (idGenero).NomeConsole;
                rptJogos.DataSource = objJogoBLL.FiltrarJogos(idGenero);
                
            rptJogos.DataBind();

        }
    }
}