using _5gpro.Forms;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
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
            CarregaSistema carregaSistema = new CarregaSistema();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (carregaSistema.Carrega())
            {
                fmLogin formLogin = new fmLogin();
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
