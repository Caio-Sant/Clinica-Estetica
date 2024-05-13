using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class vwCompra
    {
        public int id_compra { get; set; }

        public string nm_nome { get; set; }

        public int qtd_itens { get; set; }

        public decimal vl_total
        {
            get; set;
        }
    }
}