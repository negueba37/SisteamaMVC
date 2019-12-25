using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Control
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection("server=local");
    }
}
