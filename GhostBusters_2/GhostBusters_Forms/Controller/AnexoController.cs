using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class AnexoController
    {
        public Anexo CadastroOrUpdate(Anexo anexo)
        {
            return new AnexoRepository().CadastroUpdate(anexo.MapAnexoEntity()).MapAnexoModel();
        }
        public void AddChamado(List<Anexo> anexonew, int codigo_chamado)
        {
            new AnexoRepository().AddChamadoAoAnexo(anexonew.Select(x => x.MapAnexoEntity()).ToList(), codigo_chamado);
        }
        public void ExcluirAnexo(int id)
        {
            new AnexoRepository().Excluir(id);
        }
        public List<Anexo> FindbyChamado(int codigo_chamado)
        {
            return new AnexoRepository().FindByChamado(codigo_chamado).Select(codigo => codigo.MapAnexoModel()).ToList();
        }

    }
}
