using GhostBusters_Infra.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Infra
{
    public class GhostBustersContext : DbContext 
    {
        public GhostBustersContext() : base("Ghostbusters") {
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        public void SendChanges()
        {
            ChangeTracker.DetectChanges();
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PerfilEntity>()
                .HasKey(x => x.COD_PERFIL);

            modelBuilder.Entity<Base64ImagemEntity>()
                .HasKey(x => x.COD_IMAGEM);

            modelBuilder.Entity<UsuarioEntity>()
                .HasKey(x => x.COD_USUARIO)
                .HasRequired(perfil => perfil.PERFIL);

            modelBuilder.Entity<UsuarioEntity>()
                .HasOptional(imagem => imagem.IMAGEM);

            modelBuilder.Entity<Base64AnexoEntity>()
                .HasKey(anexo => anexo.COD_ANEXO);

            modelBuilder.Entity<Base64AnexoEntity>()
                .HasRequired(x => x.CHAMADO)
                .WithMany(x => x.ANEXOS);

            modelBuilder.Entity<StatusEntity>()
                .HasKey(x => x.COD_STATUS)
                .HasOptional(perfil => perfil.PERFIL);

            modelBuilder.Entity<ChamadoEntity>()
                .HasKey(x => x.COD_CHAMADO)
                .HasOptional(x => x._STATUS);

           modelBuilder.Entity<ChamadoEntity>()
                .HasRequired(x => x.CATEGORIA);

            modelBuilder.Entity<ChamadoEntity>()
                .HasRequired(x => x.OWNER);

            modelBuilder.Entity<ChamadoEntity>()
                .HasOptional(x => x.TECNICO);

            modelBuilder.Entity<LogEntity>()
                .HasKey(x => x.COD_LOG)
                .HasRequired(x => x.CHAMADO);

            //modelBuilder.Entity<LogEntity>()
            //    .HasRequired(x => x.OWNER);

            modelBuilder.Entity<LogEntity>()
                .HasRequired(x => x.STATUS_ANT);

            modelBuilder.Entity<LogEntity>()
                .HasRequired(x => x.STATUS_NEW);
        }
    }
}
