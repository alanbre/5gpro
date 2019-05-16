using MySql.Data.MySqlClient;
using System;
using _5gpro.Funcoes;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using _5gpro.Forms;

namespace _5gpro.Daos
{
    public class ConexaoDAO
    {
        public string database = fmSelecionarBase.database;
        public string server = fmSelecionarBase.server;
        public string uid = fmSelecionarBase.uid;
        public string pwd = fmSelecionarBase.pwd;
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
