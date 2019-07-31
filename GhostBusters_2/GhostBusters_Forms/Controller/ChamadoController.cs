using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class ChamadoController
    {
        public ChamadoModel Cadastro(ChamadoModel chamado)
        {
            return new ChamadoRepository().CadastroUpdate(chamado.MapChamadaEntiy()).MapChamadaModel();
        } 

        public List<ChamadoModel> Findall()
        {
            return new ChamadoRepository().FindALL().Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByStatus(int id)
        {
            return new ChamadoRepository().FindByStatus(id).Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByCategoria(int id)
        {
            return new ChamadoRepository().FindByCategoria(id).Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByOwner(int codigo_owner)
        {
            return new ChamadoRepository().FindByOwner(codigo_owner).Select(owner => owner.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByUsuario(int codigo_owner)
        {
            return new ChamadoRepository().FindByUsuario(codigo_owner).Select(owner => owner.MapChamadaModel()).ToList();
        }

        public ChamadoModel FindByID(int codigo_chamado)
        {
            return new ChamadoRepository().FindById(codigo_chamado).MapChamadaModel();
        }

        public ChamadoModel FindCategoria(int codigo_categoria)
        {
            return new ChamadoRepository().FindCategoria(codigo_categoria).MapChamadaModel();
        }

        public ChamadoModel FindStatus(int codigo_status)
        {
            return new ChamadoRepository().FindStatus(codigo_status).MapChamadaModel();
        }

        public List<ChamadoModel> FindByDate(DateTime data)
        {
            return new ChamadoRepository().FindByDate(data).Select(owner => owner.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindChamadoByID(int IdChamado)
        {
            return new ChamadoRepository().FindChamadoById(IdChamado).Select(id => id.MapChamadaModel()).ToList();
        }

        public ChamadoModel FindByExcluirOwner(int codigo_owner)
        {
            return new ChamadoRepository().FindByOwnerChamado(codigo_owner).MapChamadaModel();
        }
        public List<ChamadoModel> FindByTecnico(int codigo_tecnico)
        {
            return new ChamadoRepository().FindByTecnico(codigo_tecnico).Select(tecnico => tecnico.MapChamadaModel()).ToList();
        }

        public List<ChamadoModel> FindByTech(int codigo_tecnico)
        {
            return new ChamadoRepository().FindByTech(codigo_tecnico).Select(tecnico => tecnico.MapChamadaModel()).ToList();
        }
        public List<ChamadoModel> FindByExcluir()
        {
            return new ChamadoRepository().FindByExcluirChamado().Select(Chamado => Chamado.MapChamadaModel()).ToList();
        }
        public void ExcluirChamado(ChamadoModel chamado)
        {
            for (int i = 0; i < chamado.anexos.Count; i++)
            {
                new AnexoController().ExcluirAnexo(chamado.anexos.ToArray()[i].Codigo_Anexo);
            }
            new ChamadoRepository().Excluir(chamado.Codigo_chamado);
        }

        public bool EnviarEmail(string titulo, string observacao, string email)
        {          
                MailMessage mail = new MailMessage();

                SmtpClient SmtpServer = new SmtpClient("smtp.mailtrap.io");//"smtp.mailtrap.io"

            mail.From = new MailAddress("ghostbusters@Help.com");//"cliente1@gmail.com"
            mail.To.Add(email);
            mail.Subject = "Ghostbursters_Help";
            mail.Body = observacao;



            SmtpServer.Port = 2525;//2525
            SmtpServer.Credentials = new System.Net.NetworkCredential("34df19e33dd4ab", "21a5742843ccb2");//"ac0a02e54dc47a", "b8ed85b31e2102"
            SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            return true;
        }
    }
}
