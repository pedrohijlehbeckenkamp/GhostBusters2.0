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
    public partial class ExcluirChamado : Form
    {
        public ExcluirChamado()
        {
            InitializeComponent();
            CenterToParent();
        }
        
        public void loadExcluirChamado()
        {
            dgVisualizar.AutoGenerateColumns = false;
            dgVisualizar.DataSource = new ChamadoController().FindByExcluir();
        }

        private void ExcluirChamado_Load(object sender, EventArgs e)
        {
            loadExcluirChamado();
        }
        public void ExcluirChamdo()
        {

        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
           
            var itemSelecionado = dgVisualizar.CurrentRow.DataBoundItem;
            ChamadoModel chamado = (ChamadoModel)itemSelecionado; 
            try
            {
                new ChamadoController().ExcluirChamado(chamado);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ ex);
               // throw;
            }
        }
    }
}
