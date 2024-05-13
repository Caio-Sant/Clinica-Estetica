using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Pedido
{
    class PedidoDTO
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Data { get; set; }
        public string FormaPagamento { get; set; }
    }
}
