using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FormCadastroCompleto: Form
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string CEP { get; private set; }

        public FormCadastroCompleto()
        {
            InitializeComponent();
        }

        private void btnRealizarCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtCPF.Text) || string.IsNullOrWhiteSpace(txtRG.Text) ||
        string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nome = txtNome.Text;
            Email = txtEmail.Text;
            CPF = txtCPF.Text;
            RG = txtRG.Text;
            CEP = txtCEP.Text;

            MessageBox.Show("O cadastro foi realizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtCEP.Clear();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormCadastroCompleto_Load(object sender, EventArgs e)
        {

        }
    }
}
