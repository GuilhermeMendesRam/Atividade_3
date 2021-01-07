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
    public partial class frmFabricantes : Form
    {
        public frmFabricantes()
        {
            InitializeComponent();
        }

        private void btn_Incluir(object sender, EventArgs e)
        {
            if (btnIncluir.Text.Equals("Incluir"))
            {
                //btnIncluir.Text = "Salvar";
                //txtCodigo.Enabled = false;
               // txtDescricao.Focus();
            //}
            //else if(btnIncluir.Text.Equals("Salvar"))
            //{
           

                //btnIncluir.Text = "Incluir";
               // txtCodigo.Enabled = true;

                try
                {
                    Fabricante fabricante = new Fabricante();

                    fabricante.IdFabricante = Convert.ToInt32(txtCodigo.Text);
                    fabricante.Descricao = txtDescricao.Text;

                    FabricanteRepoImpl impl = new FabricanteRepoImpl();
                    impl.AddFabricante(fabricante);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error tente novamente : " + ex.Message);
                }
            }
        }

        private void btn_Alterar(object sender, EventArgs e)
        {
            try
            {
                Fabricante fabricante = new Fabricante();

                fabricante.IdFabricante = Convert.ToInt32(txtCodigo.Text);
                fabricante.Descricao = txtCodigo.Text;

                FabricanteRepoImpl impl = new FabricanteRepoImpl();
                impl.Update(fabricante);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro tente novamente : " + ex.Message);
            }
        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            try
            {
                Fabricante fabricante = new Fabricante();
                fabricante.IdFabricante = Convert.ToInt32(txtCodigo.Text);
                FabricanteRepoImpl impl = new FabricanteRepoImpl();
                impl.Delete(fabricante.IdFabricante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro tente novamente : " + ex.Message);

            }
        }

        private void btn_Consultar(object sender, EventArgs e)
        {
            try
            {
                Fabricante fabricante = new Fabricante();
                fabricante.Descricao = txtDescricao.Text;

                FabricanteRepoImpl fabricanteRepoImpl = new FabricanteRepoImpl();
                fabricanteRepoImpl.GetFabricante(fabricante.IdFabricante);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro tente novamente : " + ex.Message);
            }
        }

        private void frmFabricantes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'atividade_03DataSet.Fabricante'. Você pode movê-la ou removê-la conforme necessário.
            this.fabricanteTableAdapter.Fill(this.atividade_03DataSet.Fabricante);

        }
    }
}
