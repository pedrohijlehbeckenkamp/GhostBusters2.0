using GhostBusters_Forms.Model;
using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Mapper
{
    public static class UsuarioMapper
    {
        public static UsuarioEntity MapUsuarioEntity(this Usuario usuario)
        {
            if (usuario == null)
            {
                return null;
            }
            return new UsuarioEntity()
            {
                COD_USUARIO = usuario.Codigo_Usuario,
                COD_IMAGEM= usuario.Codigo_imagem,
                COD_PERFIL= usuario.Codigo_perfil,
                NOME = usuario.NomeUsuario,
                EMAIL = usuario.Email,
                SENHA = usuario.Senha,
                PERFIL = usuario.perfil.MapPerfilEntity(),
                IMAGEM = usuario.Foto.MapImagemEntity(),
            };
        }
        public static Usuario MapUsuarioModel(this UsuarioEntity usuarioEntity)
        {
            if (usuarioEntity == null)
            {
                return null;
            }
            return new Usuario()
            {
                Codigo_Usuario = usuarioEntity.COD_USUARIO,
                Codigo_imagem = usuarioEntity.COD_IMAGEM,
                Codigo_perfil = usuarioEntity.COD_PERFIL,
                NomeUsuario = usuarioEntity.NOME,
                Email = usuarioEntity.EMAIL,
                Senha = usuarioEntity.SENHA,
                Foto = usuarioEntity.IMAGEM.MapImagemModel(),
                perfil = usuarioEntity.PERFIL.MapPerfilModel()
            };
        }
    }
}
