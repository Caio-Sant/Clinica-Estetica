using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Pedido
{
    class PedidoItemBusiness
    {
        public int Salvar(PedidoItemDTO dto)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            return db.Salvar(dto);
        }

        public void Remover(int id)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            db.Remover(id);
        }

        public List<PedidoItemDTO> ConsultarPorPedido(int idPedido)
        {
            PedidoItemDatabase db = new PedidoItemDatabase();
            return db.ConsultarPorPedido(idPedido);
        }
    }
}
