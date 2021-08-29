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
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            //Montabdo conteudo da mensagem (dto)
            EmailDTO objDTO = new EmailDTO();

            objDTO.NomeRemetente = txtNome.Text;
            objDTO.EmailRemetente = txtEmail.Text;
            objDTO.NomeDestinatario = "SITE MUSICAOS";
            objDTO.EmailDestinatario = "leonardofran10@gmail.com";
            objDTO.Assunto = "Contato via Site";
            objDTO.Mensagem = txtMensagem.Text + " - NOME: " + txtNome.Text + " - FONE: " + txtTelefone.Text;

            //Instaciar a classe que envia o email
            EmailBLL objEmail = new EmailBLL();
            try
            {
                objEmail.Enviar(objDTO);

                lblMensagem.Text = "E-mail Enviado com Sucesso!";

                txtNome.Text =
                    txtMensagem.Text =
                    txtEmail.Text =
                    txtTelefone.Text = "";

            }
            catch
            {

                lblMensagem.Text = "Erro ao enviar E-mail tente novamente mais tarde!";

            }
        }
    }
}