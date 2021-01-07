using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Models
{
    public class Login
    {
        public int IdLogin { get; set; }
        public String LoginUsuario {get;set;}
        public String Senha { get; set; }
        public Boolean Status { get; set; }
    }
}
