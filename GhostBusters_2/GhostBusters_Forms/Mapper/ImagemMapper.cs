using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class ImagemMapper
    {
        public static Base64ImagemEntity MapImagemEntity(this ImagemModel imagem)
        {
            if (imagem == null)
            {
                return null;
            }

            return new Base64ImagemEntity()
            {
                COD_IMAGEM = imagem.codigo_imagem,
                NOME = imagem.nomeImagem,
                BASE_DATA = imagem.BaseData
            };
        } 
        public static ImagemModel MapImagemModel(this Base64ImagemEntity imagem64)
        {
            if (imagem64 == null)
            {
                return null;
            }
            return new ImagemModel()
            {
                codigo_imagem = imagem64.COD_IMAGEM,
                nomeImagem = imagem64.NOME,
                BaseData = imagem64.BASE_DATA
            };
        }
    }
}
