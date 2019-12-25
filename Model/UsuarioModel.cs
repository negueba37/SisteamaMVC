using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Control;

namespace Model
{
    public class UsuarioModel
    {
        UsuarioControl Control = new UsuarioControl();
        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Control.Listar();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Inserir()
        {
            try
            {

                Control.Inserir();
                
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
