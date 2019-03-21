using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Funcoes
{
    class DatabaseUpdate : Daos.ConexaoDAO
    {
        MySqlCommand Comando = null;

        public bool CriarTabelasSeNaoExistirem()
        {
            try
            {
                AbrirConexao();

                // Esse comando trás o diretório atual (Ex \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // Ou: Directory.GetCurrentDirectory() devolve o mesmo resultado

                // Esse comando trás o diretório do projeto
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

                // Aqui vai abrir o arquivo SQL e executá-lo.
                MySqlScript mySqlScript = new MySqlScript(conexao, File.ReadAllText(projectDirectory + "/create_tables.sql"));
                mySqlScript.Execute();
                
                return true;
            }
            catch (MySqlException ex)
            {
                try
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    return false;
                }
                catch (MySqlException ex1)
                {
                    Console.WriteLine("Error: {0}", ex1.ToString());
                    return false;
                }
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        //public bool AtualizaBanco()
        //{
        //    try
        //    {

        //        Comando = new MySqlCommand("SELECT ");
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {

        //    }
        //    return true;
        //}
    }
}
