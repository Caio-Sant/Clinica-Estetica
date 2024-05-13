using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class ComprasBusiness
    {
        ComprasDatabase db = new ComprasDatabase();

        public int Salvar(ComprasDTO compra)
        {
            if (compra.Nome == string.Empty)
            {
                throw new ArgumentException("Nome da compra é obrigatório.");
            }
            if (compra.Quantidade ==  0)
            {
                throw new ArgumentException("Quantidade é obrigatória.");
            }
            if (compra.Total <= 0)
            {
                throw new ArgumentException("Valor da compra é obrigatório.");
            }

            return db.Salvar(compra);

        }
        public int SalvarItem(CompraDTO produto, List<CompraDTO> compras)
        {



            int idproduto = produto.id_produto;


            CompraBusiness itemBusiness = new CompraBusiness();
            foreach (CompraDTO item in compras)
            {
                CompraDTO itemDto = new CompraDTO();
                itemDto.id_compra = item.id_compra;
                itemDto.id_produto = idproduto;

                itemBusiness.Salvar(itemDto);
            }

            return idproduto;
        }

        public int DarBaixa(ComprasDTO dto)
        {
            ComprasDatabase db = new ComprasDatabase();
            return db.DarBaixaEstoque(dto);
        }

        public List<ComprasDTO> Consultar(string compra)
        {
            return db.Consultar(compra);
        }

        public List<ComprasDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
