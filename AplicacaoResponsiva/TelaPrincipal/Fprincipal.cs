using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AplicacaoResponsiva
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            pProduto.Visible = false;
            pPessoas.Visible = false;
            pMovimento.Visible = false;

        }
        private void hideSubMenu()
        {
            if (pProduto.Visible == true)
                pProduto.Visible = false;
            if (pPessoas.Visible == true)
                pPessoas.Visible = false;
            if (pMovimento.Visible == true)
                pMovimento.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btPessoa_Click(object sender, EventArgs e)
        {
            showSubMenu(pPessoas);
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Fusuario());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            showSubMenu(pProduto);
        }

        private void btManutProduto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btConsultaProd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btManuntServico_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btConsultaServico_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btMovimento_Click(object sender, EventArgs e)
        {
            showSubMenu(pMovimento);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pChildForm.Controls.Add(ChildForm);
            pChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }
    }
}
