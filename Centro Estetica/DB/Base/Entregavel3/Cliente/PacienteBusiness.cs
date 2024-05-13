using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Cliente
{
    class PacientesBusiness
    {
        PacientesDatabase db = new PacientesDatabase();

        public int Salvar(PacientesDTO pacientes)
        {
            if (pacientes.Nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (pacientes.Rg == string.Empty)
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (pacientes.Cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (pacientes.Email == string.Empty)
            {
                throw new ArgumentException("E-mail é obrigatório.");
            }
            if (pacientes.DtNascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }
            if (pacientes.DtNascimento.Year > 1999)
            {
                throw new ArgumentException("Tem que ser maior de 18");
            }
            if (pacientes.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (pacientes.Celular == string.Empty)
            {
                throw new ArgumentException("Celular é obrigatório.");
            }
            if (pacientes.Cep == string.Empty)
            {
                throw new ArgumentException("CEP é obrigatório.");
            }
            if (pacientes.Rua == string.Empty)
            {
                throw new ArgumentException("Rua é obrigatório.");
            }
            if (pacientes.NdaCasa == string.Empty)
            {
                throw new ArgumentException("Numero da casa é obrigatório.");
            }
            if (pacientes.Complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }

            return db.Salvar(pacientes);

        }

        public void Alterar(PacientesDTO pacientes)
        {
            if (pacientes.Nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório.");
            }
            if (pacientes.Rg == string.Empty)
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (pacientes.Cpf == string.Empty)
            {
                throw new ArgumentException("CPF é obrigatório.");
            }
            if (pacientes.Email == string.Empty)
            {
                throw new ArgumentException("E-mail é obrigatório.");
            }
            if (pacientes.DtNascimento > DateTime.Now)
            {
                throw new ArgumentException("Data não valida");
            }
            if (pacientes.DtNascimento.Year > 1999)
            {
                throw new ArgumentException("Tem que ser maior de 18");
            }
            if (pacientes.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
            if (pacientes.Celular == string.Empty)
            {
                throw new ArgumentException("Celular é obrigatório.");
            }
            if (pacientes.Cep == string.Empty)
            {
                throw new ArgumentException("CEP é obrigatório.");
            }
            if (pacientes.Rua == string.Empty)
            {
                throw new ArgumentException("Rua é obrigatório.");
            }
            if (pacientes.NdaCasa == string.Empty)
            {
                throw new ArgumentException("Numero da casa é obrigatório.");
            }
            if (pacientes.Complemento == string.Empty)
            {
                throw new ArgumentException("Complemento é obrigatório.");
            }

            db.Alterar(pacientes);
        }

        public List<PacientesDTO> Consultar(string pacientes)
        {
            return db.Consultar(pacientes);
        }

        public List<PacientesDTO> Listar()
        {
            return db.Listar();
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
