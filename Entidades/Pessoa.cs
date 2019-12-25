using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pessoa
    {
        private string nome;
        private string genero;
        private DateTime dataNascimento;

        public string Nome { get => nome; set => nome = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public Pessoa() 
        {
        
        }
        public void Gravar() 
        { 
           
        }
    }
    


}
