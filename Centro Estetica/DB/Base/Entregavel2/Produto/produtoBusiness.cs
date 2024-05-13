using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.Produto
{
    class produtoBusiness
    {
        ProdutoDatabase db = new ProdutoDatabase();

        public int Salvar(ProdutoDTO produto)
        {
            if (produto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }

            if (produto.Descrição == string.Empty)
            {
                throw new ArgumentException("Descrição é obrigatório.");
            }
            if (produto.Valor <= 0)
            {
                throw new ArgumentException("Valor do produto é obrigatório.");
            }

            return db.Salvar(produto);

        }

        public void Alterar(ProdutoDTO produto)
        {
            if (produto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }

            if (produto.Descrição == string.Empty)
            {
                throw new ArgumentException("Descrição é obrigatório.");
            }
            if (produto.Valor <= 0)
            {
                throw new ArgumentException("Valor do produto é obrigatório.");
            }

            db.Alterar(produto);
        }

        public List<ProdutoDTO> Consultar(string produto)
        {
            return db.Consultar(produto);
        }

        public List<ProdutoDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
