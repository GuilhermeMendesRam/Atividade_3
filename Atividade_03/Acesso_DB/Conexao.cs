using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_03.Acesso_DB
{
    public class Conexao
    {
        #region Objetos Estáticos
        // Objeto Connection para obter acesso ao SQL Server
        public SqlConnection sqlconnection;
        // Objeto SqlCommand para executar os com
        public static SqlCommand comando = new SqlCommand();
        // Objeto SqlParameter para adicionar os parâmetros
        ///necessários em nossas consultas
        public static SqlParameter parametro = new SqlParameter();
        #endregion

        #region Obter SqlConnection
        public SqlConnection ConexaoBd()
        {
            try
            {
                // Obtemos os dados da conexão existentes no WebConfig
                //utilizando o ConfigurationManager
                string dadosConexao = ConfigurationManager.ConnectionStrings["Atividade_03"].ConnectionString;
                // Instanciando o objeto SqlConnection
                sqlconnection = new SqlConnection(dadosConexao);

                

                // Verifica se a conexão esta fechada.
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Passou por aqui.............." + sqlconnection);
                    MessageBox.Show("Passou por aqui..............");
                    MessageBox.Show("Passou por aqui.............." + sqlconnection.ConnectionString);

                    //Abre a conexão.
                    sqlconnection.Open();

                    MessageBox.Show("Passou por aqui.............. Open");
                    //}
                    //Retorna o sqlconnection.
                }
                return sqlconnection;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        /*public SqlConnection ConexaoBd()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["atividade_conexao"].ConnectionString);
            sqlConnection.Open();


            return sqlConnection;
        }*/

        #region Abre Conexão
        public void Open()
        {
            sqlconnection.Open();
        }
        #endregion

        #region Fecha Conexão
        public void Close()
        {
            sqlconnection.Close();
        }
        #endregion

    }
}
