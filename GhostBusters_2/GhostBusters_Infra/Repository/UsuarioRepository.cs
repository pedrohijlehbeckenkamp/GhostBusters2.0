using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class UsuarioRepository: BaseRepository<UsuarioEntity>
    {
        public UsuarioEntity findbyLogin(string email, string senha)
        {
            return context.Set<UsuarioEntity>().AsNoTracking().FirstOrDefault(x => x.EMAIL == email && x.SENHA == senha );
        }
        public UsuarioEntity findbyEmail(string email)
        {
            return context.Set<UsuarioEntity>().AsNoTracking().FirstOrDefault(x => x.EMAIL == email);
        }
        public List<UsuarioEntity> findbyPerfil(string perfil)
        {
            return context.Set<UsuarioEntity>().AsNoTracking().Where(x => x.PERFIL.NOME == perfil).ToList();
        }

        public List<UsuarioEntity> FindByUsuario(string perfil)
        {
            return this.context.Set<UsuarioEntity>()
                .Where(usuario => usuario.PERFIL.NOME == perfil).ToList();
        }

        public UsuarioEntity FindUsuario(int codigo)
        {
            return context.Set<UsuarioEntity>().FirstOrDefault(perfil => perfil.COD_PERFIL == codigo);
        }

        public override UsuarioEntity CadastroUpdate(UsuarioEntity obj)//Cadastra ou Update
        {
            if (obj == null)
            {
                return null;
            }

            obj.COD_PERFIL = obj.PERFIL.COD_PERFIL;
            obj.COD_IMAGEM = obj.IMAGEM.COD_IMAGEM;
            return obj.EntityId().HasValue && FindById(obj.EntityKey) != null ? Update(obj) : Cadastro(obj);
        }

        protected override UsuarioEntity Cadastro(UsuarioEntity obj)//Cadastrar um novo obj 
        {
            var objCadastro = context.Set<UsuarioEntity>().Add(obj);
            context.Entry(obj.PERFIL).State = System.Data.Entity.EntityState.Unchanged;

            if (obj.IMAGEM!=null)
                context.Entry(obj.IMAGEM).State = System.Data.Entity.EntityState.Unchanged;

            context.SendChanges();
            return objCadastro;
        }
        protected override private UsuarioEntity Update(UsuarioEntity obj)//Update Obj
        {
            var finded = FindById(obj.EntityKey);
            context.Entry(finded).State = System.Data.Entity.EntityState.Detached;//ignorar a pk  e inserir 

            var objUpdated = context.Set<UsuarioEntity>().Attach(obj);
            context.Entry(objUpdated).State = System.Data.Entity.EntityState.Modified;
            context.SendChanges();

            return objUpdated;
        }
    }
}
