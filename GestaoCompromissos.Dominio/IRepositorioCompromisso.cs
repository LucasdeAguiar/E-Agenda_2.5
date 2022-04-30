using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos.Dominio
{
    public interface IRepositorioCompromisso
    {
        void Editar(Compromisso tarefa);
        void Excluir(Compromisso tarefa);
        void Inserir(Compromisso novaTarefa);

        List<Compromisso> SelecionarTodos();

        List<Compromisso> SelecionarCompromissos();

    }
}
