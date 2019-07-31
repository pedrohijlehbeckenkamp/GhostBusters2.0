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

namespace GhostBusters_Forms.View.Status
{
    public partial class CadastrarStatus : Form
    {
        private StatusModel Status;
        //private PerfilModel perfil;
        public CadastrarStatus()
        {
            InitializeComponent();
            CenterToParent();
        }
        public CadastrarStatus(StatusModel _status)
        {
            InitializeComponent();
            CenterToParent();
            Status = _status;
            tbNomeS.Text = Status.NomeStatus;
           
        }
        public StatusModel GetCadastrarStatus() => new StatusModel
        {
            NomeStatus = tbNomeS.Text,
            perfil = (PerfilModel)CbListarPerfil.SelectedItem
        };

        public bool ValidarStatus()
        {
            Regex validaNomeStatus = new Regex(@"[0-9]");
            if(string.IsNullOrEmpty(tbNomeS.Text) || validaNomeStatus.IsMatch(tbNomeS.Text))
            {
                tbNomeS.BackColor = Color.Red;
                MessageBox.Show("Erro ao inserir status!");
                return false;
            }
            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Status != null)
            {
                if (ValidarStatus())
                {
                    new StatusController().Cadastro(UpDateS());
                    MessageBox.Show("Status atualizado com cucesso!");
                    this.Close();
                }
            }
            else
            {
                if (tbNomeS.Text != "")
                {
                    new StatusController().Cadastro(GetCadastrarStatus());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insira um nome para o Status");
                }
            }
        }
        
        private StatusModel UpDateS() => new StatusModel()
        {
            codigo_status = Status.codigo_status,
            NomeStatus = tbNomeS.Text,
            perfil = (PerfilModel)CbListarPerfil.SelectedItem
        };
        private void CadastrarStatus_Load(object sender, EventArgs e)
        {
            MostrarPerfil();
        }
        private void MostrarPerfil()
        {
            CbListarPerfil.DataSource = new PerfilController().FindAll();
            CbListarPerfil.DisplayMember = "nomePerfil";
            CbListarPerfil.SelectedIndex = CbListarPerfil.FindStringExact(Status.perfil.nomePerfil);
        }
    }
}
