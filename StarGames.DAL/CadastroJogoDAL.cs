using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarGames.DTO;
using System.Data.SqlClient;


namespace StarGames.DAL
{
    public class CadastroJogoDAL : Conexao
    {
        //Cadastrar Jogos
        public void Cadastrar(CadastroJogoDTO objCad)
        {
            try
            {
                Conectar();

                cmd = new SqlCommand("Insert Into Jogo(NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,UrlImagemAlbum,CONSOLE,NOVIDADE)Values (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9)", conn);

                cmd.Parameters.AddWithValue("@v1", objCad.NmJogo);
                cmd.Parameters.AddWithValue("@v2", objCad.DtLancamento);
                cmd.Parameters.AddWithValue("@v3", objCad.DescGenero);
                cmd.Parameters.AddWithValue("@v4", objCad.TipoDeJogo);
                cmd.Parameters.AddWithValue("@v5", objCad.VlPrecos);
                cmd.Parameters.AddWithValue("@v6", objCad.DescDistribuidoraJogo);
                cmd.Parameters.AddWithValue("@v7", objCad.UrlImagemAlbum);
                cmd.Parameters.AddWithValue("@v8", objCad.CONSOLE);
                cmd.Parameters.AddWithValue("@v9", objCad.NOVIDADE);
                cmd.ExecuteNonQuery();


            }

            catch (Exception ex)
            {

                throw new Exception("Erro Ao Cadastrar Jogo" + ex);
            }
            finally
            {
                DesConectar();
            }
        }

        //Editar Jogos

        public void Editar(CadastroJogoDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Jogo SET NmJogo=@v1,DtLancamento=@v2,DescGenero=@v3,TipoDeJogo=@v4,VlPrecos=@v5,DescDistribuidoraJogo=@v6,UrlImagemAlbum=@v7,CONSOLE=@v8,NOVIDADE=@v9 WHERE IdJogo=@v10", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.NmJogo);
                cmd.Parameters.AddWithValue("@v2", objEdita.DtLancamento);
                cmd.Parameters.AddWithValue("@v3", objEdita.DescGenero);
                cmd.Parameters.AddWithValue("@v4", objEdita.TipoDeJogo);
                cmd.Parameters.AddWithValue("@v5", objEdita.VlPrecos);
                cmd.Parameters.AddWithValue("@v6", objEdita.DescDistribuidoraJogo);
                cmd.Parameters.AddWithValue("@v7", objEdita.UrlImagemAlbum);
                cmd.Parameters.AddWithValue("@v8", objEdita.CONSOLE);
                cmd.Parameters.AddWithValue("@v9", objEdita.NOVIDADE);
                cmd.Parameters.AddWithValue("@v10", objEdita.IdJogo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar Jogo!! " + ex);
            }
            finally
            {
                DesConectar();
            }

        }

        //Excluir Jogo

        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Jogo WHERE IdJogo=@v1", conn);
                cmd.Parameters.AddWithValue("@v1", objExclui);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {

                throw new Exception("Erro ao Excluir Jogo!! " + ex);
            }
            finally
            {
                DesConectar();
            }

        }

        //Listar

