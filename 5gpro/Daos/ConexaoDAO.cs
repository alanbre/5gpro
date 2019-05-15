using MySql.Data.MySqlClient;
using System;
using _5gpro.Funcoes;
using System.ComponentModel;
using System.Configuration;
using System.IO;

namespace _5gpro.Daos
{
    public class ConexaoDAO
    {
        private static ConexaoDAO conexaoDAO;

        public string database = "5gprodatabase";
        public string server = "localhost";
        public string uid = "5gprouser";
        public string pwd = "5gproedualan";
        public string Conecta
        {
            get
            {
                return "DATABASE=" + database + ";SERVER=" + server + ";UID=" + uid + ";PWD=" + pwd;
            }
        }
        public string ConectaSemBase
        {
            get
            {
                return "SERVER=" +server + ";UID=" + uid + ";PWD=" + pwd;
            }
        }

        public MySqlConnection Conexao;
        public MySqlTransaction tr = null;
        public MySqlCommand Comando = null;

        private ConexaoDAO()
        {

        }

        public static ConexaoDAO GetInstance()
        {
            if (conexaoDAO == null)
                conexaoDAO = new ConexaoDAO();
            return conexaoDAO;
        }
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
        public void AbrirConexaoSemBase()
        {
            try
            {
                Conexao = new MySqlConnection(ConectaSemBase);
                Conexao.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
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
