using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;

namespace GhostBusters_Forms.View.Categoria
{
    public partial class CadastrarCategoria : Form
    {

        private CategoriaModel categoria;

        public CadastrarCategoria()
        {
            InitializeComponent();
            CenterToParent();
        }

        public CadastrarCategoria (CategoriaModel _categoria)
        {
            InitializeComponent();
            CenterToParent();
            categoria = _categoria;
            tbNomeCateg.Text = categoria.NomeCategoria;
        }


        public bool ValidaCategoria()
        {
            Regex validaNomeCategoria = new Regex(@"[0-9]");
            if(string.IsNullOrEmpty(tbNomeCateg.Text) || validaNomeCategoria.IsMatch(tbNomeCateg.Text))
            {
                tbNomeCateg.BackColor = Color.Red;
                MessageBox.Show("Erro ao inserir categoria!");
                return false;
            }
            return true;
        }

        private void BtnSaveCategoria_Click(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                if (ValidaCategoria())
                {
                    new CategoriaController().Cadastro(UpDateC());
                    MessageBox.Show("Categoria atualizada com sucesso!");
                    this.Close();
                }
            }
            else
            {
                if (tbNomeCateg.Text != "")
                {
                    new CategoriaController().Cadastro(Cadastrar());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insira um nome para categoria!");
                }
            }
        }
        private CategoriaModel Cadastrar() => new CategoriaModel()
        {
            NomeCategoria = tbNomeCateg.Text,
        };


        private CategoriaModel UpDateC() => new CategoriaModel()
        {
            Codigo_categoria = categoria.Codigo_categoria,
            NomeCategoria = tbNomeCateg.Text,
        };
    }
}
