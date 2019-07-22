using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.StaticFiles
{
    public static class Configuracao
    {
        public static string CodUsuario { get; set; }
        public static string BancoIP { get; set; }
        public static string BancoUsuario { get; set; }
        public static string BancoSenha { get; set; }
        public static string Conecta {
            get
            {
                return $"DATABASE= 5gprodatabase;SERVER={BancoIP};UID={BancoUsuario};PWD={BancoSenha}";
            }
        }
        public static string ConectaSemBase
        {
            get
            {
                return $"SERVER={BancoIP};UID={BancoUsuario};PWD={BancoSenha}";
            }
        }
    }
}
