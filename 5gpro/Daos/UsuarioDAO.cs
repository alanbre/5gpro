using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace _5gpro.Daos
{
    class UsuarioDAO : ConexaoDAO
    {
        public Usuario Logar(string login, string senha)
        {
            Usuario usuario = new Usuario();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM usuario WHERE login = @login AND senha = @senha", Conexao);
                Comando.Parameters.AddWithValue("@login", login);
                Comando.Parameters.AddWithValue("@senha", senha);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario.Codigo = reader.GetString(reader.GetOrdinal("idusuario"));
                    usuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    usuario.Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome"));
                    usuario.Login = reader.GetString(reader.GetOrdinal("login"));
                    usuario.Senha = reader.GetString(reader.GetOrdinal("senha"));
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            return usuario;
        }
    }
}
