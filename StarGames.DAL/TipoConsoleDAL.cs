using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.DAL
{
    public  class TipoConsoleDAL:Conexao
    {
        public List<TipoConsoleDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdConsole,NomeConsole FROM CONSOLE ORDER BY NomeConsole", conn);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<TipoConsoleDTO> Lista = new List<TipoConsoleDTO>();

                while (dr.Read())
                {
                    TipoConsoleDTO obj = new TipoConsoleDTO();
                    obj.IdConsole = Convert.ToInt32(dr["IdConsole"]);
                    obj.NomeConsole = dr["NomeConsole"].ToString();
                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Console!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }
        public TipoConsoleDTO Selecionar(int idConsole)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM CONSOLE WHERE IdConsole=@v1", conn);
                cmd.Parameters.AddWithValue("@v1", idConsole);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                TipoConsoleDTO obj = new TipoConsoleDTO();

                if (dr.Read())
                {
                    obj.IdConsole = Convert.ToInt32(dr["IdConsole"]);
                    obj.NomeConsole = dr["NomeConsole"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Console!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }
    }
}
