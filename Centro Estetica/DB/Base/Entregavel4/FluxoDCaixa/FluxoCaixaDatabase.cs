using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica.DB.Base.Entregavel4.FluxoDCaixa
{
    class FluxoCaixaDatabase
    {
        public List<FluxoCaixaDTO> Filtro(DateTime start, DateTime end)
        {

            string script = @"select * from fluxo_view where dt_data >= @start and @end <= dt_data";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FluxoCaixaDTO> lista = new List<FluxoCaixaDTO>();
            while (reader.Read() == true)
            {
                FluxoCaixaDTO vw = new FluxoCaixaDTO();
                vw.Data = reader.GetDateTime("dt_data");
                vw.Total = reader.GetDecimal("vl_valor");
                vw.Operacao = reader.GetString("ds_caixa");
                vw.Movimento = reader.GetString("ds_movimento");


                lista.Add(vw);
            }
            return lista;
        }
        }
}
