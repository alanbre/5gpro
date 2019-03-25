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

        _ItemDAO _itemdao = new _ItemDAO();

        public void SalvarOuAtualizarItem(_Item _item)
        {
            try
            {
                _itemdao.SalvarOuAtualizarItem(_item);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }


        public _Item BuscaItemById(string cod)
        {
            return _itemdao.BuscarItemById(cod);
        }


    }
}
