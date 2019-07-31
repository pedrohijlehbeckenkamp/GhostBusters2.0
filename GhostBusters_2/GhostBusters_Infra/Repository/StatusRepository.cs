using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class StatusRepository: BaseRepository<StatusEntity>
    {
        public StatusEntity findbyName(string name)
        {
            return this.context.Set<StatusEntity>().FirstOrDefault(x => x.NOME == name);
        }

        public List<StatusEntity> FindByStatusPerfil(int codigo_perfil)
        {
            return this.context.Set<StatusEntity>()
                .Where(status => status.COD_PERFIL == codigo_perfil || status.COD_PERFIL == null).ToList();
        }

        public List<StatusEntity> FindStatusPerfil(int statusT, int statusU)
        {
            return this.context.Set<StatusEntity>()
                .Where(status => status.COD_PERFIL == statusT || status.COD_PERFIL == statusU).ToList();
        }

        public override StatusEntity CadastroUpdate(StatusEntity obj)
        {
            if(obj == null)
            {
                return null;
            }

            obj.COD_PERFIL = obj.PERFIL?.COD_PERFIL;
            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        public IEnumerable<StatusEntity> GetAll()
        {
            var dbSet = context.Set<StatusEntity>();
            var dbSetPerfil = context.Set<PerfilEntity>();

            var result =
                from status in dbSet
                join perfil in dbSetPerfil on status.COD_PERFIL equals perfil.COD_PERFIL
                select
                    status;

            return result.ToList();
        }

        protected override StatusEntity Cadastro(StatusEntity obj)
        {
            var objStatus = context.Set<StatusEntity>().Add(obj);

            if (obj.COD_PERFIL != null)
                context.Entry(obj.PERFIL).State = System.Data.Entity.EntityState.Unchanged;

            context.SaveChanges();
            return objStatus;
        }

        private protected override StatusEntity Update(StatusEntity obj)
        {
            var finded = FindById(obj.EntityKey);
            context.Entry(finded).State = System.Data.Entity.EntityState.Detached;

            var objUpdate = context.Set<StatusEntity>().Attach(obj);
            context.Entry(objUpdate).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return objUpdate;
        }
    }
}
