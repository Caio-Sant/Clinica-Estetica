using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class CompraBusiness
    {
        CompraDatabase db = new CompraDatabase();

        public int Salvar(CompraDTO compra)
        {
            return db.Salvar(compra);
        }

        public void Alterar(CompraDTO compra)
        {

            db.Alterar(compra);
        }

        public List<CompraDTO> Consultar(string produto)
        {
            return db.Consultar(produto);
        }

        public List<CompraDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
        public List<vwcompra> ConsultarView(string produto)
        {
            return db.ConsultarView(produto);
        }
    }
}
