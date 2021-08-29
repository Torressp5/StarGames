using StarGames.BLL;
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
    public partial class FrmMainUser : Form
    {
        public FrmMainUser()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //botoes
        private void Relátorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio obj = new FrmRelatorio();
            obj.ShowDialog();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMainUser_Load(object sender, EventArgs e)
        {
            lblSession.Text = "Seja bem vindo " + Session.NmUsuario + " ao sistema Canopus! Início de sua sessão: " + DateTime.Now.ToString();
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }
    }
}
