using MySql.Data.MySqlClient;
using System;
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
    }
}
