using System;
using System.Windows.Forms;
using _5gpro.Funcoes;

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