        public List<CadastroJogoDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo,NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,UrlImagemAlbum,Jg.CONSOLE,CSL.NomeConsole,Jg.NOVIDADE,NVD.NomeNovidade FROM Jogo AS Jg  " +
                    "INNER JOIN CONSOLE AS CSL ON CSL.IdConsole = Jg.CONSOLE INNER JOIN NOVIDADE AS NVD ON NVD.IdNovidade = Jg.NOVIDADE ", conn);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<CadastroJogoDTO> Lista = new List<CadastroJogoDTO>();

                while (dr.Read())
                {
                    CadastroJogoDTO obj = new CadastroJogoDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.NmJogo = dr["NmJogo"].ToString();
                    obj.DtLancamento = dr["DtLancamento"].ToString();
                    obj.DescGenero = dr["DescGenero"].ToString();
                    obj.TipoDeJogo = dr["TipoDeJogo"].ToString();
                    obj.VlPrecos = dr["VlPrecos"].ToString();
                    obj.DescDistribuidoraJogo = dr["DescDistribuidoraJogo"].ToString();
                    obj.UrlImagemAlbum = dr["UrlImagemAlbum"].ToString();
                    obj.CONSOLE = Convert.ToInt32(dr["CONSOLE"]);
                    obj.NomeConsole = Convert.ToString(dr["NomeConsole"]);
                    obj.NOVIDADE = Convert.ToInt32(dr["NOVIDADE"]);
                    obj.NomeNovidade = dr["NomeNovidade"].ToString();

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Jogo!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }
        public List<FiltrarJogosDTO> Filtrar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo,NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,UrlImagemAlbum,Jg.CONSOLE,CSL.NomeConsole,Jg.NOVIDADE,NVD.NomeNovidade FROM Jogo AS Jg  " +
                    "INNER JOIN CONSOLE AS CSL ON CSL.IdConsole = Jg.CONSOLE INNER JOIN NOVIDADE AS NVD ON NVD.IdNovidade = Jg.NOVIDADE ", conn);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<FiltrarJogosDTO> Lista = new List<FiltrarJogosDTO>();

                while (dr.Read())
                {
                    FiltrarJogosDTO obj = new FiltrarJogosDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.NmJogo = dr["NmJogo"].ToString();
                    obj.DtLancamento = dr["DtLancamento"].ToString();
                    obj.DescGenero = dr["DescGenero"].ToString();
                    obj.TipoDeJogo = dr["TipoDeJogo"].ToString();
                    obj.VlPrecos = dr["VlPrecos"].ToString();
                    obj.DescDistribuidoraJogo = dr["DescDistribuidoraJogo"].ToString();
                    obj.UrlImagemAlbum = dr["UrlImagemAlbum"].ToString();
                    obj.CONSOLE = Convert.ToInt32(dr["CONSOLE"]);
                    obj.NomeConsole = Convert.ToString(dr["NomeConsole"]);
                    obj.NOVIDADE = Convert.ToInt32(dr["NOVIDADE"]);
                    obj.NomeNovidade = dr["NomeNovidade"].ToString();

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Jogo!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }
        //filtrar por genero
        public List<FiltrarJogosDTO> Filtrar(int idConsole)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo,NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,UrlImagemAlbum,Jg.CONSOLE,CSL.NomeConsole,Jg.NOVIDADE,NVD.NomeNovidade FROM Jogo AS Jg  " +
                    "INNER JOIN CONSOLE AS CSL ON CSL.IdConsole = Jg.CONSOLE INNER JOIN NOVIDADE AS NVD ON NVD.IdNovidade = Jg.NOVIDADE WHERE CONSOLE=@v1 ", conn);
                cmd.Parameters.AddWithValue("@v1", idConsole);
                dr = cmd.ExecuteReader();

                //Criando Uma Lista Vazia

                List<FiltrarJogosDTO> Lista = new List<FiltrarJogosDTO>();

                while (dr.Read())
                {
                    FiltrarJogosDTO obj = new FiltrarJogosDTO();
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.NmJogo = dr["NmJogo"].ToString();
                    obj.DtLancamento = dr["DtLancamento"].ToString();
                    obj.DescGenero = dr["DescGenero"].ToString();
                    obj.TipoDeJogo = dr["TipoDeJogo"].ToString();
                    obj.VlPrecos = dr["VlPrecos"].ToString();
                    obj.DescDistribuidoraJogo = dr["DescDistribuidoraJogo"].ToString();
                    obj.UrlImagemAlbum = dr["UrlImagemAlbum"].ToString();
                    obj.CONSOLE = Convert.ToInt32(dr["CONSOLE"]);
                    obj.NomeConsole = Convert.ToString(dr["NomeConsole"]);
                    obj.NOVIDADE = Convert.ToInt32(dr["NOVIDADE"]);
                    obj.NomeNovidade = dr["NomeNovidade"].ToString();

                    Lista.Add(obj);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Listar Jogo!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }




        //Selecionar
        public CadastroJogoDTO Selecionar(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdJogo,NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,UrlImagemAlbum,Jg.CONSOLE,CSL.NomeConsole,Jg.NOVIDADE,NVD.NomeNovidade FROM Jogo AS Jg  INNER JOIN CONSOLE AS CSL ON CSL.IdConsole = Jg.CONSOLE INNER JOIN NOVIDADE AS NVD ON NVD.IdNovidade=Jg.NOVIDADE WHERE IdJogo = @v1", conn);
                cmd.Parameters.AddWithValue("@v1", objSeleciona);
                dr = cmd.ExecuteReader();

                //Criando Um Ponteiro

                CadastroJogoDTO obj = new CadastroJogoDTO();

                if (dr.Read())
                {
                    obj.IdJogo = Convert.ToInt32(dr["IdJogo"]);
                    obj.NmJogo = dr["NmJogo"].ToString();
                    obj.DtLancamento = dr["DtLancamento"].ToString();
                    obj.DescGenero = dr["DescGenero"].ToString();
                    obj.TipoDeJogo = dr["TipoDeJogo"].ToString();
                    obj.VlPrecos = dr["VlPrecos"].ToString();
                    obj.DescDistribuidoraJogo = dr["DescDistribuidoraJogo"].ToString();
                    obj.UrlImagemAlbum = dr["UrlImagemAlbum"].ToString();
                    obj.CONSOLE = Convert.ToInt32(dr["CONSOLE"]);
                    obj.NomeConsole = dr["NomeConsole"].ToString();
                    obj.NOVIDADE = Convert.ToInt32(dr["NOVIDADE"]);
                    obj.NomeNovidade = dr["NomeNovidade"].ToString();

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Selecionar Jogo!! " + ex);
            }
            finally
            {
                DesConectar();
            }
        }
    }
}
