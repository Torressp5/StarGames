using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.DTO
{
  public  class CadastroJogoDTO
    {
        public int IdJogo { get; set; }
        public string NmJogo { get; set; }
        public string DtLancamento { get; set; }
        public string DescGenero { get; set; }
        public string TipoDeJogo { get; set; }
        public string VlPrecos { get; set; }
        public string DescDistribuidoraJogo { get; set; }
        public string UrlImagemAlbum { get; set; }
        public int CONSOLE { get; set; }
        public string NomeConsole { get; set; }
        public int NOVIDADE { get; set; }
        public string NomeNovidade { get; set; }

    }
}
