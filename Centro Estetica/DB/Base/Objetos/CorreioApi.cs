using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Centro_Estetica.DB.Base.Objetos
{
    class CorreioApi
    {
        public CorreioResponde Buscar(string cep)
        {
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            string resposta = rest.DownloadString("https://viacep.com.br/ws/" + cep + "/json");

            CorreioResponde correio = JsonConvert.DeserializeObject<CorreioResponde>(resposta);
            return correio;
        }
    }
}
