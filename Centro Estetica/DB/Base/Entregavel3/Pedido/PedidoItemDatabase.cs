using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Pedido
{
    class PedidoItemDatabase
    {
        public int Salvar(PedidoItemDTO pedidoitem)
        {
            string script =
                @"INSERT INTO tb_pedido_item (id_produto, id_pedido)
                       VALUES (@id_produto, @id_pedido)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", pedidoitem.IdProduto));
            parms.Add(new MySqlParameter("id_pedido", pedidoitem.IdPedido));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_pedido_item WHERE id_pedido_item = @id_pedido_item";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido_item", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PedidoItemDTO> ConsultarPorPedido(int idPedido)
        {
            string script = @"SELECT * FROM tb_pedido_item WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", idPedido));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoItemDTO> lista = new List<PedidoItemDTO>();
            while (reader.Read())
            {
                PedidoItemDTO dto = new PedidoItemDTO();
                dto.Id = reader.GetInt32("id_pedido_item");
                dto.IdPedido = reader.GetInt32("id_pedido");
                dto.IdProduto = reader.GetInt32("id_produto");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
