using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class ImpressaoModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public string Result { get; set; }

        public void OnGet(string Teste)
        {
            Result = Teste;
        }


    }
}