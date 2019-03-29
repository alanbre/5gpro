using _5gpro.Entities;
using _5gpro.Bll;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class PermissaoDAO : ConexaoDAO
    {

        public List<Permissao> BuscaPermissoesGrupo(string cod)
        {
            List<Permissao> permissoesGrupo = new List<Permissao>();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao_has_grupo_usuario pg INNER JOIN permissao p 
                                             ON pg.idpermissao = p.idpermissao 
                                             WHERE idgrupousuario = @idgrupousuario", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Permissao p = new Permissao();

                    p.Codigo = reader.GetString(reader.GetOrdinal("idpermissao"));
                    p.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    p.Nivel = reader.GetString(reader.GetOrdinal("nivel"));

                    permissoesGrupo.Add(p);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return permissoesGrupo;
        }

    }
}
