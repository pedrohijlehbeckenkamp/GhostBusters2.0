using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("LOG_MOVIMENTACAO")]
    public class LogEntity: BaseEntity
    {
        [Key]
        public int COD_LOG { get; set; }

        public string OBSERVACAO { get; set; }
        public DateTime DATA_LOG { get; set; }
        public string NOME { get; set; }

        //[ForeignKey("COD_USUARIO")]
        //public virtual UsuarioEntity OWNER { get; set; }
        //public int COD_USUARIO { get; set; }

        [ForeignKey("COD_ANT_STATUS")]
        public virtual StatusEntity STATUS_ANT { get; set; }
        public int COD_ANT_STATUS { get; set; }

        [ForeignKey("COD_NEW_STATUS")]
        public virtual StatusEntity STATUS_NEW { get; set; }
        public int COD_NEW_STATUS { get; set; }

        [ForeignKey("COD_CHAMADO")]
        public virtual ChamadoEntity CHAMADO { get; set; }
        public int COD_CHAMADO { get; set; }

        public override int? EntityId()
        {
            return COD_LOG;
        }
    }
}
