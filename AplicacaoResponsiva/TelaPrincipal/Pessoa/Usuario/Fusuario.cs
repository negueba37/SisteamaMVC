using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using MySql.Data.MySqlClient;

namespace AplicacaoResponsiva
{
    public partial class Fusuario : Form
    {
        public Fusuario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioModel Model = new UsuarioModel();
            try
            {
                dataGridView1.DataSource = Model.Listar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          /*  string strConexao =  "SERVER=localhost; DATABASE=test; userid=root;";
            MySqlConnection Conexao = new MySqlConnection(strConexao);
            
            try
            {
                Conexao.Open();
                MessageBox.Show("Aleluia");
                MySqlCommand insert = new MySqlCommand("INSERT INTO USUARIO(TESTE) VALUES (@TEST)", Conexao);
                insert.Parameters.AddWithValue("@TEST", "ola");
                insert.ExecuteNonQuery();
                Conexao.Close();


            }
            catch(Exception exp)
            {

                MessageBox.Show("Continue tentando"+ exp.Message);
            }


            /*UsuarioModel Model = new UsuarioModel();
            try
            {
                Model.Inserir();


            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            UsuarioModel Model = new UsuarioModel();
            try
            {
                dataGridView1.DataSource = Model.Listar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void Fusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
