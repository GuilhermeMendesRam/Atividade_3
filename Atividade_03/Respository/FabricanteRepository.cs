using Atividade_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Respository
{
    public abstract class FabricanteRepository
    {
        public abstract Fabricante GetFabricante(int IdFabricante);

        public abstract void AddFabricante(Fabricante fabricante);

        public abstract void Update(Fabricante fabricante);

        public abstract void Delete(int IdFabricante);
    }
}
