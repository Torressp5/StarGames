using StarGames.BLL;
using StarGames.DTO;
using StarGames.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarGames
{
    public partial class FrmCadastrarJogos : Form
    {
        public FrmCadastrarJogos()
        {
            InitializeComponent();
        }

        private void FrmCadastrarJogos_Load(object sender, EventArgs e)
        {
            CadastroJogoBLL objBLL = new CadastroJogoBLL();

            AtualizarGredView(objBLL);

            //carregando Categorias
            TipoConsolesBLL catConsoleBLL = new TipoConsolesBLL();
            cboConsole.DataSource = catConsoleBLL.ListarCategoria();
            cboConsole.ValueMember = "IdConsole";
            cboConsole.DisplayMember = "NomeConsole";
            cboConsole.Text = "Selecione uma opção";

            //carregando Categorias
            NovidadesJogoBLL categoriasBLL = new NovidadesJogoBLL();
            cboNovidade.DataSource = categoriasBLL.ListarCategoria();
            cboNovidade.ValueMember = "IdNovidade";
            cboNovidade.DisplayMember = "NomeNovidade";
            cboNovidade.Text = "Selecione uma opção";
        }

        private void AtualizarGredView(CadastroJogoBLL objBLL)
        {
            //Atualizando o Gredview
            dgvProdutos.DataSource = objBLL.ListarProduto();
            dgvProdutos.Update();
            dgvProdutos.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            GbxCadastro.Enabled = true;
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
        private void LimparForm()
        {
            //lIMPANDO os campos
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtData.Text = string.Empty;
            txtGenero.Text = string.Empty;
            txtEstilo.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtDistribuidora.Text = string.Empty;
            picBox1.Image = null;
            cboConsole.SelectedValue = string.Empty;
            cboConsole.Text = "Selecione uma opção";
            cboNovidade.SelectedValue = string.Empty;
            cboNovidade.Text = "Selecione uma opção";

            //desativando o cadastro
            GbxCadastro.Enabled = false;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //Validação De Formulario
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Nome do Jogo é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEstilo.Text.Trim() == "")
            {
                MessageBox.Show("Campo Estilo do Jogo é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDistribuidora.Text.Trim() == "")
            {
                MessageBox.Show("Campo Destribuidora do Jogo é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboConsole.SelectedIndex == 0)
            {
                MessageBox.Show("Campo Console do Produto é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboNovidade.SelectedIndex == 0)
            {
                MessageBox.Show("Campo Novidade do Produto é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //intanciado o DTO de produto
            CadastroJogoDTO objCad = new CadastroJogoDTO();

            objCad.NmJogo = txtNome.Text;
            objCad.DtLancamento = txtData.Text;
            objCad.DescGenero = txtGenero.Text;
            objCad.TipoDeJogo = txtEstilo.Text;
            objCad.CONSOLE = Convert.ToInt32(cboConsole.SelectedValue);
            objCad.NOVIDADE = Convert.ToInt32(cboNovidade.SelectedValue);
            objCad.VlPrecos = txtPreco.Text.Replace("R$", "");
            objCad.DescDistribuidoraJogo = txtDistribuidora.Text;

            //Salvando a URL da Imagem
            if (picBox1.Image != null)
            {
                string nomeImg = Path.GetFileName(picBox1.ImageLocation);
                string pasta = @"https://stargamesitee.azurewebsites.net/Image/";
                string caminhoImg = Path.Combine(pasta, nomeImg);
                objCad.UrlImagemAlbum = caminhoImg;



                //Salvando a Imagem
                Image a = picBox1.Image;
                //a.Save(caminhoImg);
                UploadImagem(picBox1, PBRoniSolution);


            }
            else
            {
                MessageBox.Show("Selecione uma Imagem!!");
                return;
            }



            //Instanciando o BLL no Produto
            CadastroJogoBLL objBLL = new CadastroJogoBLL();

            if (txtID.Text == "")
            {
                objBLL.CadastrarProduto(objCad);
                MessageBox.Show("Jogo Cadastrado Com Sucesso");
            }
            else
            {
                //Alterar
                objCad.IdJogo = Convert.ToInt32(txtID.Text);
                objBLL.EditarProduto(objCad);
                MessageBox.Show("Jogo alterado Com sucesso");
            }
            AtualizarGredView(objBLL);
            LimparForm();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Para pegar o ID Do campo Selecionado
            int IdSelecionado = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["IdJogo"].Value);

            if (IdSelecionado != 0)
            {
                //Carregar os Dados deste Produto
                CadastroJogoBLL objBLL = new CadastroJogoBLL();
                CadastroJogoDTO objDTO = objBLL.SelecionarProduto(IdSelecionado);

                //Preenchendo os campos do form
                txtID.Text = Convert.ToString(objDTO.IdJogo);
                txtNome.Text = objDTO.NmJogo;
                txtData.Text = objDTO.DtLancamento;
                txtGenero.Text = objDTO.DescGenero;
                txtEstilo.Text = objDTO.TipoDeJogo;
                txtPreco.Text = objDTO.VlPrecos;
                txtDistribuidora.Text = objDTO.DescDistribuidoraJogo;
                picBox1.ImageLocation = objDTO.UrlImagemAlbum;
                cboConsole.SelectedValue = objDTO.CONSOLE;
                cboNovidade.SelectedValue = objDTO.NOVIDADE;

                //habilitar os Campos
                GbxCadastro.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione uma linha na tabela abaixo!");
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegar o id Sa linha selecionada
            int IdSelecionado = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["IdJogo"].Value);
            if (IdSelecionado != 0)
            {
                //perguntar se tem certeza
                var Pergunta = MessageBox.Show("Tem certeza que deseja excluir o produto...", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Pergunta == DialogResult.Yes)
                {
                    //Excluir
                    CadastroJogoBLL objBLL = new CadastroJogoBLL();
                    objBLL.ExcluirProduto(IdSelecionado);
                    MessageBox.Show("Produto Excluido com sucesso!");
                    AtualizarGredView(objBLL);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha n atabela abaixo");
                return;
            }
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal Valor = Convert.ToDecimal(txtPreco.Text.Replace("R$", ""));
                txtPreco.Text = Valor.ToString("C2");
            }
            catch
            {

                txtPreco.Text = "";
            }
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            txtPreco.Text = txtPreco.Text.Replace("R$", "");
        }

       

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            //Carregando Imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String img = dialog.FileName.ToString();
                picBox1.ImageLocation = img;
            }
        }

        private void UploadImagem(PictureBox pictureBox, ProgressBar progressBar)
        {
            //credenciais ftp
            var urlFtp = "ftp://waws-prod-cq1-031.ftp.azurewebsites.windows.net/site/wwwroot/Image/";
            var userName = @"StarGameSitee\$StarGameSitee";
            var passWord = "fk7yYzpo89hq7Dci2Ztfvbwezdxk4he2AECGt4qG6gMTfj1iyk1L7bhbKWih";

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(urlFtp + Path.GetFileName(pictureBox.ImageLocation));
            request.Credentials = new NetworkCredential(userName, passWord);
            request.Method = WebRequestMethods.Ftp.UploadFile;



            using (Stream fileStream = File.OpenRead(pictureBox.ImageLocation))
            using (Stream ftpStream = request.GetRequestStream())
            {
                progressBar.Invoke((MethodInvoker)delegate { progressBar.Maximum = (int)fileStream.Length; });



                byte[] buffer = new byte[10240];
                int read;
                while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ftpStream.Write(buffer, 0, read);
                    progressBar.Invoke((MethodInvoker)delegate { progressBar.Value = (int)fileStream.Position; });
                }
            }
        }
    }
    
}
