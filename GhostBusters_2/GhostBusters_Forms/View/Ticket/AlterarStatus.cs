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
    public partial class AlterarStatus : Form
    {
        private ChamadoModel chamado;
        private Usuario usuarioLogin;
        public AlterarStatus(Usuario _usuarioLogin, ChamadoModel _chamado)
        {
            InitializeComponent();
            CenterToParent();
            chamado = _chamado;
            usuarioLogin = _usuarioLogin;
        }
        private void AlterarStatus_Load(object sender, EventArgs e)
        {
            LoadAlterarStatus();
        }
        private void LoadAlterarStatus()
        {
            int cont = 0;
            if (usuarioLogin.NomePerfil != "Admin")
            {
                CbStatus.DataSource = new StatusController().FinByStatusPerfil(usuarioLogin.Codigo_perfil);
                cont = CbStatus.FindStringExact(chamado.Nomestatus);
                CbStatus.SelectedIndex = cont;
            }
            else
            {
                CbStatus.DataSource = new StatusController().FindAll();
                cont = CbStatus.FindStringExact(chamado.Nomestatus);
                CbStatus.SelectedIndex = cont;
            } 

            CbStatus.DisplayMember = "NomeStatus";
            
        }

        private void BtSave_Click(object sender, EventArgs e)
        {

            if (validacao())
            {
                if (chamado.codigo_tech != null)
                {
                    string nome = Save();
                    EnviaEmail(nome);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Defina um técnico para alterar o status!");
                    this.Close();
                }
            }
        }
        private bool validacao()
        {
            var statusNew= (StatusModel)CbStatus.SelectedItem;
            var statusAnt = chamado.StatusChamado;
            int cont = 0;
            if (statusNew.codigo_status == statusAnt.codigo_status)
            {
                MessageBox.Show("Mesmo status do anterior");
                cont++;
            }
            if (Validacoes.ValidaCamponull(tbObservacao.Text))
            {
                MessageBox.Show("Campo Observacao Nulo");
                cont++;
            }
            if (cont > 0)
            {
                return false;
            }
            return true;
        }
        private void LoadCarregador()
        {
            lbStatus.Visible = false;
            lbObservacoes.Visible = false;
            CbStatus.Visible = false;
            tbObservacao.Visible = false;
            btSave.Visible = false;
        }
        private void EnviaEmail(string nome)
        {
            if (chamado.StatusChamado.NomeStatus == "Reprovado" && usuarioLogin.NomePerfil == "Usuario")
                EnviarEmail(nome, chamado.Tech.Email);
            if (chamado.StatusChamado.NomeStatus == "Aprovado" && usuarioLogin.NomePerfil == "Usuario")
                EnviarEmail(nome, chamado.Tech.Email);
            if (chamado.StatusChamado.NomeStatus == "Finalizado" && usuarioLogin.NomePerfil == "Técnico")
                EnviarEmail(nome, chamado.Owner.Email);
        }
        private void EnviarEmail(string nome, string email)
        {
            try
            {
               var ok = new ChamadoController().EnviarEmail(chamado.Titulo, CorpoEmail(nome), email);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Email invalido:");
            }
        }
        private string CorpoEmail(string nome)
        {
            string BodyEmail = "Chamado:"+chamado.Titulo+"\n\n" +"\tTroca de status \nDe: "+nome+" \tPara: "+ chamado.StatusChamado.NomeStatus+
                                "\nObservacao: " +tbObservacao.Text+ "\n\n\n\n\n\n Atenciosamente Ghostbursters_Help";
            return BodyEmail;
        }

        //private ChamadoModel DataDeFinalizacao() => new ChamadoModel
        //{
            
        //};
        private string Save() 
        {
            var statusitem = (StatusModel)CbStatus.SelectedItem;
            var itemPerfil = statusitem.perfil.Codigo;
            var statusant = chamado.StatusChamado;
            var AntPerfil = statusant.perfil.Codigo;
            int cont = 0;
            int cont2 = 0;
            if (chamado.Owner.Codigo_perfil == statusitem.codigo_perfil || chamado.Tech.Codigo_perfil == statusitem.codigo_perfil)
            {
                new StatusController().Cadastro(UpdateNullStatus(statusitem));
                cont++;
            }
            if (chamado.Owner.Codigo_perfil == chamado.StatusChamado.codigo_perfil || chamado.Tech.Codigo_perfil == chamado.StatusChamado.codigo_perfil)
            {
                new StatusController().Cadastro(UpdateNullStatus(chamado.StatusChamado));
                cont2++;
            }
            new LogController().Cadastro(GetLog(statusitem));

            new ChamadoController().Cadastro(UpdateTicket());


            if (cont > 0)
                new StatusController().Cadastro(UpdateCodigoPrefilStatus(statusitem, itemPerfil));
            if (cont2 > 0)
                new StatusController().Cadastro(UpdateCodigoPrefilStatus(statusant, AntPerfil));

            return statusant.NomeStatus;
        }

        private StatusModel UpdateNullStatus(StatusModel statusitem)
        {
            StatusModel status = statusitem;
            status.codigo_perfil = null;
            status.perfil = null;
            return status;
        }

        private StatusModel UpdateCodigoPrefilStatus(StatusModel statusitem,int codigo)
        {
            StatusModel status = statusitem;
            status.codigo_perfil = codigo;
            status.perfil = new PerfilController().FindById(codigo);
            return status;
        }


        private ChamadoModel UpdateTicket()
        {
            ChamadoModel UpChamado = chamado;
            if (CbStatus.Text == "Aprovado" && usuarioLogin.NomePerfil == "Usuario")
            {
                UpChamado.Data_Chamado_finalizado = DateTime.Now;
            }
            UpChamado.StatusChamado = (StatusModel)CbStatus.SelectedItem;
            return UpChamado;
        }
        public LogModel GetLog(StatusModel statusnew) => new LogModel()
        {
            Observacao = tbObservacao.Text,
            Data_log = DateTime.Now,
            Usuario = usuarioLogin.NomeUsuario,
            Chamado = chamado,
            //Owner = usuarioLogin,
            Status_Ant = chamado.StatusChamado,
            Status_New = statusnew
        };
    }
}
