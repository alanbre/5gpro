using MySql.Data.MySqlClient;
using System;

namespace _5gpro.Daos
{
    public class ConexaoDAO
    {
        //protected static string Conecta = "DATABASE=5gprodatabase; SERVER=localhost; UID=5gprouser; PWD=5gproedualan";
        public static string Conecta = "DATABASE=5gprodatabase; SERVER=192.168.2.111; UID=5gprouser; PWD=5gproedualan; pooling = true";
        public MySqlConnection Conexao;
        public MySqlTransaction tr = null;
        public MySqlCommand Comando = null;

        //MÉTODO PARA CONECTAR NO BANCO
        public void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection(Conecta);
                Conexao.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }

        //METODO PARA FECHAR A CONEXAO COM O BANCO

        public void FecharConexao()
        {
            try
            {
                if (Conexao != null)
                {
                    Conexao.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
    }
}
