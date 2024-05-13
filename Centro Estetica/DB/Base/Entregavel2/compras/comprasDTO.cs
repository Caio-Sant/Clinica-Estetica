using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class ComprasDTO
    {
        public int Id { get; set; }
        public int IdFornec { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
        public DateTime Data { get; set; }
    }
}
