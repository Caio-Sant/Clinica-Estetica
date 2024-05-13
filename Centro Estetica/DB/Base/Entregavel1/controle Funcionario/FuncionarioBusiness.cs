using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario
{
    class FuncionarioBusiness
    {
        FuncionarioDatabase db = new FuncionarioDatabase();
        public FuncionarioDTO Logar(string login, string senha)
        {
            if (login == string.Empty)
            {
                throw new ArgumentException("Usuário é obrigatório.");
            }

            if (senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatório.");
            }

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Logar(login, senha);
        }

        public int Salvar(FuncionarioDTO funcionario)
        {
            if (funcionario.Nome == string.Empty)
            {
                throw new ArgumentException("Nome Completo é obrigatório.");
            }
            if (funcionario.Sexo == string.Empty)
            {
                throw new ArgumentException("Sexo é obrigatório.");
            }
            if (funcionario.DtNascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }

            if (funcionario.DtNascimento.Year > 1999)
            {
                throw new ArgumentException("Tem que ser maior de 18");
            }
            if (funcionario.Rg == string.Empty)
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (funcionario.Cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (funcionario.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (funcionario.Cep == string.Empty)
            {
                throw new ArgumentException("CEP é obrigatório.");
            }
            if (funcionario.NdaCasa == string.Empty)
            {
                throw new ArgumentException("Nº da Casa é obrigatório.");
            }
            if (funcionario.Email == string.Empty)
            {
                throw new ArgumentException("E-mail é obrigatório.");
            }
            if (funcionario.DataAdm > DateTime.Now)
            {
                throw new ArgumentException("Data de admissão é obrigatório.");
            }
            if (funcionario.Login == string.Empty)
            {
                throw new ArgumentException("Login para o sistema é obrigatório");
            }
            if (funcionario.Senha == string.Empty)
            {
                throw new ArgumentException("Senha para o sistema é obrigatório");
            }

            return db.Salvar(funcionario);

        }

        public void Alterar(FuncionarioDTO funcionario)
        {
            if (funcionario.Nome == string.Empty)
            {
                throw new ArgumentException("Nome Completo é obrigatório.");
            }
            if (funcionario.Sexo == string.Empty)
            {
                throw new ArgumentException("Sexo é obrigatório.");
            }
            if (funcionario.DtNascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }

            if (funcionario.DtNascimento.Year > 1999)
            {
                throw new ArgumentException("Tem que ser maior de 18");
            }
            if (funcionario.Rg == string.Empty)
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (funcionario.Cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (funcionario.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (funcionario.Cep == string.Empty)
            {
                throw new ArgumentException("CEP é obrigatório.");
            }
            if (funcionario.NdaCasa == string.Empty)
            {
                throw new ArgumentException("Nímero da casa é obrigatório.");
            }
            if (funcionario.Email == string.Empty)
            {
                throw new ArgumentException("E-mail é obrigatório.");
            }
            if (funcionario.DataAdm > DateTime.Now)
            {
                throw new ArgumentException("Data de admissão é obrigatório.");
            }
            if (funcionario.Login == string.Empty)
            {
                throw new ArgumentException("Login para o sistema é obrigatório");
            }
            if (funcionario.Senha == string.Empty)
            {
                throw new ArgumentException("Senha para o sistema é obrigatório");
            }

            db.Salvar(funcionario);
        }

        public List<FuncionarioDTO> Consultar(string funcionario)
        {
            return db.Consultar(funcionario);
        }

        public List<FuncionarioDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
