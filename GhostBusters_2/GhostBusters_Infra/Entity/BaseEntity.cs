using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    public abstract class BaseEntity
    {
        public abstract int? EntityId();

        public int EntityKey
        {
            get
            {
                return EntityId().HasValue ? EntityId().Value : 0;
            }
        }
    }
}
