using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
        public T DeepCopy<T>(T item)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, item);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }
        public void TratarTamanhoColunas(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (var i = 0; i <= dgv.Columns.Count - 1; i++)
            {
                var colw = dgv.Columns[i].Width;
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns[i].Width = colw;
            }
        }

        /// <summary>
        /// Formatar uma string CNPJ
        /// </summary>
        /// <param name="CNPJ">string CNPJ sem formatacao</param>
        /// <returns>string CNPJ formatada</returns>
        /// <example>Recebe '99999999999999' Devolve '99.999.999/9999-99'</example>
        public string FormataCNPJ(string CNPJ)
        {
            if (CNPJ.Length == 14)
            {
                return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
            }
            else
            {
                return CNPJ;
            }
        }

        /// <summary>
        /// Formatar uma string CPF
        /// </summary>
        /// <param name="CPF">string CPF sem formatacao</param>
        /// <returns>string CPF formatada</returns>
        /// <example>Recebe '99999999999' Devolve '999.999.999-99'</example>
        public string FormataCPF(string CPF)
        {
            if (CPF.Length == 11)
            {
                return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
            }
            else
            {
                return CPF;
            }
        }

        /// <summary>
        /// Retira a Formatacao de uma string CNPJ/CPF
        /// </summary>
        /// <param name="Documento">string Codigo Formatada</param>
        /// <returns>string sem formatacao</returns>
        /// <example>Recebe '99.999.999/9999-99' Devolve '99999999999999'</example>
        public string SemFormatacao(string Documento)
        {
            return Documento.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }

        /// <summary>
        /// Formatar uma string Telefone
        /// </summary>
        /// <param name="Tel">string Telefone sem formatacao</param>
        /// <returns>string Telefone formatada</returns>
        /// <example>Recebe '99999999999' Devolve '(99) 99999-9999'</example>
        public string FormataTel(string Tel)
        {
            if (Tel.Length == 11)
            {
                return Convert.ToUInt64(Tel).ToString("(00) 00000-0000");
            }
            else
            {
                return Tel;
            }
        }
    }
}
