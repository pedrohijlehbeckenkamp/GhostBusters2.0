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

namespace GhostBusters_Forms.View
{
    public partial class EditarUsuario : Form
    {
        private Usuario usuario;
        public EditarUsuario(Usuario _usuario)
        {
            InitializeComponent();
            CenterToParent();
            usuario = _usuario;
            tbNome.Text = usuario.NomeUsuario;
            tbEmail.Text = usuario.Email;
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            lbNomeInvalido.Visible = false;
            lbEmailExistente.Visible = false;
            lbEmailInvalido.Visible = false;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            if (Valida())
            {
                new UsuarioController().Cadastro(UpdateUsuario());
                MessageBox.Show("Usuário editado com sucesso!");
                this.Close();
            }
            
        }
        private bool Valida()
        {
            int cont = 0;
            var validaEmail = new UsuarioController().ValidaEmailUnique(tbEmail.Text);

            cont += ValidacoesCampos(Validacoes.ValidaNome(tbNome.Text)
                                , tbNome, lbNomeInvalido, "Nome Invalido");
            if (Validacoes.ValidaNomesDiferentes(tbEmail.Text, usuario.Email))
            {
                if (validaEmail != null)
                    cont += ValidacoesCampos(true, tbEmail, lbEmailExistente, "Email Existente");
            }          
            cont += ValidacoesCampos(Validacoes.ValidaEmail(tbEmail.Text)
                          , tbEmail, lbEmailInvalido, "Email invalido");

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
        private Usuario UpdateUsuario()
        {
            Usuario UpUsuario = usuario;

            UpUsuario.NomeUsuario = tbNome.Text;
            UpUsuario.Email = tbEmail.Text;

            return UpUsuario;
        }

    }
}
