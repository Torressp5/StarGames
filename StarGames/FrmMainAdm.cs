using StarGames.BLL;
using StarGames.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarGames
{
    public partial class FrmMainAdm : Form
    {
        public FrmMainAdm()
        {
            InitializeComponent();
        }
        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }
        private void FrmMainAdm_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Seja bem vindo " + Session.NmUsuario + " ao sistema Canopus! Início de sua sessão: " + DateTime.Now.ToString();
        }
        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCadastrarJogos obj = new FrmCadastrarJogos();
            obj.ShowDialog();
        }
        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void Cadastrar_Click_1(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }

        private void Calculadora_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void Sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Jogo_Click(object sender, EventArgs e)
        {
            FrmCadastrarJogos obj = new FrmCadastrarJogos();
            obj.ShowDialog();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }

        private void usuárioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }
    }
}
