using _5gpro.Daos;
using _5gpro.Entities;
using System.Collections.Generic;

namespace _5gpro.Bll
{
    class PessoaBLL
    {
        PessoaDAO PessoaDAO = new PessoaDAO();

        public int SalvarOuAtualizarPessoa(Pessoa pessoa)
        {
            return PessoaDAO.SalvarOuAtualizarPessoa(pessoa);
        }

        public Pessoa BuscarPessoaById(int cod)
        {
            return PessoaDAO.BuscarPessoaById(cod);
        }

        public Pessoa BuscarProximaPessoa(string codAtual)
        {
            return PessoaDAO.BuscarProximaPessoa(codAtual);
        }

        public Pessoa BuscarPessoaAnterior(string codAtual)
        {
            return PessoaDAO.BuscarPessoaAnterior(codAtual);
        }

        public List<Pessoa> BuscarPessoas(string nome, string cpfcnpj, string cidade)
        {
            return PessoaDAO.BuscarPessoas(nome, cpfcnpj, cidade);
        }

        public string BuscaProxCodigoDisponivel()
        {
            return PessoaDAO.BuscaProxCodigoDisponivel();
        }
    }
}
