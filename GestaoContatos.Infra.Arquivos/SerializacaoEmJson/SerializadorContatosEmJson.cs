using GestaoContatos.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestaoContatos.Infra.Arquivos.SerializacaoEmJson
{
    internal class SerializadorContatosEmJson : ISerializadorContatos
    {
        private const string arquivoContatos = @"C:\temp\contatos.json";

        public List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            string contatosJson = File.ReadAllText(arquivoContatos);

            return JsonSerializer.Deserialize<List<Contato>>(contatosJson);
        }

        public void GravarContatosEmArquivo(List<Contato> contatos)
        {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string contatosJson = JsonSerializer.Serialize(contatos, config);

            File.WriteAllText(arquivoContatos, contatosJson);
        }
    }
}
