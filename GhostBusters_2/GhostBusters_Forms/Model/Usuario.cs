using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Model
{
    public class Usuario
    {
        public int Codigo_Usuario { get; set; }
        public int? Codigo_imagem { get; set; }
        public int Codigo_perfil { get; set; }
        public string NomeUsuario { get; set; }
        public  string Email { get; set; }
        public string Senha { get; set; }
        public PerfilModel perfil { get; set; }
        public ImagemModel Foto { get; set; }

        public string NomePerfil { get { return perfil.nomePerfil; } }
    }
}
