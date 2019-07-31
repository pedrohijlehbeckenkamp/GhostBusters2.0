using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
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
    public partial class ExcluirCSP : Form
    {
        string operacao = "";

        public ExcluirCSP(CategoriaModel Categoria)
        {
            operacao = "Categoria";
            InitializeComponent();
            CenterToParent();
            LoadDataGrid();
        }

        public ExcluirCSP(StatusModel Status)
        {
            operacao = "Status";
            InitializeComponent();
            CenterToParent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            if (operacao == "Categoria")
            {
                EsconderColunasStatus();
                EsconderColunasPerfil();
                MostrarColunasCategoria();

                List<CategoriaModel> Dg = new List<CategoriaModel>();

                var lista = new CategoriaController().FindAll();
                for (int i = 0; i < lista.Count; i++)
                {
                    var Chamados = new ChamadoController().FindCategoria(lista[i].Codigo_categoria);
                    if (Chamados == null)
                    {
                        Dg.Add(lista[i]);
                    }
                }

                if (Dg.Count == 0)
                {
                    MessageBox.Show("Não existem categorias disponíveis para excluir!");
                    this.Close();
                }
                else
                {
                    dgVisualizar.AutoGenerateColumns = false;
                    dgVisualizar.DataSource = Dg;
                }
            }
            else if (operacao == "Status")
            {
                EsconderColunasCategoria();
                EsconderColunasPerfil();
                MostrarColunasStatus();

                List<StatusModel> Dg = new List<StatusModel>();

                var lista = new StatusController().FindAll();
                for (int i = 0; i < lista.Count; i++)
                {
                    var Chamados = new ChamadoController().FindStatus(lista[i].codigo_status);
                    if (Chamados == null)
                    {
                        Dg.Add(lista[i]);
                    }
                }

                if (Dg.Count == 0)
                {
                    MessageBox.Show("Não existem status disponíveis para excluir!");
                    this.Close();
                }
                else
                {
                    dgVisualizar.AutoGenerateColumns = false;
                    dgVisualizar.DataSource = Dg;
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var linha = dgVisualizar.CurrentRow.DataBoundItem;
            if (operacao == "Categoria")
            {
                new CategoriaController().Excluir((CategoriaModel)linha);
                LoadDataGrid();
            }
            else if (operacao == "Status")
            {
                new StatusController().Excluir((StatusModel)linha);
                LoadDataGrid();
            }
            else if (operacao == "Perfil")
            {
                new PerfilController().Excluir((PerfilModel)linha);
                LoadDataGrid();
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
    }
}
