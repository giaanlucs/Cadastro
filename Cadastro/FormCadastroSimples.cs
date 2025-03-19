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
    public partial class FormCadastroSimples: Form
    {
        public FormCadastroSimples()
        {
            InitializeComponent();
        }

        private void FormCadastroSimples_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewCadastros.Rows.Add(txtNome.Text, txtEmail.Text);
            MessageBox.Show("O cadastro foi realizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void btnCadastroCompleto_Click(object sender, EventArgs e)
        {
            FormCadastroCompleto formCompleto = new FormCadastroCompleto();

            if (formCompleto.ShowDialog() == DialogResult.OK)
            {
                dataGridViewCadastros.Rows.Add(formCompleto.Nome, formCompleto.Email, formCompleto.CPF, formCompleto.RG, formCompleto.CEP);
            }
        }

        private void btnVisualizarCadastro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
