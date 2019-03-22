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

        public Pessoa BuscaPessoaById(string cod)
        {
            return PessoaDAO.BuscarPessoaById(cod);
        }
    }
}
