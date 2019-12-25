using AplicacaoResponsiva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtSenha.PasswordChar = '*';
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal formPrincipal = new FrmPrincipal();
            formPrincipal.Show();
        }
    }
}
