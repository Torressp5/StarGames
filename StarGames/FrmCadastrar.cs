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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarGames.UI
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void AtualizarGredView(UsuarioBLL objBLL)
        {
            //Atualizando o Gredview
            dgvUsuario.DataSource = objBLL.ListarUsuario();
            dgvUsuario.Update();
            dgvUsuario.Refresh();
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
        public void Limpar()
        {
            //Caixas de texto
            txtID.Text =
            txtNome.Text =
            txtCpf.Text =
            TxtSenha.Text =
            TxtEmail.Text =
            txtData.Text = string.Empty;
            picBox1.Image = null;
            rb1.Checked = false;
            rb2.Checked = false;

            //lIMPANDO os campos



            //desativando o cadastro
            GbxCadastro.Enabled = false;






        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegar o id Sa linha selecionada
            int IdSelecionado = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["IdUsuario"].Value);
            if (IdSelecionado != 0)
            {
                //perguntar se tem certeza
                var Pergunta = MessageBox.Show("Tem certeza que deseja excluir o produto...", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Pergunta == DialogResult.Yes)
                {
                    //Excluir
                    UsuarioBLL objBLL = new UsuarioBLL();
                    objBLL.ExcluirUsuario(IdSelecionado);
                    MessageBox.Show("Produto Excluido com sucesso!");

                    //Atualizando o Gredview
                    dgvUsuario.DataSource = objBLL.ListarUsuario();
                    dgvUsuario.Update();
                    dgvUsuario.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha n atabela abaixo");
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Para pegar o ID Do campo Selecionado
            int IdSelecionado = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["IdUsuario"].Value);

            if (IdSelecionado != 0)
            {
                //Carregar os Dados deste Usuario
                UsuarioBLL objBLL = new UsuarioBLL();
                UsuarioDTO objDTO = objBLL.SelecionarUsuario(IdSelecionado);

                //Preenchendo os campos do form
                txtID.Text = Convert.ToString(objDTO.IdUsuario);
                txtNome.Text = objDTO.NmUsuario;
                txtCpf.Text = objDTO.CpfUsuario;
                TxtSenha.Text = objDTO.SenhaUsuario;
                TxtEmail.Text = objDTO.DsEmail;
                txtData.Text = objDTO.DtNascimento;
                picBox1.ImageLocation = objDTO.UrlImgUsuario;

                //habilitar os Campos
                GbxCadastro.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecioneuma linha na tabela abaixo!");
                return;
            }
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {
            UsuarioBLL objBLL = new UsuarioBLL();

            AtualizarGredView(objBLL);



        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            GbxCadastro.Enabled = true;
            txtNome.Focus();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //Validação De Formulario
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Nome do Usuario é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCpf.Text.Trim() == "")
            {
                MessageBox.Show("Campo CPF do Usuario é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Campo Senha do Usuario é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Campo Email do Usuario é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtData.Text.Trim() == "")
            {
                MessageBox.Show("Campo Data do Usuario é Obrigatorio!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            //intanciado o DTO de Usuario
            UsuarioDTO objCad = new UsuarioDTO();



            objCad.NmUsuario = txtNome.Text;
            objCad.CpfUsuario = txtCpf.Text;
            objCad.SenhaUsuario = TxtSenha.Text;
            objCad.DsEmail = TxtEmail.Text;
            objCad.DtNascimento = txtData.Text;



            //Salvando a URL da Imagem
            if (picBox1.Image != null)
            {
                string nomeImg = txtNome.Text + ".jpg";
                string pasta = @"C:\Users\HomePc\Desktop\StarGames\StarGames\Imagens";
                string caminhoImg = Path.Combine(pasta, nomeImg);
                objCad.UrlImgUsuario = caminhoImg;



                //Salvando a Imagem
                Image a = picBox1.Image;
                a.Save(caminhoImg);



            }
            else
            {
                MessageBox.Show("Selecione uma Imagem!!");
                return;



            }



            //Alertando Raidios Buttons nçao selecionados
            if ((!rb1.Checked) && (!rb2.Checked))
            {
                MessageBox.Show("Escolha uma Opção!!");
                return;
            }
            //Atribuindo Radios Buttons
            if (rb1.Checked)
            {
                objCad.TipoUsuario = 1;
            }
            else if (rb2.Checked)
            {
                objCad.TipoUsuario = 2;
            }



            //Instanciando o BLL no Produto
            UsuarioBLL objBLL = new UsuarioBLL();



            if (txtID.Text == "")
            {
                objBLL.CadastrarUsuario(objCad);
                MessageBox.Show("Usuário Cadastrado Com Sucesso");
                //Atualizando o Gredview
                dgvUsuario.DataSource = objBLL.ListarUsuario();
                dgvUsuario.Update();
                dgvUsuario.Refresh();
            }
            else
            {
                //Alterar
                objCad.IdUsuario = Convert.ToInt32(txtID.Text);
                objBLL.Editar(objCad);
                MessageBox.Show("Usuário alterado Com sucesso");



                //Atualizando o Gredview
                dgvUsuario.DataSource = objBLL.ListarUsuario();
                dgvUsuario.Update();
                dgvUsuario.Refresh();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Gbox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Selecione uma opção");
        }

       

        private void picBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
