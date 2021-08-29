using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.DAL
{
    public class ClienteDAL : Conexao
    {
        //Inserir - Create
        public void Cadastrar(ClienteDTO objCad)
        {


            try
            {
                Conectar();

                cmd = new SqlCommand("INSERT INTO Cliente (NmCliente,NumCpf,DsEmail,NumTelefone,DsLougradouro,DsNumero,DsComplemento,NmBairro,NmCidade,NmEstado," +
                    "NumCep,DtCadastro) Values (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12)", conn);

                cmd.Parameters.AddWithValue("@v1", objCad.Nome);
                cmd.Parameters.AddWithValue("@v2", objCad.Cpf);
                cmd.Parameters.AddWithValue("@v3", objCad.Email);
                cmd.Parameters.AddWithValue("@v4", objCad.Telefone);
                cmd.Parameters.AddWithValue("@v5", objCad.Logradouro);
                cmd.Parameters.AddWithValue("@v6", objCad.Numero);
                cmd.Parameters.AddWithValue("@v7", objCad.Complemento);
                cmd.Parameters.AddWithValue("@v8", objCad.Bairro);
                cmd.Parameters.AddWithValue("@v9", objCad.Cidade);
                cmd.Parameters.AddWithValue("@v10", objCad.Estado);
                cmd.Parameters.AddWithValue("@v11", objCad.Cep);
                cmd.Parameters.AddWithValue("@v12", objCad.DataCadastro);
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

        //Editar - Update
        public void Editar(ClienteDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Cliente SET NmCliente = @v1,NumCpf = @v2,DsEmail = @v3,NumTelefone = @v4,DsLougradouro = @v5,DsNumero = @v6,DsComplemento = @v7,NmBairro = @v8,NmCidade = @v9,NmEstado = @v10,NumCep = @v11 WHERE IdCliente = @v13", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.Nome);
                cmd.Parameters.AddWithValue("@v2", objEdita.Cpf);
                cmd.Parameters.AddWithValue("@v3", objEdita.Email);
                cmd.Parameters.AddWithValue("@v4", objEdita.Telefone);
                cmd.Parameters.AddWithValue("@v5", objEdita.Logradouro);
                cmd.Parameters.AddWithValue("@v6", objEdita.Numero);
                cmd.Parameters.AddWithValue("@v7", objEdita.Complemento);
                cmd.Parameters.AddWithValue("@v8", objEdita.Bairro);
                cmd.Parameters.AddWithValue("@v9", objEdita.Cidade);
                cmd.Parameters.AddWithValue("@v10", objEdita.Estado);
                cmd.Parameters.AddWithValue("@v11", objEdita.Cep);
                cmd.Parameters.AddWithValue("@v13", objEdita.IdCliente);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro Ao Editar !!" + ex.Message);
            }
            finally
            {
                DesConectar();
            }
        }

        //Deletar(Excluir) - Delete
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Cliente WHERE IdCliente=13", conn);
                cmd.Parameters.AddWithValue("@v13", objExclui);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro Ao Excluir !!" + ex.Message);
            }
            finally
            {
                DesConectar();
            }
        }

        //Listar - Read
        public List<ClienteDTO> Listar()
        {
            try
            {
                Conectar();

                cmd = new SqlCommand("SELECT * FROM Cliente ORDER BY IdCliente", conn);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<ClienteDTO> Lista = new List<ClienteDTO>();

                while (dr.Read())
                {
                    ClienteDTO obj = new ClienteDTO();
                    obj.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    obj.Nome = dr["NmCliente"].ToString();
                    obj.Cpf = dr["NumCpf"].ToString();
                    obj.Email = dr["DsEmail"].ToString();
                    obj.Telefone = dr["NumTelefone"].ToString();
                    obj.Logradouro = dr["DsLougradouro"].ToString();
                    obj.Numero = Convert.ToInt32(dr["DsNumero"]);
                    obj.Complemento = dr["DsComplemento"].ToString();
                    obj.Bairro = dr["NmBairro"].ToString();
                    obj.Cidade = dr["NmCidade"].ToString();
                    obj.Estado = dr["NmEstado"].ToString();
                    obj.Cep = dr["NumCep"].ToString();
                    obj.DataCadastro = Convert.ToDateTime(dr["DtCadastro"]);


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

        //Filtrar 

        public ClienteDTO Selecionar(int objSeleciona)
        {
            try
            {
                Conectar();

                cmd = new SqlCommand("SELECT * FROM Cliente WHERE IdCliente = @v13", conn);
                cmd.Parameters.AddWithValue("@v13", objSeleciona);
                dr = cmd.ExecuteReader();


                ClienteDTO obj = new ClienteDTO();

                if (dr.Read())
                {
                    obj.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    obj.Nome = dr["NmCliente"].ToString();
                    obj.Cpf = dr["NumCpf"].ToString();
                    obj.Email = dr["DsEmail"].ToString();
                    obj.Telefone = dr["NumTelefone"].ToString();
                    obj.Logradouro = dr["DsLougradouro"].ToString();
                    obj.Numero = Convert.ToInt32(dr["DsNumero"]);
                    obj.Complemento = dr["DsComplemento"].ToString();
                    obj.Bairro = dr["NmBairro"].ToString();
                    obj.Cidade = dr["NmCidade"].ToString();
                    obj.Estado = dr["NmEstado"].ToString();
                    obj.Cep = dr["NumCep"].ToString();
                    obj.DataCadastro = Convert.ToDateTime(dr["DtCadastro"]);
                }
                return obj;
            }

            catch (Exception ex)
            {

                throw new Exception("Erro Ao Filtrar !!" + ex.Message);
            }

            finally
            {
                DesConectar();
            }
        }
    }
}
