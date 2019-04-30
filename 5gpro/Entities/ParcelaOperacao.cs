namespace _5gpro.Entities
{
    public class ParcelaOperacao
    {
        public int ParcelaOperacaoID { get; set; }
        public int Numero { get; set; }
        public int Dias { get; set; }
        public Operacao Operacao { get; set; }
    }
}
