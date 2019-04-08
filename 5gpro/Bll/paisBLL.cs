using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class PaisBLL
    {
        private readonly PaisDAO paisdao = new PaisDAO();

        public int SalvarOuAtualizarItem(Pais pais)
        {
            return paisdao.SalvarOuAtualizarPais(pais);
        }
    }
}
