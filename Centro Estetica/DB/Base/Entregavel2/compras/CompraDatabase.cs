using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.compras
{
    class CompraDatabase
    {
        public int Salvar(CompraDTO compras)
        {
            string script =
                @"INSERT INTO tb_compraitem
                (
                id_compraitem,
                id_compra,   
                id_produto  
                )
                VALUES
                (
                @id_compraitem,
                @id_compra,   
                @id_produto
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compraitem", compras.id_compraitem));
            parms.Add(new MySqlParameter("id_compra", compras.id_compra));
            parms.Add(new MySqlParameter("id_produto", compras.id_produto));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_compraitem WHERE id_compraitem = @id_compraitem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compraitem", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<CompraDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_compraitem";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CompraDTO> compras = new List<CompraDTO>();
            while (reader.Read())
            {

                CompraDTO novacompra = new CompraDTO();
                novacompra.id_compraitem = reader.GetInt32("id_compraitem");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_produto = reader.GetInt32("id_produto");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }

        public List<CompraDTO> Consultar(string produto)
        {

            string script =
                @"SELECT * FROM tb_compraitem
                  WHERE id_produto like @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<CompraDTO> compras = new List<CompraDTO>();
            while (reader.Read())
            {

                CompraDTO novacompra = new CompraDTO();
                novacompra.id_compraitem = reader.GetInt32("id_compraitem");
                novacompra.id_compra = reader.GetInt32("id_compra");
                novacompra.id_produto = reader.GetInt32("id_produto");

                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }


        public void Alterar(CompraDTO compra)
        {
            string script =
            @"UPDATE tb_compraitem
                 SET 
                  id_compraitem = @id_compraitem,
                  id_compra = @id_compra,
                  id_produto = @id_produto,
                  WHERE id_compraitem = @id_compraitem";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compraitem", compra.id_compraitem));
            parms.Add(new MySqlParameter("id_compra", compra.id_compra));
            parms.Add(new MySqlParameter("id_produto", compra.id_produto));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<vwcompra> ConsultarView(string produto)
        {

            string script =
                @"SELECT * FROM vw_consultar_item
                  WHERE nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<vwcompra> compras = new List<vwcompra>();
            while (reader.Read())
            {

                vwcompra novacompra = new vwcompra();
                novacompra.Nome = reader.GetString("nm_nome");
                novacompra. Id = reader.GetInt32("id_compra");
                novacompra.Quantidade = reader.GetString("qtd_itens");
                novacompra.Total = reader.GetDecimal("vl_total");


                compras.Add(novacompra);

            }
            reader.Close();
            return compras;
        }
    }
}
