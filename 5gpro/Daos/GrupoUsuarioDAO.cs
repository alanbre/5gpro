using _5gpro.Bll;
using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class GrupoUsuarioDAO : ConexaoDAO
    {
        PermissaoBLL permissaoBLL = new PermissaoBLL();
        GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();

        public GrupoUsuario BuscarGrupoUsuarioById(string cod)
        {
            GrupoUsuario grupousuario = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = @idgrupousuario", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario();
                    grupousuario.Codigo = reader.GetString(reader.GetOrdinal("idgrupousuario"));
                    grupousuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    grupousuario.Permissoes = permissaoBLL.BuscaPermissoesGrupo(reader.GetString(reader.GetOrdinal("idgrupousuario")));
                   
                    reader.Close();
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
            return grupousuario;
        }

    }
}
