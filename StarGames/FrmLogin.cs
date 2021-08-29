using StarGames.BLL;
using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StarGames
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            //SppleshScreen
            Thread t = new Thread(new ThreadStart(StartForms));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

        }
        public void StartForms()
        {
            Application.Run(new FrmSplashScreen());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Pegando informações digitada pelo Usuario
                string objUser = TxtUsuario.Text;
                string objSenha = TxtSenha.Text;

                //Instanciando  Objeto DTO
                UsuarioDTO objModelo = new UsuarioDTO();
                UsuarioBLL objValida = new UsuarioBLL();
                objModelo = objValida.AutenticaUser(objUser, objSenha);
                if (objModelo != null)
                {
                    switch (objModelo.TipoUsuario)
                    {
                        case 1:
                            Session.NmUsuario = TxtUsuario.Text.Trim();
                            FrmMainAdm obj = new FrmMainAdm();
                            obj.Show();
                            this.Visible = false;
                            break;
                        case 2:
                            Session.NmUsuario = TxtUsuario.Text.Trim();
                            FrmMainUser obj2 = new FrmMainUser();
                            obj2.Show();
                            this.Visible = false;
                            break;

                    }
                }
                else
                {
                    MessageBox.Show("Deu Problema denovo!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuário não Cadastrado !!" + ex);
            }
        }
    }
}
