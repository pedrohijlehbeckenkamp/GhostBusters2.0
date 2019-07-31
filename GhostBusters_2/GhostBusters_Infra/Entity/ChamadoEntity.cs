using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("CHAMADO")]
    public class ChamadoEntity: BaseEntity
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_CHAMADO { get; set; }
        
        public string TITULO { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime DATA_CHAMADO { get; set; }
        public DateTime? DATA_CHAMADA_FINALIZADA { get; set; }
        public int? COD_STATUS { get; set; }
        
        [ForeignKey("COD_STATUS")]
        public virtual StatusEntity _STATUS { get; set; }
       
        [ForeignKey("COD_CATEGORIA")]
        public virtual CategoriaEntity CATEGORIA { get; set; }
        public int COD_CATEGORIA { get; set; }
        

        [ForeignKey("COD_OWNER")]
        public virtual UsuarioEntity OWNER { get; set; }
        public int COD_OWNER { get; set; }
        

        [ForeignKey("COD_TECH")]
        public virtual UsuarioEntity TECNICO { get; set; }
        public int? COD_TECH { get; set; }
        public virtual ICollection<Base64AnexoEntity> ANEXOS { get; set; } = new HashSet<Base64AnexoEntity>();
        public override int? EntityId()
        {
            return COD_CHAMADO;
        }



    }
}
