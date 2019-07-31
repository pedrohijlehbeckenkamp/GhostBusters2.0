using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("_STATUS")]
    public class StatusEntity: BaseEntity
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_STATUS { get; set; }
        public string NOME { get; set; }
        public int? COD_PERFIL { get; set; }

        [ForeignKey("COD_PERFIL")]
        public virtual PerfilEntity PERFIL { get; set; }

        public override int? EntityId()
        {
            return COD_STATUS;
        }
    }
}
