namespace _5gpro.Funcoes
{
    class CarregaSistema
    {
        public bool Carrega()
        {
            //Faz as relações que não existem na N para N caso necessário
            bool retorno = new DatabaseUpdate().Migrate();
            new PermissoesUpdate().AtualizarNpraN();

            return retorno;// && databaseUpdate.AtualizaBD();
        }
    }
}
