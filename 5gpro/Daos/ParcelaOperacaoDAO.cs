using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class ParcelaOperacaoDAO
    {

        public ConexaoDAO Connect { get; }
        public ParcelaOperacaoDAO(ConexaoDAO c)
        {
            Connect = c;
        }


    }
}
