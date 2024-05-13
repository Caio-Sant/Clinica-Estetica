using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class ComprasDatabase
    {
        public int Salvar(ComprasDTO compras)
        {
            string script =
                @"INSERT INTO tb_compra
                (
                id_compra,
                id_fornecedor,   
                nm_compra,
                qtd_unidade,     
                vl_compra,
                dt_compra
                )
                VALUES
                (
                @id_compra,
                @id_fornecedor,   
                @nm_compra,
                @qtd_unidade,     
                @vl_compra,
                @dt_compra
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", compras.Id));
            parms.Add(new MySqlParameter("id_fornecedor", compras.IdFornec));
            parms.Add(new MySqlParameter("nm_compra", compras.Nome));
            parms.Add(new MySqlParameter("qtd_unidade", compras.Quantidade));
            parms.Add(new MySqlParameter("vl_compra", compras.Total));
            parms.Add(new MySqlParameter("dt_compra", compras.Data));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_compra WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ComprasDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_compra";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ComprasDTO> compras = new List<ComprasDTO>();
            while (reader.Read())
            {

                ComprasDTO novacompra = new ComprasDTO();
                novacompra.Id = reader.GetInt32("id_compra");
                novacompra.IdFornec = reader.GetInt32("id_fornecedor");
                novacompra.Nome = reader.GetString("nm_compra");
                novacompra.Quantidade = reader.GetInt32("qtd_unidade");
                novacompra.Total = reader.GetDecimal("vl_compra");
                novacompra.Data = reader.GetDateTime("dt_compra");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
        public int DarBaixaEstoque(ComprasDTO dto)
        {
            string script = @" UPDATE tb_compra 
                                  SET qtd_unidade = qtd_unidade - @qtd_unidade
                                WHERE id_compra = @id_compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", dto.Id));
            parms.Add(new MySqlParameter("qtd_unidade", dto.Quantidade));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ComprasDTO> Consultar(string compra)
        {

            string script =
                @"SELECT * FROM tb_compra
                  WHERE nm_compra like @nm_compra";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_compra", "%" + compra + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ComprasDTO> compras = new List<ComprasDTO>();
            while (reader.Read())
            {

                ComprasDTO novacompra = new ComprasDTO();
                novacompra.Id = reader.GetInt32("id_compra");
                novacompra.IdFornec = reader.GetInt32("id_fornecedor");
                novacompra.Nome = reader.GetString("nm_compra");
                novacompra.Quantidade = reader.GetInt32("qtd_unidade");
                novacompra.Total = reader.GetDecimal("vl_compra");
                novacompra.Data = reader.GetDateTime("dt_compra");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
    }
}
