using _5gpro.Forms;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using System;
using System.Globalization;
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

            var culture = CultureInfo.GetCultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            DadosEstaticos.LeDadosEstaticos();

            if (Configuracao.BancoIP == null || Configuracao.BancoUsuario == null || Configuracao.BancoSenha == null)
            {
                var fmCfgBase = new fmCfgBase();
                fmCfgBase.ShowDialog();
                DadosEstaticos.LeDadosEstaticos();
            }

            


            var carregaSistema = new CarregaSistema();

            if (!carregaSistema.Carrega())
                Application.Exit();

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

