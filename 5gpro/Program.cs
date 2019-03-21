using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CarregaSistema carregaSistema = new CarregaSistema();
            FuncoesBanco funcoesBanco = new FuncoesBanco();
            IDictionary<string, string> dados = new Dictionary<string, string>();
            dados.Add("variavel", "testefuncao");
            dados.Add("valor", "testefuncaovalor");

            IDictionary<string, string> where = new Dictionary<string, string>();
            where.Add("variavel", "testefuncao");
            where.Add("valor", "testefuncaovalor");

            //if (carregaSistema.Carrega())
            if (funcoesBanco.ExecutaUpdate("configuracao", dados, where) > 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new fmMain());
            }
            else
            {
                if (MessageBox.Show("Problema ao abrir o sistema",
                "Erro ao abrir sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

        }
    }
}
