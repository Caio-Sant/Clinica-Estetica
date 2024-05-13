using Centro_Estetica.DB.Base.Entregavel2.Produto;
using Centro_Estetica.DB.Base.Entregavel3.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Controlepedido
{
    class PedidoBusiness
    {


        public int Salvar(PedidoDTO pedido, List<ProdutoDTO> produtos)
        {
            if (pedido.Pagamento == "Selecione")
            {
                throw new ArgumentException("Forma de Pagamento é obrigatório.");
            }

            PedidoDatabase pedidoDatabase = new PedidoDatabase();
            int idPedido = pedidoDatabase.Salvar(pedido);

            PedidoItemBusiness itemBusiness = new PedidoItemBusiness();
            foreach (ProdutoDTO item in produtos)
            {
                PedidoItemDTO itemDto = new PedidoItemDTO();
                itemDto.Id = idPedido;
                itemDto.IdProduto = item.Id;
            }

            return idPedido;

        }




        public void Remover(int pedidoId)
        {
            PedidoItemBusiness itemBusiness = new PedidoItemBusiness();
            List<PedidoItemDTO> itens = itemBusiness.ConsultarPorPedido(pedidoId);

            foreach (PedidoItemDTO item in itens)
            {
                itemBusiness.Remover(item.Id);
            }

            PedidoDatabase pedidoDatabase = new PedidoDatabase();
            pedidoDatabase.Remover(pedidoId);
        }

        public List<PedidoDTO> Consultar(string cliente)
        {
            PedidoDatabase pedidoDatabase = new PedidoDatabase();
            return pedidoDatabase.Consultar(cliente);
        }

    }
}

