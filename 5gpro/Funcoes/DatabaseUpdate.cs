using _5gpro.Daos;
using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace _5gpro.Funcoes
{
    class DatabaseUpdate : ConexaoDAO
    {
        int VersaoDB = 0;

        public bool CriarTabelasSeNaoExistirem()
        {
            try
            {
                // Esse comando trás o diretório atual (Ex \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // Ou: Directory.GetCurrentDirectory() devolve o mesmo resultado

                // Esse comando trás o diretório do projeto
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

                Conecta = "SERVER=192.168.2.114; UID=5gprouser; PWD=5gproedualan";
                //Conecta = "SERVER=localhost; UID=5gprouser; PWD=5gproedualan";

                AbrirConexao();
                // Aqui vai abrir o arquivo SQL e executá-lo.
                MySqlScript mySqlScript = new MySqlScript(Conexao, File.ReadAllText(projectDirectory + "/create_tables.sql"));


                mySqlScript.Execute();

                Conecta = "DATABASE=5gprodatabase; SERVER=192.168.2.114; UID=5gprouser; PWD=5gproedualan";
                //Conecta = "DATABASE=5gprodatabase; SERVER=localhost; UID=5gprouser; PWD=5gproedualan";

                return true;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }

        public int BuscaVersaoDB()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT valor FROM configuracao WHERE variavel = @versaodb", Conexao);
                Comando.Parameters.AddWithValue("@versaodb", "versaodb");

                MySqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    VersaoDB = reader.GetInt32(0);
                }
                return VersaoDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return 0;
            }
            finally
            {
                FecharConexao();
            }
        }

        public int AtualizaVersaoBD(int versao)
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("UPDATE configuracao SET valor = @valor WHERE variavel = @versaodb", Conexao);
                Comando.Parameters.AddWithValue("@versaodb", "versaodb");
                Comando.Parameters.AddWithValue("@valor", versao);
                return Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return 0;
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool AtualizaBD()
        {
            try
            {
                int versaoAtual = BuscaVersaoDB();

                AbrirConexao();
                Comando = Conexao.CreateCommand();

                tr = Conexao.BeginTransaction();

                Comando.Connection = Conexao;
                Comando.Transaction = tr;

                if (versaoAtual < 2)
                {

                    try
                    {
                        Comando.CommandText = "ALTER TABLE pessoa ADD COLUMN tipo_pessoa CHAR(1)";
                        Comando.ExecuteNonQuery();
                        Comando.CommandText = "ALTER TABLE configuracao MODIFY COLUMN idconfiguracao INT NOT NULL AUTO_INCREMENT";
                        Comando.ExecuteNonQuery();

                        AtualizaVersaoBD(2);
                        return true;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error: {0}", ex.ToString());
                        try
                        {
                            tr.Rollback();
                        }
                        catch (MySqlException ex2)
                        {
                            if (tr.Connection != null)
                            {
                                Console.WriteLine(@"Uma exceção do tipo " + ex2.GetType() +
                                " ocorreu enquanto acontecia o rollback da transação.");
                            }
                        }
                        Console.WriteLine(@"Uma exceção do tipo  " + ex.GetType() +
                                           " ocorreu enquanto os dados eram atualizados");
                        Console.WriteLine("Nenhum dado foi atualizado no banco");
                        return false;
                    }
                }
                if (versaoAtual < 3)
                {
                    try
                    {
                        Comando.CommandText = "ALTER TABLE atuacao_has_pessoa ADD COLUMN ativo BOOLEAN";
                        Comando.ExecuteNonQuery();
                        AtualizaVersaoBD(3);
                        return true;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error: {0}", ex.ToString());
                        try
                        {
                            tr.Rollback();
                        }
                        catch (MySqlException ex2)
                        {
                            if (tr.Connection != null)
                            {
                                Console.WriteLine(@"Uma exceção do tipo " + ex2.GetType() +
                                " ocorreu enquanto acontecia o rollback da transação.");
                            }
                        }
                        Console.WriteLine(@"Uma exceção do tipo  " + ex.GetType() +
                                           " ocorreu enquanto os dados eram atualizados");
                        Console.WriteLine("Nenhum dado foi atualizado no banco");
                        return false;
                    }
                }

                tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                return false;
            }
            finally
            {
                FecharConexao();
            }
            return true;
        }
    }
}

