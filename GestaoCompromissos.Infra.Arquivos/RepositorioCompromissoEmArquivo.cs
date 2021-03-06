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


        public List<Compromisso> SelecionarCompromissosDaSemana()
        {
            List<Compromisso> compromissosSemana = new List<Compromisso>();

            DateTime dataCompara = DateTime.Now;
            dataCompara.AddDays(7);

            foreach (var item in compromissos)
            {
              
                if(item.DataCompromisso < dataCompara.Date)
                {
                    compromissosSemana.Add(item);
                }
            }
            return compromissosSemana;
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            DateTime dataCompara = DateTime.Now;
            dataCompara.AddDays(7);

            foreach (var item in compromissos)
            {
                if (item.DataCompromisso.Date > dataCompara.Date)
                {
                    compromissosFuturos.Add(item);
                }
            }
            return compromissosFuturos;
        }

        public void LimparCompromissos()
        {
            
                compromissos.Clear();
        }

    }
}
