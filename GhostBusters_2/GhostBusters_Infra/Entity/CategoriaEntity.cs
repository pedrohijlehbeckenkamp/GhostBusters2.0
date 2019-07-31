using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("CATEGORIA")]
    public class CategoriaEntity: BaseEntity
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_CATEGORIA { get; set; }
        public string NOME { get; set; }

        public override int? EntityId()
        {
            return COD_CATEGORIA;
        }
    }
}
