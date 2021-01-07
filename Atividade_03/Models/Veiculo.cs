using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Models
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public String Modelo { get; set; }
        public int Ano { get; set; }
        public Double Preco { get; set; }
        public Fabricante Fabricante { get; set; }

    }
}
