using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class ChamadoMapper
    {
        public static ChamadoEntity MapChamadaEntiy(this ChamadoModel chamadoModel)
        {
            if (chamadoModel == null)
            {
                return null;
            }

            return new ChamadoEntity()
            {
                COD_TECH = chamadoModel.codigo_tech,
                COD_CHAMADO = chamadoModel.Codigo_chamado,
                COD_OWNER = chamadoModel.codigo_Owner,
                COD_CATEGORIA = chamadoModel.codigo_categoria,
                COD_STATUS = chamadoModel.codigo_status,
                TITULO = chamadoModel.Titulo,
                DESCRICAO = chamadoModel.Descricao,
                DATA_CHAMADO = chamadoModel.Data_Chamado,
                DATA_CHAMADA_FINALIZADA = chamadoModel.Data_Chamado_finalizado,
                ANEXOS = chamadoModel.anexos.Select(anexo => anexo.MapAnexoEntity()).ToList(),
                CATEGORIA = chamadoModel.categoria.MapCategoriaEntity(),
                _STATUS = chamadoModel.StatusChamado.MapStatusEntity(),
                OWNER = chamadoModel.Owner.MapUsuarioEntity(),
                TECNICO = chamadoModel.Tech.MapUsuarioEntity()               
            };
        }

        public static ChamadoModel MapChamadaModel(this ChamadoEntity chamadoEntity)
        {
            if (chamadoEntity == null)
            {
                return null;
            }

            return new ChamadoModel()
            {
                Codigo_chamado = chamadoEntity.COD_CHAMADO,
                codigo_tech = chamadoEntity.COD_TECH,
                codigo_Owner = chamadoEntity.COD_OWNER,
                codigo_categoria = chamadoEntity.COD_CATEGORIA,
                codigo_status = chamadoEntity.COD_STATUS,
                Titulo = chamadoEntity.TITULO,
                Descricao = chamadoEntity.DESCRICAO,
                Data_Chamado = chamadoEntity.DATA_CHAMADO,
                Data_Chamado_finalizado = chamadoEntity.DATA_CHAMADA_FINALIZADA,
                anexos = chamadoEntity.ANEXOS.Select(ANEXOS => ANEXOS.MapAnexoModel()).ToList(),
                categoria = chamadoEntity.CATEGORIA.MApCategoriaModel(),
                StatusChamado =  chamadoEntity._STATUS.MapStatusModel(),
                Owner = chamadoEntity.OWNER.MapUsuarioModel(),
                Tech = chamadoEntity.TECNICO.MapUsuarioModel()
            };
        }
    }
}
