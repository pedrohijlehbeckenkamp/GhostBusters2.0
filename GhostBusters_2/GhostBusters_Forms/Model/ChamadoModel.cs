using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class ChamadoModel
    {
        public int Codigo_chamado { get; set; }
        public int codigo_categoria { get; set; }
        public int codigo_Owner { get; set; }
        public int? codigo_tech { get; set; }
        public int? codigo_status { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Chamado { get; set; }
        public DateTime? Data_Chamado_finalizado { get; set; }
        public ICollection<Anexo> anexos { get; set; } = new HashSet<Anexo>();
        public StatusModel StatusChamado { get; set; }
        public Usuario Owner { get; set; }
        public Usuario Tech { get; set; }
        public CategoriaModel categoria { get; set; }

        public string NomeUsuario2 { get { return Owner.NomeUsuario;  } }
        public string NomeTech { get { return Tech != null ? Tech.NomeUsuario : "Aguardando Tecnico"; ; } }
        public string NomePerfil {  get { return Owner.perfil.nomePerfil; } }
        public string Nomestatus { get { return StatusChamado != null ? StatusChamado.NomeStatus : "Aguardando Atendimento"; } }
        public string nomeCategoria { get { return categoria.NomeCategoria; } }   

    }
}
