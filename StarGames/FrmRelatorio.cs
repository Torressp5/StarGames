using DGVPrinterHelper;
using StarGames.BLL;
using StarGames.DTO;
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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblTitulo.Text;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(dgv1);
        }

        private void btnExibirRegistro_Click(object sender, EventArgs e)
        {
            //btnExibir Registros
            CadastroJogoBLL objModelo = new CadastroJogoBLL();
            dgv1.DataSource = objModelo.ListarProduto();

            //Cabeçalho
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dgv1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
