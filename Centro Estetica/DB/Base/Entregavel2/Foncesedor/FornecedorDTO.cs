using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.Foncesedor
{
    class FornecedorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string NdaCasa { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
    }
}
