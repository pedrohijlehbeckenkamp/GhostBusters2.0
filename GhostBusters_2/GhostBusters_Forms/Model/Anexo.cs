using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class Anexo
    {
        public int Codigo_Anexo { get; set; }
        public int COD_CHAMADO { get; set; }
        public string nomeAnexo { get; set; }
        public string BaseData { get; set; }
        public string Extensao { get; set; }
        public ChamadoModel chamadoModel { get; set; }
    }
}
