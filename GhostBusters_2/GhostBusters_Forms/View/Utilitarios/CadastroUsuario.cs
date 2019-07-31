using GhostBusters_Forms.Controller;
using GhostBusters_Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms
{
    public partial class CadastroUsuario : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        
        public CadastroUsuario()
        {
            InitializeComponent();
            CenterToParent();
        }
        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            LoadCadastroUsuario();
            //LoadImagem();
            //CbListarPerfil.DataSource = new PerfilController().FindAll();
            //CbListarPerfil.DisplayMember = "nomePerfil";
            //lbEmailErro.Visible = false;
            //lbErroConfEmail.Visible = false;
            //lbNomeErro.Visible = false;
        }
        private void LoadCadastroUsuario()
        {
            LoadImagem();
            CbListarPerfil.DataSource = new PerfilController().FindAll();
            CbListarPerfil.DisplayMember = "nomePerfil";
            lbEmailErro.Visible = false;
            lbErroConfEmail.Visible = false;
            lbNomeErro.Visible = false;
            lbErroSenha.Visible = false;
            lbErroConfSenha.Visible = false;
        }
        private void ButSave_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                ImagemModel image = null;

                FileInfo file = new FileInfo(pictureImagem.ImageLocation);
                image = new ImagemController().Cadastro(SalvarImagemBase64(file));

                new UsuarioController().Cadastro(GetUsuario(image));
                MessageBox.Show("Casdastro realizado com sucesso!!");
                this.Close();
            }
        }

        public Usuario GetUsuario(ImagemModel imagem) => new Usuario
        {
            NomeUsuario = tbNome.Text,
            Email = tbEmail.Text,
            Senha = tbSenha.Text,
            perfil = new PerfilController().BuscaNome(CbListarPerfil.Text),
            Foto = imagem
        };

        public bool Valida()
        {
            int cont = 0;
            var validaEmail = new UsuarioController().ValidaEmailUnique(tbEmail.Text);
            cont += ValidacoesCampos(Validacoes.ValidaNome(tbNome.Text)
                                , tbNome, lbNomeErro, "Nome Invalido");
           
            cont += ValidacoesCampos(Validacoes.ValidaEmail(tbEmail.Text)
                               , tbEmail, lbEmailErro, "Email invalido");
            
            cont += ValidacoesCampos(Validacoes.ValidaNomesDiferentes(tbEmail.Text, tbConfirmaEmail.Text)
                              , tbConfirmaEmail, lbErroConfEmail, "Email Difrentes");
            if (validaEmail != null)
            {
                ValidacoesCampos(true, tbEmail, lbEmailErro, "Email Existente");
            }  
            cont += ValidacoesCampos(Validacoes.ValidaTamanhaSenha(tbSenha.Text)
                             , tbSenha, lbErroSenha, "Senha Invalida");

            cont += ValidacoesCampos( Validacoes.ValidaNomesDiferentes(tbSenha.Text, tbConfirmeSenha.Text)
                               , tbConfirmeSenha, lbErroConfSenha, "Senha Difrentes");

            if (cont > 0)
            {
                return false;
            }
            return true;
        }


        private int ValidacoesCampos(bool test2, TextBox textBox, Label label, string messagem)
        {
            int cont = 0;
            if (!Validacoes.ValidaCamponull(textBox.Text))
            {
                if (test2)
                {
                    textBox.BackColor = Color.Red;
                    label.Visible = true;
                    label.Text = messagem;
                    cont++;
                }
                else
                {
                    textBox.BackColor = Color.White;
                    label.Visible = false;
                }
            }
            else
            {
                textBox.BackColor = Color.Red;
                label.Visible = true;
                label.Text = "Campo Null";
                cont++;
            }
            return cont;
        }

        private OpenFileDialog GetOpenFileDialog()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }

            return null;
        }

        private void BtnAbrirImagem_Click(object sender, EventArgs e)
        {
            AbrirImagem();
        }
        private void AbrirImagem()
        {
            var fileDialog = GetOpenFileDialog();
            if (fileDialog != null)
            {
                string location = fileDialog.FileName;
                pictureImagem.ImageLocation = location;
                pictureImagem.Load();
            }
        }

        private ImagemModel SalvarImagemBase64(FileInfo file) => new ImagemModel
        {
            nomeImagem = file.Name,
            BaseData = Convert.ToBase64String(File.ReadAllBytes(file.FullName))
        };

        private void LoadImagem()
        {
            var imagem = new ImagemController().BuscaNome("default.png");
            byte[] bytes = Convert.FromBase64String(imagem.BaseData);
            File.WriteAllBytes("C:\\Teste\\" + imagem.nomeImagem, bytes);
            pictureImagem.ImageLocation = ("C:\\Teste\\" + imagem.nomeImagem);

        }
        private void ClearImagem_Click(object sender, EventArgs e)
        {
            LoadImagem();//Recarrega imagem primaria
        }

        private void BtVisSenha_MouseEnter(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
            tbConfirmeSenha.PasswordChar = tbConfirmeSenha.PasswordChar == char.MinValue ? tbConfirmeSenha.PasswordChar = '*' : char.MinValue;
        }

        private void BtVisSenha_MouseLeave(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
            tbConfirmeSenha.PasswordChar = tbConfirmeSenha.PasswordChar == char.MinValue ? tbConfirmeSenha.PasswordChar = '*' : char.MinValue;
        }
    }
}
