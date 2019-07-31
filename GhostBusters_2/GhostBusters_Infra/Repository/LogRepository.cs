using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class LogRepository: BaseRepository<LogEntity>
    {
        public List<LogEntity> FindByLog(int codigo_chamado)
        {
            return context.Set<LogEntity>().
                    Where(codigo => codigo.COD_CHAMADO == codigo_chamado).ToList();
        }
        //public override LogEntity CadastroUpdate(LogEntity obj)
        //{
        //    obj.COD_CHAMADO = obj.CHAMADO.COD_CHAMADO;
        //    obj.COD_USUARIO = obj.OWNER.COD_USUARIO;
        //    obj.COD_ANT_STATUS = obj.STATUS_ANT.COD_STATUS;
        //    obj.COD_NEW_STATUS = obj.STATUS_NEW.COD_STATUS;

        //    return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        //}

        public LogEntity CadastroLog(LogEntity obj)
        {
            obj.COD_CHAMADO = obj.CHAMADO.COD_CHAMADO;
           // obj.COD_USUARIO = obj.OWNER.COD_USUARIO;
            obj.COD_ANT_STATUS = obj.STATUS_ANT.COD_STATUS;
            obj.COD_NEW_STATUS = obj.STATUS_NEW.COD_STATUS;

            var objCadastro = context.Set<LogEntity>().Add(obj);

            //context.Entry(obj.OWNER).State = System.Data.Entity.EntityState.Detached;
            //context.Entry(obj.OWNER.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;
            //context.Entry(obj.OWNER.PERFIL).State = System.Data.Entity.EntityState.Unchanged;

            context.Entry(obj.STATUS_ANT).State = System.Data.Entity.EntityState.Unchanged;

            if (obj.STATUS_ANT.PERFIL != null)
            {
                context.Entry(obj.STATUS_ANT.PERFIL).State = System.Data.Entity.EntityState.Unchanged;
            }


            if (obj.STATUS_NEW.PERFIL != null)
            {
                context.Entry(obj.STATUS_NEW.PERFIL).State = System.Data.Entity.EntityState.Unchanged;
            }
            context.Entry(obj.STATUS_NEW).State = System.Data.Entity.EntityState.Unchanged;

            context.Entry(obj.CHAMADO).State = System.Data.Entity.EntityState.Unchanged;
            //context.Entry(obj.CHAMADO.ANEXOS).State = System.Data.Entity.EntityState.Unchanged;
            //context.Entry(obj.CHAMADO.OWNER).State = System.Data.Entity.EntityState.Detached;

            context.Entry(obj.CHAMADO.OWNER).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.CHAMADO.OWNER.PERFIL).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.CHAMADO.OWNER.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.CHAMADO.CATEGORIA).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(obj.CHAMADO._STATUS).State = System.Data.Entity.EntityState.Detached;

            if (obj.CHAMADO.ANEXOS.Count > 0)
            {
                foreach (var item in obj.CHAMADO.ANEXOS)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Unchanged;
                }
            }

            if (obj.CHAMADO.TECNICO != null)
            {
                context.Entry(obj.CHAMADO.TECNICO).State = System.Data.Entity.EntityState.Unchanged;
                context.Entry(obj.CHAMADO.TECNICO.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;
                context.Entry(obj.CHAMADO.TECNICO.PERFIL).State = System.Data.Entity.EntityState.Unchanged;
            }

            context.SendChanges();
            return objCadastro;
        }
    }
}
