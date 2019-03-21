using _5gpro.Daos;
using _5gpro.Entities;

namespace _5gpro.Bll
{
    class PessoaBLL
    {
        PessoaDAO PessoaDAO = new PessoaDAO();

        public int Salvar(Pessoa pessoa)
        {
            return PessoaDAO.SalvarPessoa(pessoa);
        }

        public Pessoa BuscaPessoaById(string cod)
        {
            return PessoaDAO.BuscarPessoaById(cod);
        }
    }
}
