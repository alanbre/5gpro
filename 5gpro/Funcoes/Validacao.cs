using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace _5gpro.Funcoes
{

    public class Validacao : Form
    {
        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            //RECEBE UM OBJETO E TENTA VALIDAR ELE CONFORME AS REGRAS SETADAS NA ENTIDADE
            //E ADICIONA TODO O ERRO EM UMA LISTA
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);

            //RETORNA A LISTA DE ERROS GERADA
            return resultadoValidacao;
        }

        public bool ValidarEntidade(object obj)
        {

            //RECEBE A ENTIDADE A SER TESTADA

            //CRIA UMA VARIÁVEL "OK" COM O VALOR 1
            bool ok = false;

            //CHAMA A FUNÇÃO getValidationErros PARA OBTER A LISTA DE ERROS
            //CASO EXISTA ALGUM
            var erros = Validacao.getValidationErros(obj);

            //CRIA UMA LISTA DE STRING PARA ARMAZENAR OS ERROS PARA QUE
            //SEJA POSSÍVEL APRESENTAR APENAS O ERRO DA POSIÇÃO [0]
            List<string> listaerros = new List<string>();
            foreach (var error in erros)
            {
                //PERCORRENDO A LISTA DE ERROS GERADOS PELA FUNÇÃO getValidationErros
                // E ARMAZENANDO ELES NA LISTA DE STRING
                listaerros.Add(error.ErrorMessage);
            }

            //VERIFICA SE A LISTA TEM MAIS DE 0 REGISTROS E MOSTRA APENAS
            //O PRIMEIRO QUE ESTÁ NA POSIÇÃO [0]
            if (listaerros.Count > 0)
            {
                MessageBox.Show(listaerros[0]);
            }
            //QUANDO NÃO HOUVER MAIS ERROS, CAI NO ELSE E MUDA A VARIAVEL
            // "OK" PARA 0
            else
            {
                ok = true;
            }

            return ok;
        }
    }


}


