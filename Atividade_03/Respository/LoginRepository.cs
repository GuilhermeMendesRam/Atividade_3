using Atividade_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Respository
{
    public abstract class LoginRepository
    {
        public abstract bool VerificaSeUsuarioExisteNoBanco(Login login);       
    }
}

