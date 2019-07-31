using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class StatusModel
    {
        public int codigo_status { get; set; }
        public int? codigo_perfil { get; set; }
        public string NomeStatus { get; set; }
        public PerfilModel perfil { get; set; }
        public string NomePerfil { get { return perfil.nomePerfil; } }
    }
}