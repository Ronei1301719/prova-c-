using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class LoginModel : PageModel
    {
        public string Message { get; set; }
        public string Result { get; set; }
        private object MessageBox;

        public RedirectToPageResult OnPost(string Email, string Senha)
        {
            if(Email == "ronei.1301719@fapi-pinhais.edu.br" && Senha == "1301719")
            {

                return RedirectToPage("Inicial", new { Teste = Result });
            }
            else
            {
                return RedirectToPage("Login", new { Teste = Result });


            }

        }


    }
}
