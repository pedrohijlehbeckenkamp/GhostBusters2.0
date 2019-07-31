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

namespace GhostBusters_Forms.View.Ticket
{
    public partial class AddTechChamado : Form
    {
        private ChamadoModel chamado;
        public AddTechChamado(ChamadoModel _chamado)
        {
            InitializeComponent();
            CenterToParent();
            chamado = _chamado;
        }

        private void AddTechChamado_Load(object sender, EventArgs e)
        {
            cbBoxDisponiveis.DataSource = new UsuarioController().FindbyPerfil("Técnico");
            cbBoxDisponiveis.DisplayMember = "NomeUsuario";
            tbNomeChamado.Text = chamado.Titulo;
            tbNomeChamado.Enabled = false;

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            //int cont = 0;
                //chamado.Tech = (Usuario)cbBoxDisponiveis.SelectedItem;
                var updateChamado = UpdateTicket();
                //if (chamado.Owner.Codigo_perfil == chamado.StatusChamado.codigo_perfil)//Solucao do problema do status
                //{
                //    new StatusController().Cadastro(UpdateNullStatus());
                //    cont++;
                //}
                new ChamadoController().Cadastro(updateChamado);

                //if (cont > 0)
                //    new StatusController().Cadastro(UpdateCodigoPrefilStatus());

                this.Close();
        }
        private ChamadoModel UpdateTicket()
        {
            ChamadoModel UpChamado = chamado;
            chamado.Tech = (Usuario)cbBoxDisponiveis.SelectedItem;
            chamado.StatusChamado = new StatusController().FindByName("Em atendimento");
            return UpChamado;
        }
        //private StatusModel UpdateNullStatus()
        //{
        //    StatusModel status = chamado.StatusChamado;
        //    status.codigo_perfil = null;
        //    status.perfil = null;
        //    return status;
        //}
        //private StatusModel UpdateCodigoPrefilStatus()
        //{
        //    StatusModel status = chamado.StatusChamado;
        //    status.codigo_perfil = chamado.Owner.Codigo_perfil;
        //    status.perfil = chamado.Owner.perfil;
        //    return status;
        //}
    }
}
