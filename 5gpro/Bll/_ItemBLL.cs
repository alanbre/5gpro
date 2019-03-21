using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class _ItemBLL
    {

        _ItemDAO itemdao = new _ItemDAO();

        public void salvar(_Item _item)
        {
            try
            {
                itemdao.Salvar(_item);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

    }
}
