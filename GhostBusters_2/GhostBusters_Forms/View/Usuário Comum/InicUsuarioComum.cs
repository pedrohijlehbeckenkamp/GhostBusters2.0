using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.View.Ticket;
using GhostBusters_Forms.View.Status;
using GhostBusters_Forms.View.Usuário_Comum;
using GhostBusters_Forms.Model;
using System.IO;
using GhostBusters_Forms.Controller;
using GhostBusters_Forms.View.Adm;

namespace GhostBusters_Forms.Usuário_Comum
{
    public partial class InicUsuarioComum : Form
    {
        private Usuario usuario;
       // private ChamadoModel ticket;
        string CB = "";

        private List<ChamadoModel> listaUsuarios;
       
        public InicUsuarioComum(Usuario _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
            //LoadUsuario();
            CenterToParent();
        }

        private void TelaUsuarioComum_Load(object sender, EventArgs e)
        {
            Loadtelaprincipal();
        }



        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AlteraPic alteraPic = new AlteraPic(usuario);
            //alteraPic.Show();
            var tela = new AlteraPic(usuario);
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
                LoadUsuario();
            };
            tela.Show();
            Esconder();
        }
        private void BtnAdcTicket_Click(object sender, EventArgs e)
        {
            var tela = new CadastrarTicket(usuario);
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
                LoadUsuario();
            };
            tela.Show();
            Esconder();
            //OpenFormAndHide<>();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.Count >= 0)
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var ChamadoSelecionado = (ChamadoModel)linha;
                if (ChamadoSelecionado.Data_Chamado_finalizado == null)
                {
                    var menu = new CadastrarTicket(usuario, ChamadoSelecionado, "Editar");
                    menu.FormClosed += (x, y) =>
                    {
                        this.Show();
                        LoadUsuario();
                    };
                    menu.Show();
                    this.Hide();
                }
                else MessageBox.Show("Chamado Finalizado, Nao pode ser Alterado");

            }
            else MessageBox.Show("Nao Existe nenhum Chamado");
        }

        private void Esconder()
        {
            this.Hide();
        }

        private void Abrir()
        {
            this.Show();
        }
        public void Loadtelaprincipal()
        {
           // AlimentarCB();
            tbConteudo.Visible = false;
            cbGeral.Visible = false;
            maskedCod.Visible = false;
            dtData.Visible = false;

            LoadUsuario();

            lblDate.Text = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToLongTimeString();
            lblNomeUC.Text = usuario.NomeUsuario;
            lblEmail.Text = usuario.Email;
            dgVisualizar.AutoGenerateColumns = false;

            listaUsuarios = new ChamadoController().FindByUsuario(usuario.Codigo_Usuario);
            dgVisualizar.DataSource = listaUsuarios;

        }

        private void AlimentarCB()
        {
            if (CB == "Status")
            {
                cbGeral.DataSource = new StatusController().FindAll();
                cbGeral.DisplayMember = "NomeStatus";
            }
            else if (CB == "Usuário")
            {
                cbGeral.DataSource = new UsuarioController().FindbyPerfil("Usuario");
                cbGeral.DisplayMember = "NomeUsuario";
            }
            else if (CB == "Técnico")
            {

                cbGeral.DataSource = new UsuarioController().FindbyPerfil("Técnico");
                cbGeral.DisplayMember = "NomeSstatus";
            }
        }

        private void LoadUsuario()
        {
            maskedCod.Visible = false;
            tbConteudo.Visible = false;
            cbGeral.Visible = false;
            dtData.Visible = false;
         
            dgVisualizar.ReadOnly = true;
            dgVisualizar.AutoGenerateColumns = false;
            dgVisualizar.DataSource = new ChamadoController().FindByOwner(usuario.Codigo_Usuario);
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
            //referenciar de acordo com o obj
            lblNomeUC.Text = usuario.NomeUsuario;
            lblEmail.Text = usuario.Email;

            if (usuario.Foto != null)
            {
                var imagem = new ImagemController().FindById(usuario.Codigo_imagem);
                byte[] bytes = Convert.FromBase64String(imagem.BaseData);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    picBase64.Image = Image.FromStream(ms);
                }
            }
        }

        private void LinkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var tela = new AlterarSenha(usuario);
            tela.FormClosed += (x, y) =>
            {
                this.Abrir();
                LoadUsuario();
            };
            tela.Show();
            Esconder(); ;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (cbOrderBy.Text == "Código ticket")
            {
                if (maskedCod.Text != "")
                {
                    int Id = Convert.ToInt32(maskedCod.Text);

                    //var byId = new ChamadoController().FindByID(Id);
                    List<ChamadoModel> lista = new List<ChamadoModel>();

                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Codigo_chamado == Id)
                        {
                            lista.Add(listaUsuarios[i]);
                        }
                    }

                    dgVisualizar.AutoGenerateColumns = false;
                    //listaUsuarios = new ChamadoController().FindByUsuario(usuario.Codigo_Usuario);
                    dgVisualizar.DataSource = lista;


                }

            }
            else if (cbOrderBy.Text == "Conteúdo")
            {
                if (cbOrderBy.Text != "")
                {
                    string padrao = tbConteudo.Text;

                    // var Chamados = new ChamadoController().Findall();

                    List<ChamadoModel> lista = new List<ChamadoModel>();

                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Descricao.Contains(padrao))
                        {
                            lista.Add(listaUsuarios[i]);

                        }
                    }
                    dgVisualizar.AutoGenerateColumns = false;
                    dgVisualizar.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("Digite algo para fazer a pesquisa");
                }


            }

            else if (cbOrderBy.Text == "Status")
            {
                var Status = (StatusModel)cbGeral.SelectedItem;
                int id = Status.codigo_status;

                var chamados = new ChamadoController().FindByStatus(id);

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = chamados;
            }
            else if (cbOrderBy.Text == "Data")
            {
                DateTime date = dtData.Value.Date;

                List<ChamadoModel> lista = new List<ChamadoModel>();

                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i].Data_Chamado.Date == date)
                    {
                        lista.Add(listaUsuarios[i]);

                    }
                }

                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
            else if (cbOrderBy.Text == "Todos")
            {
                LoadUsuario();
            }

               
            
        }

            private void CbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cbOrderBy.Text == "Código ticket") {

                    CB = "Código ticket";
                    maskedCod.Visible = true;
                }
                else
                {
                    maskedCod.Visible = false;
                }

                if (cbOrderBy.Text == "Conteúdo")
                {
                    CB = "Conteúdo";
                    tbConteudo.Visible = true;
                }
                else
                {
                    tbConteudo.Visible = false;
                }
                if (cbOrderBy.Text == "Data")
                {
                    CB = "Data";
                    dtData.Visible = true;
                }
                else
                {
                    dtData.Visible = false;
                }

                if (cbOrderBy.Text == "Status")
                {
                    CB = "Status";
                    AlimentarCB();
                    cbGeral.Visible = true;
                }

                else
                {
                    cbGeral.Visible = false;
                }

            }

        private void BtAlterarStatus_Click(object sender, EventArgs e)
        {
            //var DgNull = new ChamadoController().FindByOwner(usuario.Codigo_Usuario);
            if (listaUsuarios.Count >= 0)
            {
                var item = dgVisualizar.CurrentRow.DataBoundItem;
                var ChamadoSelecionado = (ChamadoModel)item;
                if (ChamadoSelecionado.Tech != null)
                {

                    if (ChamadoSelecionado.Data_Chamado_finalizado == null)
                    {
                        if (ChamadoSelecionado.StatusChamado.NomeStatus != "Em atendimento")
                        {
                            var addTech = new AlterarStatus(usuario, (ChamadoModel)item);
                            addTech.FormClosed += (x, y) =>
                            {
                                this.Show();
                                LoadUsuario();
                            };
                            addTech.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Chamado em Atendimento, Nao pode ser Alterado");

                    }
                    else MessageBox.Show("Chamado Finalizado, Nao pode ser Alterado");

                }else MessageBox.Show("Chamado Sem Tecnico, Nao pode ser Alterado");
            }
            else MessageBox.Show("Nao Existe nenhum Chamado");

        }

        private void DgVisualizar_DoubleClick(object sender, EventArgs e)
        {
            if (listaUsuarios.Count > 0)
            {
                var item = dgVisualizar.CurrentRow.DataBoundItem;
                var chamadoItem = (ChamadoModel)item;
                var Log = new LogController().FindByLog(chamadoItem.Codigo_chamado);
                if (Log.Count > 0)
                {
                    var addTech = new LogMovimentacao(chamadoItem);
                    addTech.FormClosed += (x, y) =>
                    {
                        this.Show();
                        LoadUsuario();
                    };
                    addTech.Show();
                    this.Hide();
                }
            }
        }

        private void BtVisChamado_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.Count != 0)
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var ChamadoItem = (ChamadoModel)linha;
                var menu = new CadastrarTicket(usuario, (ChamadoModel)linha, "Visualizar");
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    LoadUsuario(); 
                };
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nao existe Chamado para Visualizar");
            }
        }
    }
}
