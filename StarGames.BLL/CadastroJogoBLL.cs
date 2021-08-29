using StarGames.DAL;
using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.BLL
{
    public class CadastroJogoBLL

    {

        CadastroJogoDAL objDAL = new CadastroJogoDAL();

        //Para Cadastrar
        public void CadastrarProduto(CadastroJogoDTO objModelo)
        {
            objDAL.Cadastrar(objModelo);
        }

        //Para Editar
        public void EditarProduto(CadastroJogoDTO objEdita)
        {
            objDAL.Editar(objEdita);
        }

        //Para Excluir

        public void ExcluirProduto(int objExcluir)
        {
            objDAL.Excluir(objExcluir);
        }

        //Para Listar 

        public List<CadastroJogoDTO> ListarProduto()
        {
            return objDAL.Listar();
        }

        public List<FiltrarJogosDTO> FiltrarJogos()
        {
            return objDAL.Filtrar();
        }
        //Para selecionar
        public List<FiltrarJogosDTO> FiltrarJogos(int idConsole)
        {
            return objDAL.Filtrar(idConsole);
        }
        //Para selecionar

        public CadastroJogoDTO SelecionarProduto(int objSeleciona)
        {
            return objDAL.Selecionar(objSeleciona);
        }


    }
}
