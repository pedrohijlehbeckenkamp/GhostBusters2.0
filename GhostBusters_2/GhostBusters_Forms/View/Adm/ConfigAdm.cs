using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.View.Categoria;
using GhostBusters_Forms.View.PerfilP;
using GhostBusters_Forms.View.Status;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms.View.Adm
{
    public partial class ConfigAdm : Form
    {
        string operacao = "";
        public ConfigAdm(Usuario usuario)
        {
            InitializeComponent();
            CenterToParent();

            if (usuario.perfil.nomePerfil == "Técnico")
            {
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void ConfigAdm_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        //private class StatusDoGrid
        //{
        //    public int codigo_status { get; set; }
        //    public int NomeStatus { get; set; }
        //    public int perfil { get; set; }
        //}

        private void loadDataGrid()
        {
            //EsconderColunas();
            if (operacao == "Categoria")
            {
                EsconderColunasStatus();
                EsconderColunasPerfil();
                MostrarColunasCategoria();


                var lista = new CategoriaController().FindAll();

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
            else if (operacao == "Perfil")
            {
                EsconderColunasStatus();
                EsconderColunasCategoria();
                MostrarColunasPerfil();
                var lista = new PerfilController().FindAll();

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
            else if (operacao == "Status")
            {
                EsconderColunasCategoria();
                EsconderColunasPerfil();
                MostrarColunasStatus();
                var lista = new StatusController().FindAll();

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
        }

        private void EsconderColunasCategoria()
        {
            dgVisualizar.Columns[0].Visible = false;
            dgVisualizar.Columns[1].Visible = false;
        }
        private void MostrarColunasCategoria()
        {
            dgVisualizar.Columns[0].Visible = true;
            dgVisualizar.Columns[1].Visible = true;
        }

        ////////////////////////////////////////////////

        private void EsconderColunasStatus()
        {
            dgVisualizar.Columns[2].Visible = false;
            dgVisualizar.Columns[3].Visible = false;
            dgVisualizar.Columns[4].Visible = false;
        }
        private void MostrarColunasStatus()
        {
            dgVisualizar.Columns[2].Visible = true;
            dgVisualizar.Columns[3].Visible = true;
            dgVisualizar.Columns[4].Visible = true;
        }
        
        ////////////////////////////////////////////////

        private void EsconderColunasPerfil()
        {
            dgVisualizar.Columns[5].Visible = false;
            dgVisualizar.Columns[6].Visible = false;
        }
        private void MostrarColunasPerfil()
        {
            dgVisualizar.Columns[5].Visible = true;
            dgVisualizar.Columns[6].Visible = true;
        }


        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            operacao = "Categoria";
            BotoesPerfil();
            loadDataGrid();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            operacao = "Status";
            BotoesPerfil();
            loadDataGrid();
        }
        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            operacao = "Perfil";
            BotoesPerfil();
            loadDataGrid();
        }

        private void BotoesPerfil()
        {
            if (operacao == "Perfil")
            {
                btnCadastrar.Enabled = false;
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
            }
            else if (operacao != "Perfil")
            {
                btnCadastrar.Enabled = true;
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (operacao == "Categoria")
            { 
                var menu = new CadastrarCategoria();
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if (operacao == "Status")
            {
                var menu = new CadastrarStatus();
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if (operacao == "Perfil")
            {
                var menu = new CadastroPerfil();
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if (operacao == "")
            {
                MessageBox.Show("Escolha o tipo de visualizar e depois clique na operação desejada!");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {   
            if (operacao == "Categoria")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;

                var menu = new CadastrarCategoria((CategoriaModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if (operacao == "Status")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var menu = new CadastrarStatus((StatusModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if(operacao == "Perfil")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;

                var menu = new CadastroPerfil((PerfilModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if (operacao == "")
            {
                MessageBox.Show("Escolha o tipo de visualização e depois clique na operação desejada!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (operacao == "Categoria")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var menu = new ExcluirCSP((CategoriaModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }
            else if (operacao == "Status")
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var menu = new ExcluirCSP((StatusModel)linha);
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    this.loadDataGrid();
                };
                menu.Show();
                this.Hide();
            }

            //var linha = dgVisualizar.CurrentRow.DataBoundItem;

            //if (operacao == "Categoria")
            //{
                

            //    new CategoriaController().Excluir((CategoriaModel)linha);
            //    loadDataGrid();
            //}
            //else if (operacao == "Status")
            //{
            //    new StatusController().Excluir((StatusModel)linha);
            //    loadDataGrid();
            //}
            //else if (operacao == "Perfil")
            //{
            //    new PerfilController().Excluir((PerfilModel)linha);
            //    loadDataGrid();
            //}
        }
    }
}
