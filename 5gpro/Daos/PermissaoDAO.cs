using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5gpro.Forms;
using MySQLConnection;

namespace _5gpro.Daos
{
    public class PermissaoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public fmCadastroGrupoUsuario.PermissoesStruct BuscaPermissoesByIdGrupo(string cod)
        {

            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();

            permissoes.Todas = new List<Permissao>();
            permissoes.Modulos = new List<Permissao>();
            permissoes.Telas = new List<Permissao>();
            permissoes.Funcoes = new List<Permissao>();

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT p.idpermissao AS pid, p.nome AS pnome, p.codigo AS pcodigo, pg.nivel AS pgnivel
                            FROM permissao_has_grupo_usuario pg INNER JOIN permissao p 
                            ON pg.idpermissao = p.idpermissao 
                            WHERE idgrupousuario = @idgrupousuario";

                sql.addParam("@idgrupousuario", cod);

                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    string codfiltro = (string)d["pcodigo"];

                    
                    Permissao p = new Permissao
                    {
                        PermissaoId = Convert.ToInt32(d["pid"]),
                        Nome = (string)d["pnome"],
                        Codigo = (string)d["pcodigo"],
                        Nivel = Convert.ToString(d["pgnivel"])

                    };
                    permissoes.Todas.Add(p);

                    if (codfiltro.Substring(2) == "0000")
                    {
                        permissoes.Modulos.Add(p);
                    }

                    if (codfiltro.Substring(4) == "00")
                    {
                        permissoes.Telas.Add(p);
                    }

                    if (codfiltro.Substring(4) != "00")
                    {
                        permissoes.Funcoes.Add(p);
                    }
                }
            }
            return permissoes;
        }


        public fmCadastroGrupoUsuario.PermissoesStruct BuscaTodasPermissoes()
        {
            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();

            permissoes.Todas = new List<Permissao>();
            permissoes.Modulos = new List<Permissao>();
            permissoes.Telas = new List<Permissao>();
            permissoes.Funcoes = new List<Permissao>();

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM permissao";

                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    string codfiltro = (string)d["codigo"];

                    Permissao p = new Permissao
                    {
                        PermissaoId = Convert.ToInt32(d["idpermissao"]),
                        Nome = (string)d["nome"],
                        Codigo = (string)d["codigo"],
                        Nivel = "0"
                    };
                    permissoes.Todas.Add(p);

                    if (codfiltro.Substring(2) == "0000")
                    {
                        permissoes.Modulos.Add(p);
                    }

                    if (codfiltro.Substring(4) == "00")
                    {
                        permissoes.Telas.Add(p);
                    }

                    if (codfiltro.Substring(4) != "00")
                    {
                        permissoes.Funcoes.Add(p);
                    }

                }
            }

            return permissoes;
        }


        public Permissao BuscarPermissaoByID(string idpermissao)
        {
            Permissao permissao = null;

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM permissao as p WHERE p.idpermissao = @idpermissao";

                sql.addParam("@idpermissao", idpermissao);

                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    permissao = new Permissao();
                    permissao.PermissaoId = Convert.ToInt32(d["idpermissao"]);
                    permissao.Nome = (string)d["nome"];
                    permissao.Codigo = (string)d["codigo"];
                    permissao.Nivel = "0";

                }
            }

            return permissao;
        }

        public int BuscarIDbyCodigo(string codpermissao)
        {
            int permissaoid = 0;

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT p.idpermissao FROM permissao as p WHERE p.codigo = @codigo";

                sql.addParam("@codigo", codpermissao);

                var data = sql.selectQueryForSingleRecord();

                if (data != null)
                {
                    permissaoid = Convert.ToInt32(data["idpermissao"]);
                }             

            }

            return permissaoid;
        }


        public int BuscarNivelPermissao(string codgrupousuario, string codpermissao)
        {
            int nivel = 0;

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT pg.nivel FROM permissao_has_grupo_usuario as pg 
                                             WHERE idgrupousuario = @idgrupousuario 
                                             AND idpermissao = @idpermissao";

                sql.addParam("@idgrupousuario", codgrupousuario);
                sql.addParam("idpermissao", codpermissao);

                var data = sql.selectQueryForSingleRecord();

                if (data != null)
                {
                    nivel = Convert.ToInt32(data["nivel"]);
                }
            }
            return nivel;
        }

        public List<int> BuscarIDPermissoesNpraN()
        {
            List<int> idpermissoesNpraN = new List<int>();

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT DISTINCT p.idpermissao 
                                             FROM permissao_has_grupo_usuario as p";

                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    int a = Convert.ToInt32(d["idpermissao"]);

                    idpermissoesNpraN.Add(a);
                }
            }
            return idpermissoesNpraN;
        }

        public List<fmMain.PermissaoNivelStruct> PermissoesNiveisStructByCodGrupoUsuario(string codgrupousuario)
        {
            List<fmMain.PermissaoNivelStruct> listacomniveis = new List<fmMain.PermissaoNivelStruct>();

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * 
                FROM permissao_has_grupo_usuario as p
                WHERE p.idgrupousuario = @idgrupousuario
                ";

                sql.addParam("@idgrupousuario", codgrupousuario);

                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    fmMain.PermissaoNivelStruct permissaonivel = new fmMain.PermissaoNivelStruct();
                    permissaonivel.permissao = BuscarPermissaoByID((d["idpermissao"]).ToString());
                    permissaonivel.Nivel = Convert.ToInt32(d["nivel"]);

                    listacomniveis.Add(permissaonivel);
                }
            }
            return listacomniveis;
        }
    }
}
