using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.DAL
{
    public class Conexao
    {
        //Variaveis Presisamos de tres 
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;


        //Metodos ------------------------------------------------------------
        public void Conectar()
        {
            try
            {
                //conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BLECAUTE; Integrated Security = True;");
                //conn.Open();
                conn = new SqlConnection(@"Server=tcp:stargames.database.windows.net,1433;Initial Catalog=BLECAUTE;Persist Security Info=False;User ID=stargames;Password=Blecaute#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void DesConectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
