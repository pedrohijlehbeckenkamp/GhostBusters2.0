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
    public class PerfilController
    {
        public PerfilModel BuscaNome(string nome)
        {
            return new PerfilRepository().findbyName(nome).MapPerfilModel();
        }
        public List<PerfilModel> FindAll()
        {
            return new PerfilRepository().FindALL().Select(perfil => perfil.MapPerfilModel()).ToList();
        }

        internal PerfilModel Cadastro(PerfilModel perfil)
        {
            return new PerfilRepository().CadastroUpdate(perfil.MapPerfilEntity()).MapPerfilModel();
        }

        internal void Excluir(PerfilModel perfil)
        {
            new PerfilRepository().Excluir(perfil.MapPerfilEntity().COD_PERFIL);
        }
        public PerfilModel FindById(int codigo)
        {
            return new PerfilRepository().FindById(codigo).MapPerfilModel();
        }
    }
}
