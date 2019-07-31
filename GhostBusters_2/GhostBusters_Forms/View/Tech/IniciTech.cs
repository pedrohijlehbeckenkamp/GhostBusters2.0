using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.View.Adm;
using GhostBusters_Forms.View.Tech;
using GhostBusters_Forms.View.Ticket;
using GhostBusters_Forms.View.Usuário_Comum;

namespace GhostBusters_Forms.View.Tech
{
    public partial class IniciTech : Form
    {
        private Usuario usuario;
        private List<ChamadoModel> chamadoModel;

        string CB = "";
        public IniciTech(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuario = _usuario;
        }
        private void InciTechcs_Load(object sender, EventArgs e)
        {
            LoadTech();
        }
        private void LoadTech()
        {
            maskedCod.Visible = false;
            tbConteudo.Visible = false;
            cbGeral.Visible = false;
            dtData.Visible = false;

            LoadImagem();
            lblDate.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
            lblNomeTec.Text = usuario.NomeUsuario;
            lblEmailTec.Text = usuario.Email;
            dgVisualizar.AutoGenerateColumns = false;
            chamadoModel = new ChamadoController().FindByTecnico(usuario.Codigo_Usuario);
            dgVisualizar.DataSource = chamadoModel;
        }

        private void LoadImagem()
        {
            var imagem = new ImagemController().FindById(usuario.Codigo_imagem);
            byte[] bytes = Convert.FromBase64String(imagem.BaseData);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                pbPerfil.Image = Image.FromStream(ms);
            }
        }

