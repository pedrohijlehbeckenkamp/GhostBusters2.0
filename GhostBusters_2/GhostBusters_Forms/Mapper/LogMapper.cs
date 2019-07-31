using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class LogMapper
    {
        public static LogEntity MapLogEntity(this LogModel logModel)
        {
            return new LogEntity()
            {
                COD_LOG = logModel.Codigo_Log,
                COD_CHAMADO = logModel.Codigo_Chamado,
                //COD_USUARIO = logModel.Codigo_Usuario,
                COD_ANT_STATUS = logModel.Codigo_Ant_Status,
                COD_NEW_STATUS = logModel.Codigo_New_Status,               
                DATA_LOG = logModel.Data_log,
                OBSERVACAO = logModel.Observacao,
                NOME = logModel.Usuario,
                //OWNER = logModel.Owner.MapUsuarioEntity(),
                CHAMADO = logModel.Chamado.MapChamadaEntiy(),
                STATUS_ANT = logModel.Status_Ant.MapStatusEntity(),
                STATUS_NEW = logModel.Status_New.MapStatusEntity(),
            };
        }
        public static LogModel MapLogModel(this LogEntity logEntity)
        {
            return new LogModel()
            {
                Codigo_Log = logEntity.COD_LOG,
                Codigo_Chamado = logEntity.COD_CHAMADO,
                //Codigo_Usuario = logEntity.COD_USUARIO,
                Codigo_Ant_Status = logEntity.COD_ANT_STATUS,
                Codigo_New_Status = logEntity.COD_NEW_STATUS,
                Observacao = logEntity.OBSERVACAO,
                Data_log = logEntity.DATA_LOG,
                Usuario = logEntity.NOME,
                Chamado = logEntity.CHAMADO.MapChamadaModel(),
                Status_Ant = logEntity.STATUS_ANT.MapStatusModel(),
                Status_New = logEntity.STATUS_NEW.MapStatusModel(),
               // Owner = logEntity.OWNER.MapUsuarioModel()
            };
        }
    }
}
