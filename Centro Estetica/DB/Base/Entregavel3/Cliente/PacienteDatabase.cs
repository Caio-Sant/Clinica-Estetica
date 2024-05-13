using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Cliente
{
    class PacientesDatabase
    {
        public int Salvar(PacientesDTO pacientes)
        {
            string script =
                 @"INSERT INTO tb_paciente (id_paciente, nm_completo, ds_rg, ds_cpf, ds_email, dt_nascimento, ds_telefone, ds_celular, ds_cep, ds_rua, ds_ndacasa, ds_complemento)
                        VALUES (@id_paciente, @nm_completo, @ds_rg, @ds_cpf, @ds_email, @dt_nascimento, @ds_telefone, @ds_celular, @ds_cep, @ds_rua, @ds_ndacasa, @ds_complemento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_paciente", pacientes.Id));
            parms.Add(new MySqlParameter("nm_completo", pacientes.Nome));
            parms.Add(new MySqlParameter("ds_rg", pacientes.Rg));
            parms.Add(new MySqlParameter("ds_cpf", pacientes.Cpf));
            parms.Add(new MySqlParameter("ds_email", pacientes.Email));
            parms.Add(new MySqlParameter("dt_nascimento", pacientes.DtNascimento));
            parms.Add(new MySqlParameter("ds_telefone", pacientes.Telefone));
            parms.Add(new MySqlParameter("ds_celular", pacientes.Celular));
            parms.Add(new MySqlParameter("ds_cep", pacientes.Cep));
            parms.Add(new MySqlParameter("ds_rua", pacientes.Rua));
            parms.Add(new MySqlParameter("ds_ndacasa", pacientes.NdaCasa));
            parms.Add(new MySqlParameter("ds_complemento", pacientes.Complemento));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(PacientesDTO pacientes)
        {

            string script =
            @"UPDATE tb_paciente
                 SET
                  nm_completo = @nm_completo,
	              ds_rg = @ds_rg,
	              ds_cpf = @ds_cpf,
	              ds_email = @ds_email,
	              dt_nascimento = @dt_nascimento,
	              ds_telefone = @ds_telefone,
	              ds_celular = @ds_celular,
	              ds_cep = @ds_cep,
	              ds_rua = @ds_rua,
                  ds_numero = @ds_numero,
                  ds_complemento = @ds_complemento;
                  WHERE id_paciente = @id_paciente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_paciente", pacientes.Id));
            parms.Add(new MySqlParameter("nm_completo", pacientes.Nome));
            parms.Add(new MySqlParameter("ds_rg", pacientes.Rg));
            parms.Add(new MySqlParameter("ds_cpf", pacientes.Cpf));
            parms.Add(new MySqlParameter("ds_email", pacientes.Email));
            parms.Add(new MySqlParameter("dt_nascimento", pacientes.DtNascimento));
            parms.Add(new MySqlParameter("ds_telefone", pacientes.Telefone));
            parms.Add(new MySqlParameter("ds_celular", pacientes.Celular));
            parms.Add(new MySqlParameter("ds_cep", pacientes.Cep));
            parms.Add(new MySqlParameter("ds_rua", pacientes.Rua));
            parms.Add(new MySqlParameter("ds_numero", pacientes.NdaCasa));
            parms.Add(new MySqlParameter("ds_complemento", pacientes.Complemento));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_paciente WHERE id_paciente = @id_paciente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_paciente", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PacientesDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_paciente";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PacientesDTO> pacientes = new List<PacientesDTO>();
            while (reader.Read())
            {

                PacientesDTO newpaciente = new PacientesDTO();
                newpaciente.Id = reader.GetInt32("id_paciente");
                newpaciente.Nome = reader.GetString("nm_completo");
                newpaciente.Rg = reader.GetString("ds_rg");
                newpaciente.Cpf = reader.GetString("ds_cpf");
                newpaciente.Email = reader.GetString("ds_email");
                newpaciente.DtNascimento = reader.GetDateTime("dt_nascimento");
                newpaciente.Telefone = reader.GetString("ds_telefone");
                newpaciente.Celular = reader.GetString("ds_celular");
                newpaciente.Cep = reader.GetString("ds_cep");
                newpaciente.Rua = reader.GetString("ds_rua");
                newpaciente.NdaCasa = reader.GetString("ds_numero");
                newpaciente.Complemento = reader.GetString("ds_complemento");

                pacientes.Add(newpaciente);

            }
            reader.Close();

            return pacientes;
        }

        public List<PacientesDTO> Consultar(string pacientes)
        {

            string script =
                @"SELECT * FROM tb_paciente
                  WHERE nm_completo like @nm_completo";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_completo", "%" + pacientes + "%"));

            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<PacientesDTO> paciente = new List<PacientesDTO>();
            while (reader.Read())
            {

                PacientesDTO newpaciente = new PacientesDTO();
                newpaciente.Id = reader.GetInt32("id_paciente");
                newpaciente.Nome = reader.GetString("nm_completo");
                newpaciente.Rg = reader.GetString("ds_rg");
                newpaciente.Cpf = reader.GetString("ds_cpf");
                newpaciente.Email = reader.GetString("ds_email");
                newpaciente.DtNascimento = reader.GetDateTime("dt_nascimento");
                newpaciente.Telefone = reader.GetString("ds_telefone");
                newpaciente.Celular = reader.GetString("ds_celular");
                newpaciente.Cep = reader.GetString("ds_cep");
                newpaciente.Rua = reader.GetString("ds_rua");
                newpaciente.NdaCasa = reader.GetString("ds_ndacasa");
                newpaciente.Complemento = reader.GetString("ds_complemento");

                paciente.Add(newpaciente);

            }
            reader.Close();

            return paciente;

        }
    }
}
