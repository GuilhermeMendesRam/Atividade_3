using Atividade_03.Acesso_DB;
using Atividade_03.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03.Respository
{
    public class LoginRepoImpl : LoginRepository
    {
        public Conexao conexao;

        public override bool VerificaSeUsuarioExisteNoBanco(Login login)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(conexao.sqlconnection.ConnectionString);

                SqlCommand cmd = new SqlCommand("select * from tbl_usuario where login_usuario = @login_usuario and senha_usuario = @senha_usuario", sqlConn);

                SqlParameter parametroUsuario = new SqlParameter("@login_usuario", SqlDbType.VarChar, 20);
                parametroUsuario.Value = login.LoginUsuario;
                cmd.Parameters.Add(parametroUsuario);

                SqlParameter parametroSenha = new SqlParameter("@senha_usuario", SqlDbType.VarChar, 6);
                parametroSenha.Value = login.Senha;
                cmd.Parameters.Add(parametroSenha);

                sqlConn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //usuario existe
                    return true;
                }
                else
                {
                    //usuario nao existe
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
