using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class CadastroPizzariaFuncionarioModel : PageModel
    {
        public string Message { get; set; }
        public string Result { get; set; }
            

                public RedirectToPageResult OnPost(string nome, string idade, string nascimento, string rua, string bairro, string formacao,
                    string horario, string setor)
        {
            Result = "Meu nome é "  + nome + ", tenho " + idade + ", nasci em "+nascimento+ ", moro na rua " +rua+", no bairro " +bairro+ ", tenho o "+formacao+
                ", trabalho das "+horario+" e trabalho como "+setor+ ".";

            
            return RedirectToPage("Impressao", new { Teste = Result });

        }

    }
}
