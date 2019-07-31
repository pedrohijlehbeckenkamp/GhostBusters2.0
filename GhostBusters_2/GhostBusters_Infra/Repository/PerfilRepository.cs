using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class PerfilRepository: BaseRepository<PerfilEntity>
    {
        public PerfilEntity findbyName(string name)
        {
            return this.context.Set<PerfilEntity>().FirstOrDefault(x => x.NOME == name);
        }

        //public virtual PerfilEntity FindById(int id)
        //{
        //    return context.Set<PerfilEntity>().Find(id);
        //}

        protected override PerfilEntity Cadastro(PerfilEntity obj)
        {
            var objCadastro = context.Set<PerfilEntity>().Add(obj);
            context.SaveChanges();
            return objCadastro;
        }

        private protected override PerfilEntity Update(PerfilEntity obj)
        {
            var find = FindById(obj.EntityKey);
            context.Entry(find).State = System.Data.Entity.EntityState.Detached;

            var objUpdateP = context.Set<PerfilEntity>().Attach(obj);
            context.Entry(objUpdateP).State = System.Data.Entity.EntityState.Modified;
            context.SendChanges();

            return objUpdateP;
        }
        public void Excluir(int id)
        {
            var obj = FindById(id);
            if (obj != null)
            {
                context.Set<PerfilEntity>().Remove(obj);
                context.SaveChanges();
            }
        }
    }
}
