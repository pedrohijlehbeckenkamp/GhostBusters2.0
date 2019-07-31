using System;
using GhostBusters_Infra;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GhostBusters_Forms.Adm;
using GhostBusters_Forms.Model;
using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Usuário_Comum;
using GhostBusters_Forms.View.Tech;

namespace GhostBusters_Forms
{
    public partial class Login : Form
    {
        CadastroUsuario objLogin = new  CadastroUsuario();

        
        public Login()
        {
            InitializeComponent();
            lbErro.Visible = false;
            CenterToParent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        public void HabilitarErro()
        {
            lbErro.Visible = true;
        }

        public Usuario GetLogin() => new Usuario
        {
            Email = tbUsuario.Text,
            Senha = tbSenha.Text,
        };

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Validar();
            LimparLogin();
        }

        private void TbSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Validar();
            }
        }

        private void TbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Validar();
            }
        }

        private void Validar()
        {
            var login = new UsuarioController().ValidaLogin(GetLogin().Email, GetLogin().Senha);

            if (login != null)
            {
                var menuAdmin = new TelaPrincipalAdm(login);
                var menuUsuario = new InicUsuarioComum(login);
                var menuTech = new IniciTech(login);
                if (login.perfil.nomePerfil == "Admin")
                {
                    menuAdmin.FormClosed += (x, y) =>
                    {
                        this.Show();
                    };
                    menuAdmin.Show();
                    this.Hide();
                }//else MessageBox.Show("No Existe");

                if (login.perfil.nomePerfil == "Usuario")
                {
                    menuUsuario.FormClosed += (x, y) =>
                    {
                        this.Show();
                    };
                    menuUsuario.Show();
                    this.Hide();
                }//else MessageBox.Show("No Existe"); 

                if (login.perfil.nomePerfil == "Técnico")
                {
                    menuTech.FormClosed += (x, y) =>
                    {
                        this.Show();
                    };
                    menuTech.Show();
                    this.Hide();
                }//else MessageBox.Show("No Existe");
                lbErro.Visible = false;
                LimparLogin();
            }
            else
            {
                HabilitarErro();
                LimparLogin();
            }
        }
        public void LimparLogin()
        {
            tbSenha.Text = "";
            tbUsuario.Text = "";
        }

        private void BtVisSenha_MouseLeave(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
        }

        private void BtVisSenha_MouseEnter(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
        }
    }
}
