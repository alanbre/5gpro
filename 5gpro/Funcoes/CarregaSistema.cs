namespace _5gpro.Funcoes
{
    class CarregaSistema
    {
        public bool Carrega()
        {
            DatabaseUpdate databaseUpdate = new DatabaseUpdate();
            return databaseUpdate.CriarTabelasSeNaoExistirem();// && databaseUpdate.AtualizaBD();
        }

    }
}
