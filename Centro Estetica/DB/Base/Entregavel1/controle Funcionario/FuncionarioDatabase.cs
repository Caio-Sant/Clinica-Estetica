using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario
{
    class FuncionarioDatabase
    {
        public FuncionarioDTO Logar(string login, string senha)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE ds_login = @ds_login AND ds_senha = @ds_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_login", login));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionarioDTO funcionario = null;
            if (reader.Read())
            {
                FuncionarioDTO novofuncionario = new FuncionarioDTO();
                novofuncionario.Id = reader.GetInt32("id_funcionario");
                novofuncionario.Nome = reader.GetString("nm_completo");
                novofuncionario.Sexo = reader.GetString("ds_sexo");
                novofuncionario.DtNascimento = reader.GetDateTime("dt_nascimento");
                novofuncionario.Rg = reader.GetString("ds_rg");
                novofuncionario.Cpf = reader.GetString("ds_cpf");
                novofuncionario.Telefone = reader.GetString("ds_telefone");
                novofuncionario.Cep = reader.GetString("ds_cep");
                novofuncionario.NdaCasa = reader.GetString("ds_ndacasa");
                novofuncionario.Email = reader.GetString("ds_email");
                novofuncionario.DataAdm = reader.GetDateTime("dt_admissao");
                novofuncionario.Cargo = reader.GetString("ds_cargo");
                novofuncionario.Senha = reader.GetString("ds_senha");
                novofuncionario.Login = reader.GetString("ds_login");
                novofuncionario.PermissaoAdm = reader.GetBoolean("bt_permissaoadm");
                novofuncionario.Salario = reader.GetDecimal("vl_salario");

            }
            reader.Close();
            return funcionario;
        }

        public int Salvar(FuncionarioDTO funcionario)
        {
            string script =
                @"INSERT INTO tb_funcionario (id_funcionario, nm_completo, ds_sexo, dt_nascimento, ds_rg, ds_cpf, ds_telefone,
                    ds_cep, ds_ndacasa, ds_email, dt_admissao, ds_cargo, ds_login, ds_senha, bt_permissaoadm, vl_salario)
                        VALUES ( @id_funcionario, @nm_completo, @ds_sexo, @dt_nascimento, @ds_rg, @ds_cpf, @ds_telefone,
                    @ds_cep, @ds_ndacasa, @ds_email, @dt_admissao, @ds_cargo, @ds_login, @ds_senha, @bt_permissaoadm, @vl_salario)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", funcionario.Id));
            parms.Add(new MySqlParameter("nm_completo", funcionario.Nome));
            parms.Add(new MySqlParameter("ds_sexo", funcionario.Sexo));
            parms.Add(new MySqlParameter("dt_nascimento", funcionario.DtNascimento));
            parms.Add(new MySqlParameter("ds_rg", funcionario.Rg));
            parms.Add(new MySqlParameter("ds_cpf", funcionario.Cpf));
            parms.Add(new MySqlParameter("ds_telefone", funcionario.Telefone));
            parms.Add(new MySqlParameter("ds_cep", funcionario.Cep));
            parms.Add(new MySqlParameter("ds_ndacasa", funcionario.NdaCasa));
            parms.Add(new MySqlParameter("ds_email", funcionario.Email));
            parms.Add(new MySqlParameter("dt_admissao", funcionario.DataAdm));
            parms.Add(new MySqlParameter("ds_cargo", funcionario.Cargo));
            parms.Add(new MySqlParameter("ds_login", funcionario.Login));
            parms.Add(new MySqlParameter("ds_senha", funcionario.Senha));
            parms.Add(new MySqlParameter("bt_permissaoadm", funcionario.PermissaoAdm));
            parms.Add(new MySqlParameter("vl_salario", funcionario.Salario));
            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

       


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FuncionarioDTO> Listar()
        {
            string script =
                 @"SELECT * FROM tb_funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO novofuncionario = new FuncionarioDTO();
                novofuncionario.Id = reader.GetInt32("id_funcionario");
                novofuncionario.Nome = reader.GetString("nm_completo");
                novofuncionario.Sexo = reader.GetString("ds_sexo");
                novofuncionario.DtNascimento = reader.GetDateTime("dt_nascimento");
                novofuncionario.Rg = reader.GetString("ds_rg");
                novofuncionario.Cpf = reader.GetString("ds_cpf");
                novofuncionario.Telefone = reader.GetString("ds_telefone");
                novofuncionario.Cep = reader.GetString("ds_cep");
                novofuncionario.NdaCasa = reader.GetString("ds_ndacasa");
                novofuncionario.Email = reader.GetString("ds_email");
                novofuncionario.DataAdm = reader.GetDateTime("dt_admissao");
                novofuncionario.Cargo = reader.GetString("ds_cargo");
                novofuncionario.Senha = reader.GetString("ds_senha");
                novofuncionario.Login = reader.GetString("ds_login");
                novofuncionario.PermissaoAdm = reader.GetBoolean("bt_permissaoadm");
                novofuncionario.Salario = reader.GetDecimal("vl_salario");

                funcionarios.Add(novofuncionario);

            }
            reader.Close();
            return funcionarios;
        }

        public List<FuncionarioDTO> Consultar(string funcionario)
        {

            string script =
                @"SELECT * FROM tb_funcionario
                  WHERE nm_completo like @nm_completo";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_completo", "%" + funcionario + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (reader.Read())
            {

                FuncionarioDTO novofuncionario = new FuncionarioDTO();
                novofuncionario.Id = reader.GetInt32("id_funcionario");
                novofuncionario.Nome = reader.GetString("nm_completo");
                novofuncionario.Sexo = reader.GetString("ds_sexo");
                novofuncionario.DtNascimento = reader.GetDateTime("dt_nascimento");
                novofuncionario.Rg = reader.GetString("ds_rg");
                novofuncionario.Cpf = reader.GetString("ds_cpf");
                novofuncionario.Telefone = reader.GetString("ds_telefone");
                novofuncionario.Cep = reader.GetString("ds_cep");
                novofuncionario.NdaCasa = reader.GetString("ds_ndacasa");
                novofuncionario.Email = reader.GetString("ds_email");
                novofuncionario.DataAdm = reader.GetDateTime("dt_admissao");
                novofuncionario.Cargo = reader.GetString("ds_cargo");
                novofuncionario.Senha = reader.GetString("ds_senha");
                novofuncionario.Login = reader.GetString("ds_login");
                novofuncionario.PermissaoAdm = reader.GetBoolean("bt_permissaoadm");
                novofuncionario.Salario = reader.GetDecimal("vl_salario");

                funcionarios.Add(novofuncionario);

            }
            reader.Close();
            return funcionarios;

        }
    }
}
