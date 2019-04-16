namespace _5gpro.Funcoes
{
    class CarregaSistema
    {
        public bool Carrega()
        {
            //Faz as relações que não existem na N para N caso necessário
            DatabaseUpdate databaseUpdate = new DatabaseUpdate();
            bool retorno = databaseUpdate.CriarTabelasSeNaoExistirem();
            new PermissoesUpdate().AtualizarNpraN();


            return retorno;// && databaseUpdate.AtualizaBD();
           
        }

    }
}
