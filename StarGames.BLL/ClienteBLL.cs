using StarGames.DAL;
using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.BLL
{
    public class ClienteBLL
    {
        ClienteDAL objDal = new ClienteDAL();
        public void CadastrarCliente(ClienteDTO objModelo)
        {
            objDal.Cadastrar(objModelo);
        }
        public void EditarCliente(ClienteDTO objEdita)
        {
            objDal.Editar(objEdita);
        }
        public void ExcluirCliente(int objExclui)
        {
            objDal.Excluir(objExclui);
        }
        public List<ClienteDTO> ListarCliente()
        {
            return objDal.Listar();
        }
        public ClienteDTO SelecionarCliente(int objSeleciona)
        {
            return objDal.Selecionar(objSeleciona);
        }
    }
}
