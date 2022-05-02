using GestaoCompromissos.Dominio;
using GestaoContatos.Dominio;
using GestaoContatos.WinApp;
using GestaoContatos.Infra.Arquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestaoCompromissos.WinApp
{
    public partial class CadastroCompromissos : Form
    {
      
        
        private ListagemContatos lt = new ListagemContatos();
        private Compromisso compromisso;
       


        public CadastroCompromissos()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                txtNumero.Text = compromisso.Numero.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtDataCompromisso.Text = compromisso.DataCompromisso.ToString();
                txtHoraInicio.Text = compromisso.HoraInicio.ToString();
                txtHoraTermino.Text = compromisso.HoraTermino.ToString();
               
              
            }



        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
         
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            compromisso.DataCompromisso = Convert.ToDateTime(txtDataCompromisso.Text);
            compromisso.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            compromisso.HoraTermino = TimeSpan.Parse(txtHoraTermino.Text);
            compromisso.Contato = lt.obterContato(txtNomeContato.Text);

        }

        
    }
}
