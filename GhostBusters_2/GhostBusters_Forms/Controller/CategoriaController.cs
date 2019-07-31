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
    public class CategoriaController
    {
        public List<CategoriaModel> FindAll()
        {
            return new CategoriaRepository().FindALL().Select(categoria => categoria.MApCategoriaModel()).ToList();
        }

        public List<CategoriaModel> FindByCategoria()
        {
            return new CategoriaRepository().FindAll().Select(categoria => categoria.MApCategoriaModel()).ToList();
        }

        internal CategoriaModel Cadastro(CategoriaModel categoria)
        {
             return new CategoriaRepository().CadastroUpdate(categoria.MapCategoriaEntity()).MApCategoriaModel();
        }

        public void Excluir(CategoriaModel categoria)
        {
            new CategoriaRepository().Excluir(categoria.MapCategoriaEntity().COD_CATEGORIA);
        }
    }
}
