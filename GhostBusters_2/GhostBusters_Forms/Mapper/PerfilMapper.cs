using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class PerfilMapper
    {
        public static PerfilEntity MapPerfilEntity(this PerfilModel perfil)
        {
            if (perfil == null)
            {
                return null;
            }

            return new PerfilEntity()
            {
                COD_PERFIL = perfil.Codigo,
                NOME = perfil.nomePerfil
            };
        }
        public static PerfilModel MapPerfilModel(this PerfilEntity entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new PerfilModel()
            {
                Codigo = entity.COD_PERFIL,
                nomePerfil = entity.NOME
            };
        }
    }
}