        private void LinkLEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlteraPic alteraPic = new AlteraPic(usuario);
            alteraPic.Show();
            alteraPic.FormClosed += (x, y) =>
            {
                this.Show();
                LoadTech();
            };
            alteraPic.Show();
            this.Hide();
        }

        private void LinkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlterarSenha form = new AlterarSenha(usuario);
            form.Show();
            form.FormClosed += (x, y) =>
            {
                this.Show();
                LoadTech();
            };
            form.Show();
            this.Hide();
        }

        private void BtnEditarChamado_Click(object sender, EventArgs e)
        {
            // var linha = dgVisualizar.CurrentRow.DataBoundItem;
            if (chamadoModel.Count != 0)
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var ChamadoItem = (ChamadoModel)linha;
                if (ChamadoItem.Data_Chamado_finalizado == null)
                {
                    var menu = new CadastrarTicket(usuario, (ChamadoModel)linha, "Editar");
                    menu.FormClosed += (x, y) =>
                    {
                        this.Show();
                        LoadTech();
                    };
                    menu.Show();
                    this.Hide();
                }else MessageBox.Show("Chamado Finalizado, Nao pode ser Alterado");
            }
            else
            {
                MessageBox.Show("Nao existe Chamado para editar");
            }
        }
        private void BtAlterarStatus_Click(object sender, EventArgs e)
        {
            if (chamadoModel.Count != 0)
            {
                var item = dgVisualizar.CurrentRow.DataBoundItem;
                var ChamadoItem = (ChamadoModel)item;
                if (ChamadoItem.Data_Chamado_finalizado == null)
                {
                    var addTech = new AlterarStatus(usuario, ChamadoItem);
                    addTech.FormClosed += (x, y) =>
                    {
                        this.Show();
                        LoadTech();
                    };
                    addTech.Show();
                    this.Hide();
                }
                else MessageBox.Show("Chamado Finalizado, Nao pode ser Alterado");
                
            }
            else MessageBox.Show("Não Existe Chamado");
            
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (cbOrderBy.Text == "Código ticket")
            {
                if (maskedCod.Text != "")
                {
                    int Id = Convert.ToInt32(maskedCod.Text);

                    List<ChamadoModel> lista = new List<ChamadoModel>();

                    for (int i = 0; i < chamadoModel.Count; i++)
                    {
                        if (chamadoModel[i].Codigo_chamado == Id)
                        {
                            lista.Add(chamadoModel[i]);
                        }
                    }
                    dgVisualizar.AutoGenerateColumns = false;
                    dgVisualizar.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("Insira um Id válido.");
                }
            }
            else if (cbOrderBy.Text == "Conteúdo")
            {
                if (tbConteudo.Text != "")
                {
                    string padrao = tbConteudo.Text;

                    //var Chamados = new ChamadoController().Findall();

                    List<ChamadoModel> lista = new List<ChamadoModel>();

                    for (int i = 0; i < chamadoModel.Count; i++)
                    {
                        if (chamadoModel[i].Descricao.Contains(padrao))
                        {
                            lista.Add(chamadoModel[i]);
                        }
                    }
                    dgVisualizar.AutoGenerateColumns = false;
                    dgVisualizar.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("Digite algo para fazer a pesquisa.");
                }
            }
            else if (cbOrderBy.Text == "Data")
            {
                DateTime date = dtData.Value.Date;

                List<ChamadoModel> lista = new List<ChamadoModel>();

                for (int i = 0; i < chamadoModel.Count; i++)
                {
                    if (chamadoModel[i].Data_Chamado.Date == date)
                    {
                        lista.Add(chamadoModel[i]);
                    }
                }
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
            else if (cbOrderBy.Text == "Status")
            {
                var Status = (StatusModel)cbGeral.SelectedItem;
                int id = Status.codigo_status;

                List<ChamadoModel> lista = new List<ChamadoModel>();

                for (int i = 0; i < chamadoModel.Count; i++)
                {
                    if (chamadoModel[i].codigo_status == id)
                    {
                        lista.Add(chamadoModel[i]);
                    }
                }
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }

            else if (cbOrderBy.Text == "Usuário")
            {
                var Usuarios = (Usuario)cbGeral.SelectedItem;
                int id = Usuarios.Codigo_Usuario;

                List<ChamadoModel> lista = new List<ChamadoModel>();

                for (int i = 0; i < chamadoModel.Count; i++)
                {
                    if (chamadoModel[i].codigo_Owner == id)
                    {
                        lista.Add(chamadoModel[i]);
                    }
                }
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }
            else if (cbOrderBy.Text == "Categoria")
            {
                var Categoria = (CategoriaModel)cbGeral.SelectedItem;
                int id = Categoria.Codigo_categoria;

                List<ChamadoModel> lista = new List<ChamadoModel>();

                for (int i = 0; i < chamadoModel.Count; i++)
                {
                    if (chamadoModel[i].codigo_categoria == id)
                    {
                        lista.Add(chamadoModel[i]);
                    }
                }
                dgVisualizar.AutoGenerateColumns = false;
                dgVisualizar.DataSource = lista;
            }

            else if (cbOrderBy.Text == "Todos")
            {
                LoadTech();
            }
        }

        private void AlimentarCB()
        {
            if (CB == "Status")
            {
                cbGeral.DataSource = new StatusController().FindStatusPerfil(2, 3);
                cbGeral.DisplayMember = "NomeStatus";
            }
            else if (CB == "Usuário")
            {
                cbGeral.DataSource = new UsuarioController().FindByUsuario("Usuario");
                cbGeral.DisplayMember = "NomeUsuario";
            }
            else if (CB == "Categoria")
            {
                cbGeral.DataSource = new CategoriaController().FindByCategoria();
                cbGeral.DisplayMember = "NomeCategoria";
            }
        }

        private void CbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (cbOrderBy.Text == "Código ticket")
            {
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
            else if (cbOrderBy.Text == "Usuário")
            {
                CB = "Usuário";
                AlimentarCB();
                cbGeral.Visible = true;
            }
            else if (cbOrderBy.Text == "Categoria")
            {
                CB = "Categoria";
                AlimentarCB();
                cbGeral.Visible = true;
            }
            else
            {
                cbGeral.Visible = false;
            }
        }

        private void DgVisualizar_DoubleClick(object sender, EventArgs e)
        {
            if (chamadoModel.Count >= 0)
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
                        LoadTech();
                    };
                    addTech.Show();
                    this.Hide();
                }
            }
        }

        private void BtVisChamado_Click(object sender, EventArgs e)
        {
            if (chamadoModel.Count != 0)
            {
                var linha = dgVisualizar.CurrentRow.DataBoundItem;
                var ChamadoItem = (ChamadoModel)linha;
                var menu = new CadastrarTicket(usuario, (ChamadoModel)linha, "Visualizar");
                menu.FormClosed += (x, y) =>
                {
                    this.Show();
                    LoadTech();
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