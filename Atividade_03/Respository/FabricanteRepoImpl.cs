using Atividade_03.Acesso_DB;
using Atividade_03.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Atividade_03.Respository
{
    public class FabricanteRepoImpl:FabricanteRepository
    {
        public Conexao conexao;

        public Veiculo veiculo;

        public static SqlConnection sqlconnection = new SqlConnection();
        // Objeto SqlCommand para executar os com
        public static SqlCommand comando = new SqlCommand();
        // Objeto SqlParameter para adicionar os parâmetros
        ///necessários em nossas consultas
        public static SqlParameter parametro = new SqlParameter();
        public override Fabricante GetFabricante(int IdFabricante)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Fabricante fabricante = new Fabricante();
            

            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {

                    cmd.CommandText = "SELECT * FROM Fabricante Where IdFabricante =" + IdFabricante;
                    da = new SqlDataAdapter(cmd.CommandText, conexao.ConexaoBd());
                    da.Fill(dt);

                    fabricante.IdFabricante = Convert.ToInt32(dt.Rows[0]["IdFabricante"]);
                    fabricante.Descricao = dt.Rows[0]["Descricao"].ToString();

                    return fabricante;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void AddFabricante(Fabricante fabricante)
        {
            Conexao conexao = new Conexao();
            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Fabricante(IdFabricante, Descricao) values (@idfabricante, @descricao)";
                    cmd.Parameters.AddWithValue("@idfabricante", fabricante.IdFabricante);
                    cmd.Parameters.AddWithValue("@descricao", fabricante.Descricao);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Fabricante fabricante)
        {
            
            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Fabricante SET Descricao=@descricao WHERE IdFabricante = @idfabricante";
                    cmd.Parameters.AddWithValue("@IdFabricante", fabricante.IdFabricante);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Delete(int IdFabricante)
        {
            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM Fabricante Where IdFabricante=@idfabricante";
                    cmd.Parameters.AddWithValue("@idfabricante", IdFabricante);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
