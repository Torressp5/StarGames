using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGames.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string CpfUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string DtNascimento { get; set; }
        public string DsEmail { get; set; }
        public string UrlImgUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public string DescTipoUsuario { get; set; }
      
    }
}
