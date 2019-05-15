using _5gpro.Forms;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var carregaSistema = new CarregaSistema();



            if (System.Diagnostics.Debugger.IsAttached)
            {
                var formSelecionaBase = new fmSelecionarBase();
                formSelecionaBase.ShowDialog();
            }
            else
            {
                if (!carregaSistema.Carrega())
                    Application.Exit();
            }

            

            var formLogin = new fmLogin();
            formLogin.ShowDialog();
            if (formLogin.usuariologado != null)
            {
                Application.Run(new fmMain());
            }
            else
            {
                Application.Exit();
            }


        }
    }
}

