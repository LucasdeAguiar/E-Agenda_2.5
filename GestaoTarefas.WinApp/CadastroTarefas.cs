using GestaoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        public CadastroTarefas()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
                txtPrioridade.Text = tarefa.Prioridade;
            }
        }      

        private void btnGravar_Click(object sender, EventArgs e)
        {            
            tarefa.Titulo = txtTitulo.Text;
            tarefa.Prioridade= txtPrioridade.Text;

            if (txtTitulo.Text.Length == 0)
            {
                MessageBox.Show("Digite um título..", "Inserção de um Título", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (txtPrioridade.Text != "1" && txtPrioridade.Text != "2" && txtPrioridade.Text != "3")
            {
                MessageBox.Show("Digite uma prioridade válida (1,2,3)..", "Inserção de Prioridade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.Cancel;
                return;
            }
        }
    }
}
