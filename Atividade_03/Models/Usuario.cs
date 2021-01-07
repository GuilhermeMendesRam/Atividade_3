using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public String Nome { get; set; }
        public String SobreNome { get; set; }
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public String Telefone { get; set; }
        public String Endereço { get; set; }
        public Login Login { get; set; }
        public String Email { get; set; }
    }
}
