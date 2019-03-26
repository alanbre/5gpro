﻿using _5gpro.Daos;
using _5gpro.Entities;

namespace _5gpro.Bll
{
    class _ItemBLL
    {

        _ItemDAO _itemdao = new _ItemDAO();

        public int SalvarOuAtualizarItem(_Item _item)
        {
            return _itemdao.SalvarOuAtualizarItem(_item);
        }

        public _Item BuscaItemById(string cod)
        {
            return _itemdao.BuscarItemById(cod);
        }

        public _Item BuscarProximoItem(string codAtual)
        {
            return _itemdao.BuscarProximoItem(codAtual);
        }

        public _Item BuscarItemAnterior(string codAtual)
        {
            return _itemdao.BuscarItemAnterior(codAtual);
        }


    }
}
