using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class vwcompra
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Quantidade { get; set; }

        public decimal Total { get; set; }
    }
}
