using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContatos.Dominio
{
    public interface IRepositorioContato
    {
      

        void Editar(Contato tarefa);
        void Excluir(Contato tarefa);
        void Inserir(Contato novaTarefa);

        bool VerificaSeHexisteContato(string nome, string email, string telefone);

        List<Contato> SelecionarTodos();

        List<Contato> SelecionarContatos();

    }
}
