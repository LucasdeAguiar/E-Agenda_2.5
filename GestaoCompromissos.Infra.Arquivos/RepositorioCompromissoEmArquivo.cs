using GestaoCompromissos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos.Infra.Arquivos
{
    public class RepositorioCompromissoEmArquivo : IRepositorioCompromisso
    {
        private readonly ISerializadorCompromissos serializador;
        List<Compromisso> compromissos;
        private int contador = 0;

        public RepositorioCompromissoEmArquivo(ISerializadorCompromissos serializador)
        {

            this.serializador = serializador;

            compromissos = serializador.CarregarCompromissosDoArquivo();

            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;
            compromissos.Add(novoCompromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);

        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Numero == compromisso.Numero)
                {

                   
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    item.DataCompromisso = compromisso.DataCompromisso;
               //    item.Contato.Nome = compromisso.Contato.Nome;
              //      item.Contato.Email = compromisso.Contato.Email;
              //      item.Contato.Telefone = compromisso.Contato.Telefone;
                 //   item.Contato.Empresa = compromisso.Contato. Empresa;
                //    item.Contato.Cargo = compromisso.Contato.Cargo;

                    break;
                }
            }

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public List<Compromisso> SelecionarCompromissos()
        {
            return compromissos;
        }

    }
}
