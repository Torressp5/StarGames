using StarGames.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.DAL
{
    public class NovidadesJogoDAL:Conexao
    {
        public List<NovidadesJogosDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdNovidade,NomeNovidade FROM NOVIDADE ORDER BY NomeNovidade", conn);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<NovidadesJogosDTO> Lista = new List<NovidadesJogosDTO>();

                while (dr.Read())
                {
                    NovidadesJogosDTO obj = new NovidadesJogosDTO();
                    obj.IdNovidade = Convert.ToInt32(dr["IdNovidade"]);
                    obj.NomeNovidade = dr["NomeNovidade"].ToString();
                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Categoria!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }
    }
} 
