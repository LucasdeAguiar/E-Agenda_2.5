using GestaoContatos.Dominio;
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
    public partial class CadastroContatos : Form
    {
        private Contato contato;
        public CadastroContatos()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNumero.Text = contato.Numero.ToString();
                txtNome.Text = contato.Nome;
                txtCargo.Text = contato.Cargo;
                txtEmail.Text = contato.Email;
                txtEmpresa.Text = contato.Empresa;
                txtTelefone.Text = contato.Telefone;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            if (txtTelefone.Text.Length != 9)
            {

                MessageBox.Show("Digite um telefone válido..", "Inserção de Telefone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.Cancel;
                return;
            }


            



            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Digite um nome..", "Inserção de Nome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.Cancel;
                return;
            }
            

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Digite um email válido..", "Inserção de Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                else
                {
                    contato.Nome = txtNome.Text;
                    contato.Email = txtEmail.Text;
                    contato.Telefone = txtTelefone.Text;
                    contato.Empresa = txtEmpresa.Text;
                    contato.Cargo = txtCargo.Text;
                }
            

            
        }
    }
}
