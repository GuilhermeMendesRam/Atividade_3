using Atividade_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Respository
{
    public abstract class VeiculoRepository
    {
        public abstract Veiculo GetVeiculo(int IdVeiculo);

        public abstract void AddVeiculo(Veiculo veiculo);

        public abstract void Update(Veiculo veiculo);

        public abstract void Delete(int IdVeiculo);

    }
}
