using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("PERFIL")]
    public class PerfilEntity: BaseEntity
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_PERFIL { get; set; }
        public string NOME { get; set; }

        public override int? EntityId()
        {
            return COD_PERFIL;
        }

    }
}
