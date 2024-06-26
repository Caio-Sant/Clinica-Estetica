﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel2.Produto
{
    class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO produto)
        {
            string script =
                @"INSERT INTO tb_produto
                (
                id_produto,
                nm_nome,   
                ds_descricao,
                vl_produto
                )
                VALUES
                (
                @id_produto,
                @nm_nome,   
                @ds_descricao,
                @vl_produto
                )";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.Id));
            parms.Add(new MySqlParameter("nm_nome", produto.Nome));
            parms.Add(new MySqlParameter("ds_descricao", produto.Descrição));
            parms.Add(new MySqlParameter("vl_produto", produto.Valor));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public void Alterar(ProdutoDTO produto)
        {
            string script =
            @"UPDATE tb_produto
                 SET
                  nm_nome = @nm_nome,
                  ds_descricao = @ds_descricao,
                  vl_produto=@vl_produto
                  WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", produto.Id));
            parms.Add(new MySqlParameter("nm_nome", produto.Nome));
            parms.Add(new MySqlParameter("ds_descricao", produto.Descrição));
            parms.Add(new MySqlParameter("vl_produto", produto.Valor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_produto WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<ProdutoDTO> Listar()
        {
            string script =
                @"SELECT * FROM tb_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO novoproduto = new ProdutoDTO();
                novoproduto.Id = reader.GetInt32("id_produto");
                novoproduto.Nome = reader.GetString("nm_nome");
                novoproduto.Descrição = reader.GetString("ds_descricao");
                novoproduto.Valor = reader.GetDecimal("vl_produto");

                produtos.Add(novoproduto);

            }
            reader.Close();
            return produtos;
        }

        public List<ProdutoDTO> Consultar(string produto)
        {

            string script =
                @"SELECT * FROM tb_produto
                  WHERE nm_nome like @nm_nome";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", "%" + produto + "%"));
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            while (reader.Read())
            {

                ProdutoDTO novoproduto = new ProdutoDTO();
                novoproduto.Id = reader.GetInt32("id_produto");
                novoproduto.Nome = reader.GetString("nm_nome");
                novoproduto.Descrição = reader.GetString("ds_descricao");
                novoproduto.Valor = reader.GetDecimal("vl_produto");

                produtos.Add(novoproduto);

            }
            reader.Close();
            return produtos;

        }
    }
}