using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel4.FluxoDCaixa
{
    class FluxoCaixaBusiness
    {
        public List<FluxoCaixaDTO> filtro(DateTime start, DateTime end)
        {
            FluxoCaixaDatabase db = new FluxoCaixaDatabase();
            List<FluxoCaixaDTO> dados = db.Filtro(start, end);
            return dados;
        }
    }
}
