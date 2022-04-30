using GestaoContatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos.Dominio
{
    [Serializable]
    public class Compromisso
    {
        public Compromisso()
        {
        }

        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }

        private DateTime _dataCompromisso;
        public DateTime DataCompromisso { get => _dataCompromisso.Add(HoraInicio); set => _dataCompromisso = value; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; }

        public Compromisso(int numero, string assunto, string local, DateTime dataCompromisso, TimeSpan horaInicio, TimeSpan horaTermino, Contato contato)
        {
            Numero = numero;
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            Contato = contato;
        }


        public override string ToString()
        {
            return $"Número: {Numero}, Assunto: {Assunto}, Local: {Local}, Hora Início: {HoraInicio}, Hora Término: {HoraTermino}, Data do Compromisso: {DataCompromisso}, Contato: {Contato}";
        }


    }
}
