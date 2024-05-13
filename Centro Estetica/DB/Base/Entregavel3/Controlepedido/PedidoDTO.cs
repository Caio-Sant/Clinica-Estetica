using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Controlepedido
{
    class PedidoDTO
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdProduto { get; set; }
        public DateTime Data { get; set; }
        public string Pagamento { get; set; }

    }
}
