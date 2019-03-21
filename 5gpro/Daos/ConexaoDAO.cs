using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _5gpro.Daos
{
    public class ConexaoDAO
    {
        string conecta = "DATABASE=5gprodatabase; SERVER=localhost; UID=5gprouser; PWD=5gproedualan";
        protected MySqlConnection conexao = null;


        //MÉTODO PARA CONECTAR NO BANCO
        public void AbrirConexao()
        {

            try
            {

                conexao = new MySqlConnection(conecta);
                conexao.Open();
                Console.WriteLine("Sucesso da conexão");

            }
            catch (Exception erro)
            {
                throw erro;
            }



        }

        //METODO PARA FECHAR A CONEXAO COM O BANCO

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
           
        }

    }
}
