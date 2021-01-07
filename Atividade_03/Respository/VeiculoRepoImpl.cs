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
    public class VeiculoRepoImpl : VeiculoRepository
    {
        public Conexao conexao;

        public Veiculo veiculo;

        public static SqlConnection sqlconnection = new SqlConnection();
        // Objeto SqlCommand para executar os com
        public static SqlCommand comando = new SqlCommand();
        // Objeto SqlParameter para adicionar os parâmetros
        ///necessários em nossas consultas
        public static SqlParameter parametro = new SqlParameter();
        public override void AddVeiculo(Veiculo veiculo)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Veiculo(Modelo, Ano, Preco, IdFabricante) values (@modelo, @ano, @preco, @idfabricante)";
                    cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    cmd.Parameters.AddWithValue("@endereco", veiculo.Ano);
                    cmd.Parameters.AddWithValue("@email", veiculo.Ano);
                    cmd.Parameters.AddWithValue("@telefone", veiculo.IdVeiculo);


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Delete(int IdVeiculo)
        {
            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {

                    cmd.CommandText = "DELETE FROM Veiculo Where IdVeiculo=@idveiculo";
                    cmd.Parameters.AddWithValue("@idveiculo", IdVeiculo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override Veiculo GetVeiculo(int IdVeiculo)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Fabricante fabricante = new Fabricante();


            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Veiculo Where IdVeiculo =" + IdVeiculo;
                    da = new SqlDataAdapter(cmd.CommandText, conexao.ConexaoBd());
                    da.Fill(dt);

                    veiculo.IdVeiculo = Convert.ToInt32(dt.Rows[0]["IdVeiculo"]);
                    veiculo.Modelo = dt.Rows[0]["Veiculo"].ToString();
                    veiculo.Ano = Convert.ToInt32(dt.Rows[0]["Ano"]);
                    veiculo.Preco = Convert.ToDouble(dt.Rows[0]["Preco"]);
                    veiculo.Fabricante.IdFabricante = Convert.ToInt32(dt.Rows[0]["Fabricante"]);

                    return veiculo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Veiculo veiculo)
        {
            try
            {
                using (var cmd = conexao.ConexaoBd().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Veiculo SET Modelo=@modelo, Ano=@ano, Preco=@Preco, IdFabricante=@idfabricante WHERE IdVeiculo = @idveiculo";
                    cmd.Parameters.AddWithValue("@idveiculo", veiculo.IdVeiculo);
                    cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    cmd.Parameters.AddWithValue("@ano", veiculo.Ano);
                    cmd.Parameters.AddWithValue("@preco", veiculo.Preco);
                    cmd.Parameters.AddWithValue("@idfabricante", veiculo.Fabricante.IdFabricante);
                   

                    cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
