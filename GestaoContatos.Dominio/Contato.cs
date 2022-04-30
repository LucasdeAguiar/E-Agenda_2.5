using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContatos.Dominio
{
    [Serializable]
    public class Contato
    {
        public Contato()
        {

        }

        public Contato(int numero , string n, string e, string t, string emp, string c) : this()
        {
            Numero = numero;
            Nome = n;
            Email = e;
            Telefone = t;
            Empresa = emp;
            Cargo = c;
         
        }

        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }


        public override string ToString()
        {


            return $"Número: {Numero}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa: {Empresa}, Cargo: {Cargo}";
        }
    }
}
