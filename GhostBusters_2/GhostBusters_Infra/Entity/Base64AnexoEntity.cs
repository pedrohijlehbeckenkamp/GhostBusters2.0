using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("ANEXO")]
    public class Base64AnexoEntity: BaseEntity
    {
       [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_ANEXO { get; set; }
       public string NOME { get; set; }
       public string BASE_64 { get; set; }
       public string EXTENSAO { get; set; }
       public int COD_CHAMADO { get; set; }

       [ForeignKey("COD_CHAMADO")]
       public virtual ChamadoEntity CHAMADO { get; set; }

        public override int? EntityId()
        {
            return COD_ANEXO;
        }

    }
}
