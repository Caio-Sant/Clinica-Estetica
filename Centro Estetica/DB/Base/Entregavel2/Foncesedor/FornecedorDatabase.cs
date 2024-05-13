using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.Foncesedor
{
    class FonecedorDatabase
    {
        public int Salvar(FornecedorDTO fornecedor)
        {
            string script =
                @"INSERT INTO tb_fornecedor (id_fornecedor, nm_nome, ds_cnpj, ds_telefone, ds_cep, ds_complemento, ds_ndacasa, ds_email)
                   VALUES (@id_fornecedor, @nm_nome, @ds_cnpj, @ds_telefone, @ds_cep, @ds_complemento, @ds_ndacasa, @ds_email)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", fornecedor.Id));
            parms.Add(new MySqlParameter("nm_nome", fornecedor.Nome));
            parms.Add(new MySqlParameter("ds_cnpj", fornecedor.CNPJ));
            parms.Add(new MySqlParameter("ds_telefone", fornecedor.Telefone));
            parms.Add(new MySqlParameter("ds_cep", fornecedor.CEP));
            parms.Add(new MySqlParameter("ds_complemento", fornecedor.Complemento));
            parms.Add(new MySqlParameter("ds_ndacasa", fornecedor.NdaCasa));
            parms.Add(new MySqlParameter("ds_email", fornecedor.Email));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_fornecedor WHERE id_fornecedor = @id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<FornecedorDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {

                FornecedorDTO novofornecedor = new FornecedorDTO();
                novofornecedor.Id = reader.GetInt32("id_fornecedor");
                novofornecedor.Nome = reader.GetString("nm_nome");
                novofornecedor.CNPJ = reader.GetString("ds_cnpj");
                novofornecedor.Telefone = reader.GetString("ds_telefone");
                novofornecedor.CEP = reader.GetString("ds_cep");
                novofornecedor.Complemento = reader.GetString("ds_complemento");
                novofornecedor.NdaCasa = reader.GetString("ds_ndacasa");
                novofornecedor.Email = reader.GetString("ds_email");

                fornecedores.Add(novofornecedor);

            }
            reader.Close();
            return fornecedores;
        }

        public List<FornecedorDTO> Consultar(string fornecedor)
        {

            string script =
                @"SELECT * FROM tb_fornecedor
                  WHERE nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", "%" + fornecedor + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {

                FornecedorDTO novofornecedor = new FornecedorDTO();
                novofornecedor.Id = reader.GetInt32("id_fornecedor");
                novofornecedor.Nome = reader.GetString("nm_nome");
                novofornecedor.CNPJ = reader.GetString("ds_cnpj");
                novofornecedor.Telefone = reader.GetString("ds_telefone");
                novofornecedor.CEP = reader.GetString("ds_cep");
                novofornecedor.Complemento = reader.GetString("ds_complemento");
                novofornecedor.NdaCasa = reader.GetString("ds_ndacasa");
                novofornecedor.Email = reader.GetString("ds_email");

                fornecedores.Add(novofornecedor);

            }
            reader.Close();
            return fornecedores;

        }
    }
}
