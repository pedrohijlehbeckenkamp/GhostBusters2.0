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
    public class StatusController
    {
        public List<StatusModel> FindAll()
        {
            return new StatusRepository().GetAll().Select(statusmodel => statusmodel.MapStatusModel()).ToList();
        }
        public StatusModel FindByName(string nome)
        {
            return new StatusRepository().findbyName(nome).MapStatusModel();
        }

        public List<StatusModel> FinByStatusPerfil(int codigo_perfil)
        {
            return new StatusRepository().FindByStatusPerfil(codigo_perfil)
                            .Select(status => status.MapStatusModel()).ToList();
        }

        public List<StatusModel> FindStatusPerfil(int statusT, int statusU)
        {
            return new StatusRepository().FindStatusPerfil(statusT, statusU)
                            .Select(status => status.MapStatusModel()).ToList();
        }
        internal StatusModel Cadastro(StatusModel statusModel)
        {
            return new StatusRepository().CadastroUpdate(statusModel.MapStatusEntity()).MapStatusModel();
        }
        public void Excluir(StatusModel status)
        {
            new StatusRepository().Excluir(status.MapStatusEntity().COD_STATUS);
        }
    }
 }