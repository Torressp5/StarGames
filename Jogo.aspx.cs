using StarGames.BLL;
using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarGame.Sitee
{
    public partial class Jogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idJogo = Convert.ToInt32(Request.QueryString["id"]);

            CadastroJogoBLL objJogoBLL = new CadastroJogoBLL();

            CadastroJogoDTO jogoDTO = objJogoBLL.SelecionarProduto(idJogo);

            lblBreadCrumbGenero.Text = jogoDTO.NomeConsole;
            lblBreadCrumbAlbum.Text = jogoDTO.NmJogo;
            lblTitulo.Text = jogoDTO.NmJogo;
            lblPlataforma.Text = jogoDTO.NomeConsole;
            lblLancamento.Text = jogoDTO.DtLancamento;
            lblDescricao.Text = jogoDTO.DescDistribuidoraJogo;
            imgAlbum.ImageUrl = jogoDTO.UrlImagemAlbum.Replace(@"C:\Users\HomePc\Desktop\StarGames\StarGame.Sitee\Image", "Image");

        }
    }
}