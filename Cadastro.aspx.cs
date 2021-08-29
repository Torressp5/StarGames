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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastar_Click(object sender, EventArgs e)
        {

            try
            {
                ClienteDTO objDTO = new ClienteDTO();
                ClienteBLL objBLL = new ClienteBLL();

                objDTO.Nome = txtNome.Text;
                objDTO.Cpf = txtCep.Text;
                objDTO.Email = txtEmail.Text;
                objDTO.Telefone = txtTelefone.Text;
                objDTO.Logradouro = txtEndereco.Text;
                objDTO.Numero = Convert.ToInt32(txtNumero.Text);
                objDTO.Complemento = txtComplemento.Text;
                objDTO.Bairro = txtBairro.Text;
                objDTO.Cidade = txtCidade.Text;
                objDTO.Estado = txtEstado.Text;
                objDTO.Cep = txtCep.Text;
                objDTO.DataCadastro = DateTime.Now;



                objBLL.CadastrarCliente(objDTO);
                //Redirecionando a pagina para a de confimação
                Response.Redirect("Confirmacao.aspx");
            }
            catch
            {

                lblMensagem.Text = "Ocorreu um erro ao enviar o cadastro. tente novamente mais tarde ou entre em contato" +
                    "<href=Contato.aspx>Contato com a empresa.</a>";

            }



        }
    }
}