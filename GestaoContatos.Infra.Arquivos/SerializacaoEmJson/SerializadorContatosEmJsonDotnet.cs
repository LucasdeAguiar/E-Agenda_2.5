using GestaoContatos.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContatos.Infra.Arquivos.SerializacaoEmJson
{
    public class SerializadorContatosEmJsonDotnet : ISerializadorContatos
    {
        private const string arquivoContatos = @"C:\temp\contatos2.json";

        public List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            string contatosJson = File.ReadAllText(arquivoContatos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Contato>>(contatosJson, settings);
        }

        public void GravarContatosEmArquivo(List<Contato> contatos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string contatosJson = JsonConvert.SerializeObject(contatos, settings);

            File.WriteAllText(arquivoContatos, contatosJson);
        }
    }
}
