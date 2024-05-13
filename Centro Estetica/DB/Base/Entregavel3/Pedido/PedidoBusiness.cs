using Centro_Estetica.DB.Base.Entregavel2.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Pedido
{
    class pedidoBusiness
    {
        public int Salvar(PedidoDTO pedido, List<ProdutoDTO> produtos)
        {
            if (pedido.FormaPagamento == "Selecione")
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

        public List<PedidoConsultarView> Consultar(string cliente)
        {
            PedidoDatabase pedidoDatabase = new PedidoDatabase();
            return pedidoDatabase.Consultar(cliente);
        }
    }
}
