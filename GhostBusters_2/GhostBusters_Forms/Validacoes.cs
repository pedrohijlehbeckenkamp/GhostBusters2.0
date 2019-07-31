using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GhostBusters_Forms
{
    public static class Validacoes
    {
        public static bool ValidaCamponull(string item)
        {
            //params string[] param
            string teste = "";
          //  foreach (var item in param)
            //{
                if (item == teste)
                {
                  return true; 
                }
           // }
            return false;
        }
        public static bool ValidaNome(string nome)
        {
            if (!Regex.IsMatch(nome, @"^[ a-zA-Z záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$"))
                return true;
            return false;
        }
        public static bool ValidaEmail(string email)
        {
            Regex validaEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!validaEmail.IsMatch(email))
                return true;
            return false;
        }
        public static bool ValidaNomesDiferentes(string Nome, string confirmaNome)
        {
            if (confirmaNome != Nome)
                return true;
            return false;
        }
        public static bool ValidaSenhasIguais(string Nome, string confirmaNome)
        {
            if (confirmaNome == Nome)
                return true;
            return false;
        }
        public static bool ValidaTamanhaSenha(string senha)
        {
            if (senha.Length <6)
                return true;
            return false;
        }
    }
}
