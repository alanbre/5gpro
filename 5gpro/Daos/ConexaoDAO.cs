using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.IO;

namespace _5gpro.Daos
{
    public class ConexaoDAO
    {

        public string Conecta = ConfigurationManager.ConnectionStrings["connectionAppConfig"].ConnectionString; 
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
