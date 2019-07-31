using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class StatusMapper
    {
        public static StatusEntity MapStatusEntity(this StatusModel statusModel)
        {
            if (statusModel == null)
            {
                return null;
            }
            return new StatusEntity()
            {
                COD_STATUS = statusModel.codigo_status,
                COD_PERFIL = statusModel.codigo_perfil,
                NOME = statusModel.NomeStatus,
                PERFIL = statusModel.perfil.MapPerfilEntity()
            };
        }

       public static StatusModel MapStatusModel(this StatusEntity statusEntity)
        {
            if (statusEntity == null)
            {
                return null;
            }
            return new StatusModel()
            {
                codigo_status = statusEntity.COD_STATUS,
                codigo_perfil = statusEntity.COD_PERFIL,
                NomeStatus = statusEntity.NOME,
                perfil = statusEntity.PERFIL.MapPerfilModel()
            };
        }
    }
}
