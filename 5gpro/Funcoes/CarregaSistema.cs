namespace _5gpro.Funcoes
{
    class CarregaSistema
    {
        public bool Carrega()
        {
            bool retorno = new DatabaseUpdate().Migrate();
            new PermissoesUpdate().AtualizarNpraN();

            return retorno;
        }
    }
}
