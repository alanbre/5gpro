using System;
using System.Windows.Forms;

namespace _5gpro.Funcoes
{
    class FuncoesAuxiliares
    {
        public void ValidaTeclaDigitadaDecimal(KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != Char.Parse(","))
            {
                e.Handled = true;
            }
        }
    }
}
