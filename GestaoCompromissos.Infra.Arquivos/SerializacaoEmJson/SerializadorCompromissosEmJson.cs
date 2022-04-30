using GestaoCompromissos.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestaoCompromissos.Infra.Arquivos.SerializacaoEmJson
{
    public class SerializadorCompromissosEmJson : ISerializadorCompromissos
    {
        private const string arquivoCompromissos = @"C:\temp\compromissos'.json";

        public List<Compromisso> CarregarCompromissosDoArquivo()
        {
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            string compromissosJson = File.ReadAllText(arquivoCompromissos);

            return JsonSerializer.Deserialize<List<Compromisso>>(compromissosJson);
        }

        public void GravarCompromissosEmArquivo(List<Compromisso> compromissos)
        {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string compromissosJson = JsonSerializer.Serialize(compromissos, config);

            File.WriteAllText(arquivoCompromissos, compromissosJson);
        }

    }
}
