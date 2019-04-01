using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _5gpro.Entities
{
    public class Pessoa
    {
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNome", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Nome fantasia é obrigatório.|tbFantasia", AllowEmptyStrings = false)]
        public string Fantasia { get; set; }

        public List<string> Atuacao { get; set; }
        public string TipoPessoa { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        [Required(ErrorMessage = "A Cidade é obrigatória.|tbCodCidade", AllowEmptyStrings = false)]
        public Cidade Cidade { get; set; }

        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string Endereco
        {
            get
            {
                return (this.Rua + ", " + this.Numero + " - " + this.Bairro);
            }
            set
            {
                //PEGA O VALOR PASSADO PELA VARIÁVEL DO C# CHAMADA value 
                //(EXEMPLO pessoa.Endereco = "abc, 123 - Centro") e separa pra passar certinho pros campos
                //É ÚTIL PROS GRIDS (OU LUGAR COM MESMA CONDIÇÃO) ONDE NÃO PRECISA SEPARA RUA, NUMERO, BAIRRO
                string[] dados = Regex.Split(value, ",|-");
                this.Rua = dados[0];
                this.Numero = dados[1];
                this.Bairro = dados[2];
            }
        }

        public Pessoa()
        {

        }

        public Pessoa(string codigo, string nome, List<string> atuacao, string tipopessoa, Cidade cidade)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Atuacao = atuacao;
            this.TipoPessoa = tipopessoa;
            this.Cidade = cidade;
        }
    }
}
