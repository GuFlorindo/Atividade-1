using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Usuario
    {
        public int Id {get;set;}
        public static int admin = 0;
        public static int user = 1;
        public string Login {get;set;}
        public string Senha {get;set;}
        public string Nome {get;set;}
        public int Tipo {get;set;}
    }
}   