        using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Repository
{
    public class ImagemRepository: BaseRepository<Base64ImagemEntity>
    {
        public Base64ImagemEntity findbyName(string name)
        {
            return this.context.Set<Base64ImagemEntity>().FirstOrDefault(x => x.NOME == name);
        }
    }
}
