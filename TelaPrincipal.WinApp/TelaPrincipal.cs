using GestaoCompromissos.Dominio;
using GestaoCompromissos.WinApp;
using GestaoContatos.WinApp;
using GestaoTarefas.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            ListagemTarefas tela = new ListagemTarefas();

            tela.ShowDialog();

           // if(tela.DialogResult == DialogResult.OK)
           

            
            
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            ListagemContatos tela = new ListagemContatos();

            tela.ShowDialog();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            ListagemCompromissos tela = new ListagemCompromissos();

            tela.ShowDialog();
        }
    }
}
