using Atividade_03.Models;
using Atividade_03.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_03
{
    public partial class frmVeiculos : Form
    {
        public frmVeiculos()
        {
            InitializeComponent();
        }

        private void btn_Incluir(object sender, EventArgs e)
        {
            if (btnIncluir.Text.Equals("Incluir"))
            {
                btnIncluir.Text = "Salvar";
                txtCodVeiculo.Enabled = false;
                txtModelo.Focus();
                txtAno.Enabled = false;
                txtPreco.Enabled = false;
            }
            else if (btnIncluir.Text.Equals("Salvar"))
            {
                btnIncluir.Text = "Incluir";
                txtAno.Enabled = true;
                txtPreco.Enabled = true;
                txtCodVeiculo.Enabled = true;
                try
                {
                    Veiculo veiculo = new Veiculo();
                    veiculo.IdVeiculo = Convert.ToInt32(txtCodVeiculo.Text);
                    veiculo.Ano = Convert.ToInt32(txtAno.Text);
                    veiculo.Modelo = txtModelo.Text;
                    veiculo.Preco = Convert.ToDouble(txtPreco.Text);
                    veiculo.Fabricante.IdFabricante = Convert.ToInt32(((DataRowView)cmbRegFabricante.SelectedItem)["IdFabricante"]);


                    VeiculoRepoImpl impl = new VeiculoRepoImpl();
                    impl.AddVeiculo(veiculo);

                }catch(Exception ex)
                {
                    MessageBox.Show("Error tente novamente : " + ex.Message);
                }

            }
        }

        private void btn_Alterar(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo.IdVeiculo = Convert.ToInt32(txtCodVeiculo.Text);
                veiculo.Ano = Convert.ToInt32(txtAno.Text);
                veiculo.Modelo = txtModelo.Text;
                veiculo.Preco = Convert.ToDouble(txtPreco.Text);
                veiculo.Fabricante.IdFabricante = Convert.ToInt32(((DataRowView)cmbRegFabricante.SelectedItem)["IdFabricante"]);

                VeiculoRepoImpl impl = new VeiculoRepoImpl();
                impl.Update(veiculo);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error tente novamente : " + ex.Message);
            }
        }

        private void btn_Deletar(object sender, EventArgs e)
        {
            try
            {
                VeiculoRepoImpl impl = new VeiculoRepoImpl();
                Veiculo veiculo = new Veiculo();
                impl.Delete(veiculo.IdVeiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tente novamente : " + ex.Message);
            }
        }

        private void btn_Consultar(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo.IdVeiculo = Convert.ToInt32(txtCodVeiculo.Text);
                veiculo.Ano = Convert.ToInt32(txtAno.Text);
                veiculo.Modelo = txtModelo.Text;
                veiculo.Preco = Convert.ToDouble(txtPreco.Text);
                veiculo.Fabricante.IdFabricante = Convert.ToInt32(((DataRowView)cmbRegFabricante.SelectedItem)["IdFabricante"]);
                VeiculoRepoImpl impl = new VeiculoRepoImpl();
                impl.GetVeiculo(veiculo.IdVeiculo);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error tente novamente : " + ex.Message);
            }
        }

        private void cmbRegFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Fabricante.IdFabricante = Convert.ToInt32(((DataRowView)cmbRegFabricante.SelectedItem)["IdFabricante"]);

            VeiculoRepoImpl veiculo1 = new VeiculoRepoImpl();
            veiculo1.GetVeiculo(veiculo.Fabricante.IdFabricante);
        }

        private void frmVeiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'atividade_03DataSet1.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.atividade_03DataSet1.Veiculo);

        }
    }
}
