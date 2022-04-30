using GestaoContatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContatos.Infra.Arquivos
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {
        private readonly ISerializadorContatos serializador;
        List<Contato> contatos;
        private int contador = 0;

        public RepositorioContatoEmArquivo(ISerializadorContatos serializador)
        {

            this.serializador = serializador;

            contatos = serializador.CarregarContatosDoArquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            contatos.Add(novoContato);

            serializador.GravarContatosEmArquivo(contatos);

        }

        public void Editar(Contato Contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == Contato.Numero)
                {
                    
                    item.Nome = Contato.Nome;
                    item.Email = Contato.Email;
                    item.Telefone = Contato.Telefone;
                    item.Empresa = Contato.Empresa;
                    item.Cargo = Contato.Cargo;
                    break;
                }
            }

            serializador.GravarContatosEmArquivo(contatos);
        }


        public void Excluir(Contato tarefa)
        {
            contatos.Remove(tarefa);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public List<Contato> SelecionarContatos()
        {
            return contatos;
        }



    }
}
