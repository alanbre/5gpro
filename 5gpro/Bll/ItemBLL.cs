using _5gpro.Daos;
using _5gpro.Entities;
using System.Collections.Generic;

namespace _5gpro.Bll
{
    class ItemBLL
    {

        private readonly ItemDAO itemdao = new ItemDAO();

        public int SalvarOuAtualizarItem(Item item)
        {
            return itemdao.SalvarOuAtualizarItem(item);
        }

        public Item BuscaItemById(int cod)
        {
            return itemdao.BuscarItemById(cod);
        }

        public Item BuscarProximoItem(string codAtual)
        {
            return itemdao.BuscarProximoItem(codAtual);
        }

        public Item BuscarItemAnterior(string codAtual)
        {
            return itemdao.BuscarItemAnterior(codAtual);
        }

        public List<Item> BuscaItens(string descItem, string denomItem, string tipoItem)
        {
            return itemdao.BuscaItem(descItem, denomItem, tipoItem);
        }

        public string BuscaProxCodigoDisponivel()
        {
            return itemdao.BuscaProxCodigoDisponivel();
        }
    }
}
