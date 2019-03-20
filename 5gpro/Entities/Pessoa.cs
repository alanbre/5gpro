using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class Pessoa
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public List<string> Atuacao { get; set; }
        public string TipoPessoa { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string codigo, string nome, List<string> atuacao, string tipopessoa)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Atuacao = atuacao;
            this.TipoPessoa = tipopessoa;
        }

        //TODO:
        //VERIFICAR A NECESSIDADE DE TER GET E SET PARA TUDO, POR ENQUANTO DEIXAR OS CAMPOS COMO PUBLICOS (ACHO QUE PRECISA PRO CÓDIGO SÓ)
        public void SetCodigo(string codigo)
        {
            this.Codigo = codigo;
        }

        public string GetCodigo()
        {
            return this.Codigo;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetFantasia(string fantasia)
        {
            this.Fantasia = fantasia;
        }

        public string GetFantasia()
        {
            return this.Fantasia;
        }

        public void SetAtuacao(List<string> atuacao)
        {
            this.Atuacao = atuacao;
        }

        public string GetAtuacao()
        {
            return this.Nome;
        }
    }
}
