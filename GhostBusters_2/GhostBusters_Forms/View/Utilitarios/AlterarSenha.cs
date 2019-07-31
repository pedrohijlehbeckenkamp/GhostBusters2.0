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

namespace GhostBusters_Forms
{
    public partial class AlterarSenha : Form
    {

        private Usuario usuario;

        public AlterarSenha(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuario = _usuario;
        }

        private void EditarUsuarios_Load(object sender, EventArgs e)
        {
            //ValidaSenha();
            LoadEditarSenha();
        }

        private void LoadEditarSenha()
        {
            lbSenhaPrinc.Visible = false;
            lbInsiraSenha.Visible = false;
            lbConfSenha.Visible = false;
            lbNome.Text = usuario.NomeUsuario;
            lbPerfil.Text = usuario.NomePerfil;
            lbEmail.Text = usuario.Email;
        }

        private bool ValidaSenha()
        {
            int cont = 0;

            cont += ValidacoesCampos(Validacoes.ValidaNomesDiferentes(usuario.Senha, tbSenha.Text), 
                                            tbSenha,lbSenhaPrinc, "Insira sua senha atual");

            cont += ValidacoesCampos(Validacoes.ValidaTamanhaSenha(tbNovaSenha.Text)
                                 , tbNovaSenha, lbInsiraSenha, "Senha Invalida");

            cont += ValidacoesCampos(Validacoes.ValidaNomesDiferentes(tbNovaSenha.Text, tbConfSenha.Text),
                                           tbConfSenha, lbConfSenha, "Senha Diferentes");

            cont += ValidacoesCampos(Validacoes.ValidaNomesDiferentes(tbNovaSenha.Text, tbConfSenha.Text),
                                           tbConfSenha, lbConfSenha, "Senha Diferentes");
            cont += ValidacoesCampos(Validacoes.ValidaSenhasIguais(tbConfSenha.Text, tbSenha.Text), tbConfSenha, lbConfSenha, "Insira uma nova Senha");

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
        private void ButSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {           
             if (ValidaSenha())
             {
               new UsuarioController().Cadastro(Update());

               MessageBox.Show("Senha alterada!!!");
               this.Close();
             }         
        }

        private Usuario Update() 
        {
            Usuario Upusuario = usuario;
            Upusuario.Senha = tbConfSenha.Text;
            return Upusuario;
        }

        private void BtVisSenha_MouseEnter(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
        }

        private void BtVisSenha_MouseLeave(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = tbSenha.PasswordChar == char.MinValue ? tbSenha.PasswordChar = '*' : char.MinValue;
        }
    }
}
