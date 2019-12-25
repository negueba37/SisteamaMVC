using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Control
{
    public class UsuarioControl
    {
        string  StrConexao = "SERVER=https://node41363-teste.jelastic.saveincloud.net; port=41363;  DATABASE=SISTEMA_MVC; userid=root; PassWorD=NmdRsx3Mcm; ";
        MySqlConnection conexao = null; 
        MySqlCommand sql;



        public void Inserir()
        {
           /* MySqlConnection conexao= new MySqlConnection(StrConexao);
            sql = new MySqlCommand("INSERT into usuario (teste values('agora vai'))", conexao);
            sql.Connection = conexao;
            conexao.Open();
            sql.ExecuteNonQuery();
            conexao.Close();*/

        }
        public DataTable Listar()
        {

            try
            {
                conexao = new MySqlConnection(StrConexao);
                sql = new MySqlCommand("SELECT * FROM USUARIO", conexao);

                try
                {
                    conexao.Open();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    conexao.Close();
                }



                MySqlDataAdapter da = new MySqlDataAdapter();// quando busca dados e lista em algum local
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                throw;

            }
            finally 
            {
                //conexao.Close();


            }

        }

    }
}
