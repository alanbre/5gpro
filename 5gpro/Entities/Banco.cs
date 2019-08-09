using System;

namespace _5gpro.Entities
{
    public class Banco
    {
        public int BancoID { get; set; }
        public string Codigo { get; set; }
        public string Ispb { get; set; }
        public string Nome { get; set; }
        public string NomeReduzido { get; set; }
        public bool Compe { get; set; }
        public string AcessoPrincipal { get; set; }
        public DateTime InicioOperacao { get; set; }
    }
}
