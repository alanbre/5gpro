using _5gpro.Daos;
using _5gpro.Entities;

namespace _5gpro.Bll
{
    class PessoaBLL
    {
        PessoaDAO PessoaDAO = new PessoaDAO();

        public int SalvarOuAtualizarPessoa(Pessoa pessoa)
        {
            return PessoaDAO.SalvarOuAtualizarPessoa(pessoa);
        }

        public Pessoa BuscarPessoaById(string cod)
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
    }
}
