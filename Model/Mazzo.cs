using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ProgettoInformatica.Model
{
    public class Mazzo
    {
        public string TipoMazzo { get; set; } = string.Empty;
        private Carta[] carte;


        public Mazzo()
        {
            //TipoMazzo = json;
            carte = new Carta[20];
        }

        public List<Mazzo> UseFileReadAllTextWithSystemTextJson()
        {
            var _options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            using FileStream streamReader = File.OpenRead("mazzo.json");
            var json = streamReader.ReadToEnd();
            List<Mazzo> list = JsonSerializer.Deserialize<List<Mazzo>>(json, _options);
            return list;
        }


    }
}
