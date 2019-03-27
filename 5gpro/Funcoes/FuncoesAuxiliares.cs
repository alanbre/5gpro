using System;
using System.Windows.Forms;

namespace _5gpro.Funcoes
{
    class FuncoesAuxiliares
    {
        public bool ValidaTeclaDigitadaDecimal(KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != Char.Parse(","))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
