using GestaoContatos.Dominio;
using GestaoContatos.Infra.Arquivos;
using GestaoContatos.Infra.Arquivos.SerializacaoEmJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoContatos.WinApp
{
    public partial class ListagemContatos : Form
    {
        public  IRepositorioContato repositorioContato;
        public ListagemContatos()
        {

            SerializadorContatosEmJsonDotnet serializador = new SerializadorContatosEmJsonDotnet();

           repositorioContato = new RepositorioContatoEmArquivo(serializador);

            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarContatos();
            
            listContatos.Items.Clear();

            /*
            var contatosAgrupados = repositorioContato
                   .SelecionarTodos()
                   .GroupBy(x => x.Cargo);
            */

            /*
            foreach (var contatoAgrupado in contatosAgrupados)
            {
                listContatos.Items.Add(contatoAgrupado.Key);

                foreach (Contato contatoDisponivel in contatos)
                    if (contatoDisponivel.Cargo == contatoAgrupado.Key)
                        listContatos.Items.Add(contatoDisponivel.ToString());
            }
            */
            
            foreach (Contato contato in contatos)
            {
                listContatos.Items.Add(contato);
            }
            
            
            /*
            foreach (Contato contatoAgrupado in contatosAgrupados)
            {
                listContatos.Items.Add(contatoAgrupado);
            }
            */
            
           
            
        }

        public Contato obterContato(string nomeContato)
        {
            List<Contato> contatos = repositorioContato.SelecionarContatos();
            foreach (Contato contato in contatos)
            {
                if (contato.Nome == nomeContato)
                {
                    return contato;
                }
            }

            return null;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContatos tela = new CadastroContatos();
            tela.Contato = new Contato();


            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;
           

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContatos tela = new CadastroContatos();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }
    }
    
}
