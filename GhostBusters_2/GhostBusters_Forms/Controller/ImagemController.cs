using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class ImagemController
    {
        public ImagemModel Cadastro(ImagemModel imagem)
        {
            return new ImagemRepository().CadastroUpdate(imagem.MapImagemEntity()).MapImagemModel();
        }
        public ImagemModel BuscaNome(string nome)
        {
            return new ImagemRepository().findbyName(nome).MapImagemModel();
        }
        public ImagemModel FindById(int? id)
        {
            return new ImagemRepository().FindById(id).MapImagemModel();
        }
        public void ExcluirImagem(int codigo)
        {
            new ImagemRepository().Excluir(codigo);
        }
    }
}
