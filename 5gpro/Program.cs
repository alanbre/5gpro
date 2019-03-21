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
            CarregaSistema carregaSistema = new CarregaSistema();
            FuncoesBanco funcoesBanco = new FuncoesBanco();
            IDictionary<string, string> dados = new Dictionary<string, string>();
            dados.Add("valor", "3");

            IDictionary<string, List<string>> where = new Dictionary<string, List<string>>();
            //where.Add("variavel", new List<string> { "=", "versaodb" });

            if (carregaSistema.Carrega())
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
