using Atividade_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Respository
{
    public abstract class UsuarioRespository
    {
        public abstract Usuario GetUsuario(int IdUsuario);

        public abstract void AddUsuario(Usuario usuario);

        public abstract void Update(Usuario usuario);

        public abstract void Delete(int IdUsuario);
    }
}
