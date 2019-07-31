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
    public partial class LogMovimentacao : Form
    {
        private ChamadoModel chamado; 
        public LogMovimentacao(ChamadoModel _chamado)
        {
            InitializeComponent();
            CenterToParent();
            chamado = _chamado;
        }

        private void LogMovimentacao_Load(object sender, EventArgs e)
        {
            dgLog.AutoGenerateColumns = false;
            dgLog.DataSource = new LogController().FindByLog(chamado.Codigo_chamado);
        }

        private void DgLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgLog.CurrentRow.DataBoundItem;
            var Logitem = (LogModel)item;
            tbObservacao.Text = Logitem.Observacao;
        }
    }
}
