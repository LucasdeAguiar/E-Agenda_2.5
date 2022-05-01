using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoCompromissos.Dominio;
using GestaoCompromissos.Infra.Arquivos;
using GestaoCompromissos.Infra.Arquivos.SerializacaoEmJson;

namespace GestaoCompromissos.WinApp
{
    public partial class ListagemCompromissos : Form
    {
        private IRepositorioCompromisso repositorioCompromisso;
        public ListagemCompromissos()
        {

            SerializadorCompromissosEmJsonDotNet serializador = new SerializadorCompromissosEmJsonDotNet();

            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializador);

            InitializeComponent();
            CarregarCompromissos();
        }


        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissos();

            listCompromissos.Items.Clear();
            foreach (Compromisso compromisso in compromissos)
            {
                listCompromissos.Items.Add(compromisso);
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroCompromissos tela = new CadastroCompromissos();
            tela.Compromisso = new Compromisso();


            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;


            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = compromissoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }
    }
}
