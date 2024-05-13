using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel4.FluxoDCaixa
{
    class FluxoCaixaDTO
    {
        public DateTime Data { get; set; }

        public decimal Total { get; set; }

        public string Movimento { get; set; }

        public string Operacao { get; set; }
    }
}
    