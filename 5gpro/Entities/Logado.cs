namespace _5gpro.Entities
{
    public class Logado
    {
        public int LogadoID { get; set; }
        public string Mac { get; set; }
        public Usuario Usuario { get; set; }
        public string NomePC { get; set; }
        public string IPdoPC { get; set; }
    }
}
