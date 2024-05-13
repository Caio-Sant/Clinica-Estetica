using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.Foncesedor
{
    class Fornecedorbusiness
    {
         FonecedorDatabase db = new  FonecedorDatabase();
        public int Salvar(FornecedorDTO fornecedor)
        {
            if (fornecedor.Nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (fornecedor.CNPJ == string.Empty)
            {
                throw new ArgumentException("CNPJ é obrigatório.");
            }
            if (fornecedor.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (fornecedor.CEP == string.Empty)
            {
                throw new ArgumentException("CEP é obrigatório.");
            }
            if (fornecedor.Complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }
            if (fornecedor.NdaCasa == string.Empty)
            {
                throw new ArgumentException("Nº da Casa é obrigatório.");
            }
            if (fornecedor.Email == string.Empty)
            {
                throw new ArgumentException("Email é obrigatório.");
            }

            return db.Salvar(fornecedor);

        }

        public List<FornecedorDTO> Consultar(string fornecedor)
        {
            return db.Consultar(fornecedor);
        }

        public List<FornecedorDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
