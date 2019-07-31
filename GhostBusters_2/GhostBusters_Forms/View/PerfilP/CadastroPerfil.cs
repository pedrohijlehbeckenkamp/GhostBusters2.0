using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
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

namespace GhostBusters_Forms.View.PerfilP
{
    public partial class CadastroPerfil : Form
    {
        private PerfilModel perfil;
        public CadastroPerfil()
        {
            InitializeComponent();
            CenterToParent();
        }

        public CadastroPerfil(PerfilModel _perfil)
        {
            InitializeComponent();
            CenterToParent();
            perfil = _perfil;
            tbNomePe.Text = perfil.nomePerfil;
        }

        public bool ValidacaoPerfil()
        {

            Regex validaNomePerfil = new Regex(@"[0-9]");
            if (string.IsNullOrEmpty(tbNomePe.Text) || validaNomePerfil.IsMatch(tbNomePe.Text))
            {
                tbNomePe.BackColor = Color.Red;
                MessageBox.Show("Erro ao inserir perfil!");
                return false;
            }

            return true;
        }

        private void BtnSavePer_Click(object sender, EventArgs e)
        {
            if (perfil != null)
            {
                if (ValidacaoPerfil())
                {
                    new PerfilController().Cadastro(UpDateP());
                    MessageBox.Show("Perfil Cadastrado");
                    this.Close();

                }
            }
            else
            {
                new PerfilController().Cadastro(Cadastrar());
                this.Close();
            }
        }

        private PerfilModel UpDateP() => new PerfilModel()
        {
            Codigo = perfil.Codigo,
            nomePerfil = tbNomePe.Text,
        };

        private PerfilModel Cadastrar() => new PerfilModel()
        {

           // Codigo = perfil.Codigo,
            nomePerfil = tbNomePe.Text,

        };



    }
}
