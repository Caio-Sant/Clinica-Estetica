using Centro_Estetica.DB.Base.Entregavel3.Controlepedido;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel3.Pedido
{
    class PedidoDatabase
    {

        public int Salvar(PedidoDTO pedido)
        {
            string script =
                @"INSERT INTO tb_pedido (id_pedido, id_paciente, dt_venda, ds_formapagamento)
                       VALUES (@id_pedido, @id_paciente, @dt_venda, @ds_formapagamento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", pedido.Id));
            parms.Add(new MySqlParameter("id_paciente", pedido.IdPaciente));
            parms.Add(new MySqlParameter("dt_venda", pedido.Data));
            parms.Add(new MySqlParameter("ds_formapagamento", pedido.FormaPagamento));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public void Remover(int id)
        {
            string script =
            @"DELETE FROM tb_pedido WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public List<PedidoConsultarView> Consultar(string cliente)
        {
            string script = @"SELECT * FROM vw_pedido_consultar WHERE nm_completo like @nm_completo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_completo", cliente + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoConsultarView> lista = new List<PedidoConsultarView>();
            while (reader.Read())
            {
                PedidoConsultarView dto = new PedidoConsultarView();
                dto.Id = reader.GetInt32("id_pedido");
                dto.Nome = reader.GetString("nm_completo");
                dto.Data = reader.GetDateTime("dt_venda");
                dto.Total = reader.GetDecimal("vl_produto");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
