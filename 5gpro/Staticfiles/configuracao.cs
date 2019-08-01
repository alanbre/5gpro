namespace _5gpro.StaticFiles
{
    public static class Configuracao
    {
        public static string CodUsuario { get; set; }
        public static string BancoIP { get; set; }
        public static string BancoUsuario { get; set; }
        public static string BancoSenha { get; set; }
        public static string BancoPorta { get; set; }
        public static string Conecta {
            get
            {
                return $"DATABASE=5gprodatabase;SERVER={BancoIP};Port={BancoPorta};UID={BancoUsuario};PWD={BancoSenha}";
            }
        }
        public static string ConectaSemBase
        {
            get
            {
                return $"SERVER={BancoIP};Port={BancoPorta};UID={BancoUsuario};PWD={BancoSenha}";
            }
        }
    }
}
