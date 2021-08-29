using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarGames.DAL;//
using StarGames.DTO;//

namespace StarGames.BLL
{
    public class Usuario2BLL
    {
        UsuarioDAL objDAL = new UsuarioDAL();

        public List<UsuarioDTO> ListarUsuario()
        {
            return objDAL.Listar();
        }
    }
    public class UsuarioBLL
    {
        UsuarioDAL objBLL = new UsuarioDAL();

        //para cadastrar usuarios

        public void CadastrarUsuario(UsuarioDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Para autenticar

        public UsuarioDTO AutenticaUser(String ObjUser, String objSenha)
        {
            UsuarioDTO user = objBLL.Autentica(ObjUser, objSenha);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Problema ao autenticar Usuário");
            }
        }

        //Para Editar
        public void Editar(UsuarioDTO objEdita)
        {
            objBLL.Editar(objEdita);
        }

        // PAra Excluir

        public void ExcluirUsuario(int objExclui)
        {
            objBLL.Excluir(objExclui);
        }

        //para Listar

        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

        //Para Selecionar 

        public UsuarioDTO SelecionarUsuario(int objSeleciona)
        {
            return objBLL.Selecionar(objSeleciona);
        }
    }
}
