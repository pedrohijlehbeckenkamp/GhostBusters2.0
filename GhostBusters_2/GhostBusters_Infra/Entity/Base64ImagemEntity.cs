using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("IMAGEM")]
   public class Base64ImagemEntity: BaseEntity
    {
        public override int? EntityId()
        {
            return COD_IMAGEM;
        }

        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_IMAGEM { get; set; }
        public string NOME { get; set; } 
        public string BASE_DATA { get; set; }
    }
}
