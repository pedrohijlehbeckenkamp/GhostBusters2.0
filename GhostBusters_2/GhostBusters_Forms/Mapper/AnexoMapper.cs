using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class AnexoMapper
    {
        public static Base64AnexoEntity MapAnexoEntity(this Anexo anexo)
        {
            if (anexo == null)
            {
                return null;
            }

            return new Base64AnexoEntity()
            {
                COD_ANEXO = anexo.Codigo_Anexo,
                NOME = anexo.nomeAnexo,
                BASE_64 = anexo.BaseData,
                EXTENSAO = anexo.Extensao,
                COD_CHAMADO = anexo.COD_CHAMADO,
                //CHAMADO = anexo.chamadoModel.MapChamadaEntiy()
            };
        }

        public static Anexo MapAnexoModel(this Base64AnexoEntity base64Anexo)
        {
            if (base64Anexo == null)
            {
                return null;
            }
            return new Anexo()
            {
               Codigo_Anexo = base64Anexo.COD_ANEXO,
               nomeAnexo = base64Anexo.NOME,
               BaseData = base64Anexo.BASE_64,
               Extensao = base64Anexo.EXTENSAO,
                COD_CHAMADO = base64Anexo.COD_CHAMADO,
                //chamadoModel = base64Anexo.CHAMADO.MapChamadaModel()
            };
        }
    }
}
