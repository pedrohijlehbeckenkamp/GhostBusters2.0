using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra.Entity
{
    [Table("USUARIO")]
    public class UsuarioEntity: BaseEntity
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_USUARIO { get; set; }

        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string SENHA { get; set; }

        //[ForeignKey("PERFIL")]
        public int COD_PERFIL { get; set; }

        [ForeignKey("COD_PERFIL")]
        public virtual PerfilEntity PERFIL { get; set; }

        //[ForeignKey("IMAGEM")]
        public int? COD_IMAGEM { get; set; }

        [ForeignKey("COD_IMAGEM")]
        public virtual Base64ImagemEntity IMAGEM { get; set; }



        public override int? EntityId()
        {
            return COD_USUARIO;
        }

    }
}
