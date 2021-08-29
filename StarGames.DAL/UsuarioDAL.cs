using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//
using StarGames.DTO;//
using System.IO;//

namespace StarGames.DAL
{
    public class UsuarioDAL : Conexao
    {
        //Cadastrar
        public void Cadastrar(UsuarioDTO objCad)
        {


            try
            {
                Conectar();

                cmd = new SqlCommand("INSERT INTO Usuario (NmUsuario,CpfUsuario,SenhaUsuario,DtNascimento,DsEmail,UrlImgUsuario,TipoUsuario) Values (@v1,@v2,@v3,@v4,@v5,@v6,@v7)", conn);

                cmd.Parameters.AddWithValue("@v1", objCad.NmUsuario);
                cmd.Parameters.AddWithValue("@v2", objCad.CpfUsuario);
                cmd.Parameters.AddWithValue("@v3", objCad.SenhaUsuario);
                cmd.Parameters.AddWithValue("@v4", objCad.DtNascimento);
                cmd.Parameters.AddWithValue("@v5", objCad.DsEmail);
                cmd.Parameters.AddWithValue("@v6", objCad.UrlImgUsuario);
                cmd.Parameters.AddWithValue("@v7", objCad.TipoUsuario);
                cmd.ExecuteNonQuery();


            }

            catch (Exception ex)
            {

                throw new Exception("Erro Ao Cadastrar" + ex);
            }
            finally
            {
                DesConectar();
            }

        }


        //Autenticar

        public UsuarioDTO Autentica(String objUser, String objSenha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NmUsuario=@v1 AND SenhaUsuario=@v2", conn);
                cmd.Parameters.AddWithValue("@v1", objUser);
                cmd.Parameters.AddWithValue("@v2", objSenha);
                dr = cmd.ExecuteReader();

                UsuarioDTO obj = null;//Ponteiro

                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NmUsuario = Convert.ToString(dr["NmUsuario"]);
                    obj.CpfUsuario = Convert.ToString(dr["CpfUsuario"]);
                    obj.SenhaUsuario = Convert.ToString(dr["SenhaUsuario"]);
                    obj.DtNascimento = Convert.ToString(dr["DtNascimento"]);
                    obj.DsEmail = Convert.ToString(dr["DsEmail"]);
                    obj.UrlImgUsuario = Convert.ToString(dr["UrlImgUsuario"]);
                    obj.TipoUsuario = Convert.ToInt32(dr["TipoUsuario"]);
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("usuário nao cadastrado!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }

        //Editar

        public void Editar(UsuarioDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Usuario SET NmUsuario=@v1,Cpfusuario=@v2,SenhaUsuario=@v3,DtNascimento=@v4,DsEmail=@v5,UrlImgUsuario=@v6,TipoUsuario=@v7  WHERE IdUsuario=@v8", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.NmUsuario);
                cmd.Parameters.AddWithValue("@v2", objEdita.CpfUsuario);
                cmd.Parameters.AddWithValue("@v3", objEdita.SenhaUsuario);
                cmd.Parameters.AddWithValue("@v4", objEdita.DtNascimento);
                cmd.Parameters.AddWithValue("@v5", objEdita.DsEmail);
                cmd.Parameters.AddWithValue("@v6", objEdita.UrlImgUsuario);
                cmd.Parameters.AddWithValue("@v7", objEdita.TipoUsuario);
                cmd.Parameters.AddWithValue("@v8", objEdita.IdUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar Usuario!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }


        //Excluir

        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@v8", conn);
                cmd.Parameters.AddWithValue("@v8", objExclui);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

                throw new Exception("Erro ao editar Usuario!! " + ex);
            }
            finally
            {
                DesConectar();
            }

        }
        //Listar

        public List<UsuarioDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario,NmUsuario,CpfUsuario,SenhaUsuario,DtNascimento,DsEmail,UrlImgUsuario,TipoUsuario,DescTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario = IdTipoUsuario", conn);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<UsuarioDTO> Lista = new List<UsuarioDTO>();

                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NmUsuario = dr["NmUsuario"].ToString();
                    obj.CpfUsuario = dr["CpfUsuario"].ToString();
                    obj.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    obj.DtNascimento = dr["DtNascimento"].ToString();
                    obj.DsEmail = dr["DsEmail"].ToString();
                    obj.UrlImgUsuario = dr["UrlImgUsuario"].ToString();
                    obj.TipoUsuario = Convert.ToInt32(dr["TipoUsuario"]);
                    obj.DescTipoUsuario = dr["DescTipoUsuario"].ToString();

                    Lista.Add(obj);

                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Usuario!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }

        public UsuarioDTO Selecionar(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario,NmUsuario,CpfUsuario,SenhaUsuario,DtNascimento,DsEmail,UrlImgUsuario,TipoUsuario,DescTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario = IdTipoUsuario Where IdUsuario=@v8", conn);
                cmd.Parameters.AddWithValue("@v8", objSeleciona);
                dr = cmd.ExecuteReader();

                //Criando Um Ponteiro

                UsuarioDTO obj = new UsuarioDTO();

                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NmUsuario = dr["NmUsuario"].ToString();
                    obj.CpfUsuario = dr["CpfUsuario"].ToString();
                    obj.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    obj.DtNascimento = dr["DtNascimento"].ToString();
                    obj.DsEmail = dr["DsEmail"].ToString();
                    obj.UrlImgUsuario = dr["UrlImgUsuario"].ToString();
                    obj.TipoUsuario = Convert.ToInt32(dr["TipoUsuario"]);
                    obj.DescTipoUsuario = dr["DescTipoUsuario"].ToString();

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Usuario!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }

        public UsuarioDTO SelecionarUsuario(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario,NmUsuario,CpfUsuario,SenhaUsuario,DtNascimento,DsEmail,UrlImgUsuario,TipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario = IdTipoUsuario WHERE IdUsuario = @v1", conn);
                cmd.Parameters.AddWithValue("@v1", objSeleciona);
                dr = cmd.ExecuteReader();

                //Criando Um Ponteiro

                UsuarioDTO obj = new UsuarioDTO();

                if (dr.Read())
                {
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NmUsuario = dr["NmUsuario"].ToString();
                    obj.CpfUsuario = dr["CpfUsuario"].ToString();
                    obj.NmUsuario = dr["NmUsuario"].ToString();
                    obj.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    obj.NmUsuario = dr["NmUsuario"].ToString();
                    obj.DtNascimento = dr["DtNascimento"].ToString();
                    obj.DsEmail = dr["DsEmail"].ToString();
                    obj.UrlImgUsuario = dr["UrlImgUsuario"].ToString();
                    obj.TipoUsuario = Convert.ToInt32(dr["TipoUsuario"]);

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Selecionar Usuário!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }

    }
}
