namespace _5gpro.Funcoes
{
    class CarregaSistema
    {
        public bool Carrega()
        {
            //Faz as relações que não existem na N para N caso necessário
            new PermissoesUpdate().AtualizarNpraN();

            DatabaseUpdate databaseUpdate = new DatabaseUpdate();
            return databaseUpdate.CriarTabelasSeNaoExistirem();// && databaseUpdate.AtualizaBD();
           
        }

    }
}
