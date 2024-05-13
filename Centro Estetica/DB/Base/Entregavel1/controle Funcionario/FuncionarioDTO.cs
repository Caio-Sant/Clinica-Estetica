using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario
{
    class FuncionarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string NdaCasa { get; set; }
        public string Email { get; set; }
        public DateTime DataAdm { get; set; }
        public string Cargo { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public bool PermissaoAdm { get; set; }
        public decimal Salario { get; set; }
    }
}
