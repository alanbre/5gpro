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
        PaisDAO paisdao = new PaisDAO();

        public void salvar(Pais pais)
        {
            try
            {
                paisdao.Salvar(pais);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
